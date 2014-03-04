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
    public partial class frmMensalidadePgmto : Form
    {
        Usuario user;
        Matricula mat;
        Decimal valorMens, valorDesc, valorFinal, valorProporcional, valorProdutos;
        Movimentacao mov;
        DataTable dtVendasSemEntrada;
        public frmMensalidadePgmto(Usuario user, String matCod)
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
            chkDesc.Checked = false;
            valorMens = valorDesc = valorFinal = valorProporcional = 0;
            this.user = user;
            mat = new Matricula();
            mat.Id = matCod;
            mat = mat.getById();
            lblMatCod.Text = mat.Id;
            lblMatDtIni.Text = DateTime.Parse(mat.DtIni).ToShortDateString();
            lblMatVenc.Text = mat.DtVcmto;
            Modalidade modAux = new Modalidade();
            modAux.Id = mat.ModId;
            modAux = modAux.getById();
            valorMens = Convert.ToDecimal(modAux.ValorM);
            lblValorMens.Text = "R$" + valorMens;
            if (!lblValorMens.Text.Contains(","))
                lblValorMens.Text += ",00";
            atualizaTotal();
            lblUserOn.Text = user.Login;

            mov = new Movimentacao();
            mov.MatCod = mat.Id;
            int qtdeMensalidades = mov.getQtdeMensalidades();
            int fatorPrimeiraParcela = 0;
            String[] diaInicio = mat.DtIni.Split('/');
            if (mat.DtVcmto != diaInicio[0])
            {
                fatorPrimeiraParcela = 1;
                if (qtdeMensalidades == 0) //primeira mens. com valor proporcional a calcular
                {
                    chkProporcional.Visible = true;
                    lblValorProp.Visible = true;
                    Decimal valorDia = Convert.ToDecimal(modAux.ValorM) / 30;
                    DateTime dtInicial = DateTime.Parse(mat.DtIni);
                    DateTime dtVcmto = new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, Convert.ToInt32(mat.DtVcmto));
                    TimeSpan dif = dtVcmto - dtInicial;
                    valorProporcional = dif.Days * valorDia;
                    valorProporcional = Math.Round(valorProporcional, 2);
                    atualizaTotal();
                }
            }
            DateTime mensAtual = DateTime.Parse(mat.DtIni).AddMonths(qtdeMensalidades + fatorPrimeiraParcela);
            DateTime mensAtual2 = new DateTime(mensAtual.Year, mensAtual.Month, Convert.ToInt32(mat.DtVcmto));
            lblMensVenc.Text = mensAtual2.ToShortDateString();


            Venda ven = new Venda();
            dtVendasSemEntrada = ven.getVendasSemEntrada(mat.AluId);
            if (dtVendasSemEntrada.Rows.Count > 0) //possui vendas sem pagar
            {
                valorProdutos = 0;
                for (int i = 0; i < dtVendasSemEntrada.Rows.Count; i++)
                    valorProdutos += Convert.ToDecimal(dtVendasSemEntrada.Rows[i]["ven_valor"]);
                lblProdutosValor.Text = "R$"+valorProdutos;
                if (!lblProdutosValor.Text.Contains(','))
                    lblProdutosValor.Text += ",00";
                atualizaTotal();
                gpbProdutos.Enabled = true;
            }
            else
                gpbProdutos.Enabled = false;

        }

        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesc.Checked)
                ttbValorDesc.Visible = true;
            else
            {
                ttbValorDesc.Visible = false;
                ttbValorDesc.Text = "0";
            }
            atualizaTotal();

        }

        private void ttbValorDesc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valorDesc = Convert.ToDecimal(ttbValorDesc.Text);
            }
            catch
            {
                valorDesc = 0;
            }
            atualizaTotal();
        }

        private void atualizaTotal()
        {
            lblValorProp.Text = "R$" + (valorProporcional + valorMens);
            if (!lblValorProp.Text.Contains(","))
                lblValorProp.Text += ",00";
            valorFinal = valorMens;
            if (chkProporcional.Checked)
                valorFinal += valorProporcional;
            valorFinal -= valorDesc;
            if (valorFinal < 0)
                valorFinal = valorMens;
            valorFinal += valorProdutos;
            lblValorFinal.Text = "R$" + valorFinal;
            if (!lblValorFinal.Text.Contains(","))
                lblValorFinal.Text += ",00";
        }

        private void ttbValorDesc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void chkProporcional_CheckedChanged(object sender, EventArgs e)
        {
            atualizaTotal();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Aluno aluAux = new Aluno();
            aluAux.Id = Convert.ToInt32(mat.AluId);
            aluAux = aluAux.getAlunoById();
            mov.AcessId = "" + user.Id;
            mov.CaiData = DateTime.Today.ToShortDateString();
            mov.Desc = "Pagamento mensalidade mês de " + DateTime.Parse(lblMensVenc.Text).ToString("MMMM") +
                " do aluno " + aluAux.Nome;
            mov.MatCod = mat.Id;
            mov.Valor = "" + (valorFinal - valorProdutos);
            if (MessageBox.Show("Deseja realmente efetuar o pagamento?", "Confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (mov.novaEntrada())
                {
                    for (int i = 0; i < dtVendasSemEntrada.Rows.Count; i++)
                    {
                        mov.MatCod = "";
                        mov.Desc = "venda produto";
                        mov.VenCod = dtVendasSemEntrada.Rows[i]["ven_cod"].ToString();
                        mov.Valor = dtVendasSemEntrada.Rows[i]["ven_valor"].ToString();
                        mov.novaEntrada();
                    }
                    MessageBox.Show("Pagamento realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Deseja imprimir o comprovante de pagamento?", "Imprimir comprovante", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        MessageBox.Show("Em breve, usar chamada relatório mensalidade!");

                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao pagar mensalidade!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompraDetalhes_Click(object sender, EventArgs e)
        {
            frmVendaControlar frmVenda = new frmVendaControlar(user, mat.AluId);
            frmVenda.ShowDialog();
        }
    }
}
