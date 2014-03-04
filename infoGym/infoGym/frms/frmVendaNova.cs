using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym
{
    public partial class frmVendaNova : Form
    {
        Decimal valor, valorTotal;
        int qtde, qtdeTotal;
        int estoqueRestante;
        int idAtual;
        Produto prod;
        Aluno alu;
        DataTable dttItensVenda;
        Venda ven;
        Usuario user;
        Caixa cai;
        public frmVendaNova(Usuario user, String venCod)
        {
            InitializeComponent();
            Caixa cai = new Caixa();
            cai.CaiData = DateTime.Today.ToShortDateString();
            cai = cai.getCaixaByData();
            if (cai.CaiAbert == "")
            {
                MessageBox.Show("Caixa não foi aberto!", "Venda não permitida!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            inicializaItensVenda();
            this.user = user;
            lblUserOn.Text = user.Login;
            if (venCod != "")
            {
                ven = new Venda();
                ven.Cod = venCod;
                ven = ven.getById();
                btnConfirmar.Visible = false;
                gpbProduto.Visible = false;
                Usuario userAux = new Usuario();
                userAux.Id = Convert.ToInt32(ven.AcessId);
                userAux = userAux.getUserById();
                lblQuemRealizou.Text = userAux.Login;
                lblDataVenda.Text = Convert.ToDateTime(ven.Data).ToShortDateString();
                btnAluAdd.Visible = false;
                btnClear.Visible = false;
                btnConfirmar.Visible = false;
                btnRemoveItem.Visible = false;
                cbbFormaPgmto.Enabled = false;
                foreach (ItensVenda p in ven.getItens())
                {
                    DataRow linha = dttItensVenda.NewRow();
                    linha["prod_id"] = p.ProdId;
                    Produto prod = new Produto();
                    prod.Id = p.ProdId;
                    prod = prod.getById();
                    linha["nome"] = prod.Desc;
                    linha["qtde"] = p.Qtde;
                    linha["valor"] = p.Valor;
                    linha["preco_unit"] = Convert.ToDecimal(p.Valor) / Convert.ToInt32(p.Qtde);
                    qtdeTotal += Convert.ToInt32(p.Qtde);
                    dttItensVenda.Rows.Add(linha);
                }
                if (ven.AluId != "")
                {
                    Aluno aluAux = new Aluno();
                    aluAux.Id = Convert.ToInt32(ven.AluId);
                    aluAux = aluAux.getAlunoById();
                    ttbAluNome.Text = aluAux.Nome;
                }
                else
                    ttbAluNome.Text = "---";
                lblQtdeItens.Text = "" + qtdeTotal;
                lblValorTotal.Text = ven.Valor;
                cbbFormaPgmto.Text = ven.FormaPgmto;
            }
            else
            {
                ttbQtde.Enabled = false;
                lblDataVenda.Text = DateTime.Today.ToShortDateString();
                lblQuemRealizou.Text = user.Login;
                valor = 0;
                qtde = 1;
                valorTotal = 0;
                qtdeTotal = 0;
                lblValorTotal.Text = "R$" + valorTotal;
                lblQtdeItens.Text = "" + qtdeTotal;
                lblSubTotal.Text = "R$" + qtde * valor;
                btnClear.Enabled = false;
                btnRemoveItem.Enabled = false;
                cbbFormaPgmto.Text = "À vista";
                cbbFormaPgmto.Enabled = false;
            }
            
            
           
            
        }

        private void ttbQtde_TextChanged(object sender, EventArgs e)
        {
            try
            {
                qtde = Convert.ToInt32(ttbQtde.Value);
                lblSubTotal.Text = "R$" + qtde * valor;
            }
            catch { lblSubTotal.Text = "R$" + ""; }
        }

        private void ttbValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDecimal(ttbValor.Text);
                lblSubTotal.Text = "R$" + qtde * valor;
            }
            catch { lblSubTotal.Text = "R$" + ""; }
        }

        private void ttbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool jaPossuiVirgula = false;
            int numCasasPosVirgula = 0;
            int i = 0;
            while (i < ((TextBox)sender).Text.Length && !jaPossuiVirgula)
            {
                if (((TextBox)sender).Text[i] == ',')
                    jaPossuiVirgula = true;
                i++;
                if (jaPossuiVirgula)
                    numCasasPosVirgula = ((TextBox)sender).Text.Length - i;
            }

            if (e.KeyChar == '.') //substitui . por , deixando no padrão decimal
                e.KeyChar = ',';

            if (e.KeyChar == ',')
                if (jaPossuiVirgula)
                    e.Handled = true; //impede digitação

            if (e.KeyChar != ',' && e.KeyChar != (char)8)
                if (!char.IsDigit(e.KeyChar) || numCasasPosVirgula > 1)
                    e.Handled = true;
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            frmProdGerenciar frmProdGer = new frmProdGerenciar(true);
            frmProdGer.ShowDialog();
            if (frmProdGer.getIsPesquisa())
            {
                String prodCod = frmProdGer.getProduto();
                prod = new Produto();
                prod.Id = prodCod;
                prod = prod.getById();
                ttbDesc.Text = prod.Desc;
                ttbValor.Text = prod.Valor;
                ttbQtde.Enabled = true;
                ttbQtde.Value = 1;
                //verifica se produto já apareceu alguma vez na venda, se apareceu
                //vai ser descontado a quantidade de vezes que apareceu do estoque atual(lbl)
                DataRow[] result = dttItensVenda.Select("prod_id = '" + prod.Id + "'");
                if (result.Length > 0)
                {
                    estoqueRestante = Convert.ToInt32(prod.EstoqueA);
                    estoqueRestante -= Convert.ToInt32(result[0]["qtde"]);
                    lblEstoqueAtual.Text = "" + estoqueRestante;
                    ttbQtde.Maximum = estoqueRestante;
                }
                else
                {
                    estoqueRestante = Convert.ToInt32(prod.EstoqueA);
                    lblEstoqueAtual.Text = "" + estoqueRestante;
                    ttbQtde.Maximum = estoqueRestante;
                }
                if (estoqueRestante == 0)
                {
                    ttbQtde.Minimum = 1;
                    ttbQtde.Maximum = 1;
                    ttbQtde.Value = 1;
                }
            }
        }

        private void inicializaItensVenda()
        {
            dttItensVenda = new DataTable();
            dttItensVenda.Columns.Add("prod_id");
            dttItensVenda.Columns.Add("nome");
            dttItensVenda.Columns.Add("qtde");
            dttItensVenda.Columns.Add("valor");
            dttItensVenda.Columns.Add("preco_unit");
            dtgvItensVenda.DataSource = dttItensVenda;
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (ttbDesc.Text == "")
                ttbDesc.BackColor = Color.Red;
            if (ttbDesc.Text != "")
            {
                //busca o produto que se deseja inserir na lista dos inseridos anteriormente
                //caso encontre apenas atualiza seu valor e quantidade
                DataRow[] result = dttItensVenda.Select("prod_id = '" + prod.Id + "'");
                if (result.Length > 0)
                {
                    result[0]["qtde"] = qtde + Convert.ToInt32(result[0]["qtde"]);
                    result[0]["valor"] = valor * qtde + Convert.ToDecimal(result[0]["valor"]);
                }
                else
                {
                    DataRow linha = dttItensVenda.NewRow();
                    linha["prod_id"] = prod.Id;
                    linha["nome"] = ttbDesc.Text;
                    linha["qtde"] = ttbQtde.Value;
                    linha["valor"] = qtde * valor;
                    linha["preco_unit"] = valor;
                    dttItensVenda.Rows.Add(linha);
                }

                qtde = 1;
                valor = 0;
                ttbDesc.Text = "";
                ttbQtde.Text = "";
                ttbValor.Text = "";
                lblEstoqueAtual.Text = "---";
                ttbQtde.Enabled = false;
                atualizaTotais();
            }

        }

        private void ttbValor_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente reiniciar a venda, limpando todos os itens já selecionados?", "Limpar itens",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                inicializaItensVenda();
                atualizaTotais();
            }
        }

        private void btnAluAdd_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAlu = new frmAluGerenciamento(true, user);
            frmAlu.ShowDialog();
            if (frmAlu.getPesquisaRealizada())
            {
                alu = new Aluno();
                alu.Id = frmAlu.getAluId();
                alu = alu.getAlunoById();
                ttbAluNome.Text = alu.Nome;
                cbbFormaPgmto.Enabled = true;
                cbbFormaPgmto.Text = "Na mensalidade";
            }
            else
            {
                alu = new Aluno();
                ttbAluNome.Text = "";
                cbbFormaPgmto.Enabled = false;
                cbbFormaPgmto.Text = "À vista";
            }
        }

        private void dtgvItensVenda_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvItensVenda.Rows.Count == 0)
            {
                btnClear.Enabled = false;
                btnRemoveItem.Enabled = false;
            }
        }

        private void dtgvItensVenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtgvItensVenda.Rows.Count > 0)
            {
                btnClear.Enabled = true;
                btnRemoveItem.Enabled = true;
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            DataRow[] result = dttItensVenda.Select("prod_id = '" + idAtual + "'");
            dttItensVenda.Rows.Remove(result[0]);
            atualizaTotais();
        }

        private void lblEstoqueAtual_TextChanged(object sender, EventArgs e)
        {
            if (lblEstoqueAtual.Text.Equals("0")) //sem estoque
                btnAddProd.Enabled = false;
            else
                btnAddProd.Enabled = true;
        }

        private void dtgvItensVenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvItensVenda.CurrentCell != null)
            {
                DataRow linha = ((DataRowView)dtgvItensVenda.CurrentRow.DataBoundItem).Row;
                idAtual = Convert.ToInt32(linha["prod_id"]);
            }
        }

        private void lblValorTotal_TextChanged(object sender, EventArgs e)
        {
            if (valorTotal > 0)
            {
                btnConfirmar.Enabled = true;
            }
            else
                btnConfirmar.Enabled = false;
        }

        private void atualizaTotais()
        {
            qtdeTotal = 0;
            valorTotal = 0;
            for (int i = 0; i < dttItensVenda.Rows.Count; i++)
            {
                qtdeTotal += Convert.ToInt32(dttItensVenda.Rows[i]["qtde"]);
                valorTotal += Convert.ToDecimal(dttItensVenda.Rows[i]["valor"]);
            }
            lblValorTotal.Text = "R$" + valorTotal;
            lblQtdeItens.Text = "" + qtdeTotal;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente realizar a venda?", "Vender?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                ven = new Venda();
                for (int i = 0; i < dttItensVenda.Rows.Count; i++)
                {
                    ven.addItem(dttItensVenda.Rows[i]["prod_id"].ToString(),
                        dttItensVenda.Rows[i]["qtde"].ToString(),
                        dttItensVenda.Rows[i]["valor"].ToString());
                }
                ven.verificaEstoque();
                if (ven.Msg != "")
                {
                    MessageBox.Show(ven.Msg, "Venda não pode ser realizada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    inicializaItensVenda();
                    atualizaTotais();
                }
                else //realiza venda
                {
                    ven.Data = DateTime.Today.ToShortDateString();
                    if (alu != null)
                        ven.AluId = "" + alu.Id;
                    ven.Valor = lblValorTotal.Text;
                    ven.AcessId = "" + user.Id;
                    ven.FormaPgmto = cbbFormaPgmto.Text;
                    if (ven.gravar())
                    {
                        if (ven.FormaPgmto.Equals("À vista"))
                        {
                            Movimentacao mov = new Movimentacao();
                            mov.AcessId = ven.AcessId;
                            mov.CaiData = ven.Data;
                            mov.Desc = "venda produto";
                            mov.Valor = ven.Valor;
                            mov.VenCod = ven.Cod;
                            mov.novaEntrada();
                        }
                        MessageBox.Show("Venda realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja emitir recibo?", "Recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //chamar relatório vendas passando ven_id
                            MessageBox.Show("utilizirá relatório!", "Em breve!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao realizar a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
