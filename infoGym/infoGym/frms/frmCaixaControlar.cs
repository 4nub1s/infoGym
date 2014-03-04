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
    public partial class frmCaixaControlar : Form
    {
        Utils util;
        Usuario user;
        Movimentacao mov;
        Caixa cai;
        Decimal entradas, saidas, saldo, valorFinal;
        String filtro = "";
        DataTable dtMovimentacoes;
        bool isFechamento;
        public frmCaixaControlar(Usuario user, bool isFechamento)
        {
            InitializeComponent();
            util = new Utils();
            this.isFechamento = isFechamento;
            filtro = "ambas";
            this.user = user;
            mov = new Movimentacao();
            cai = new Caixa();
            atualizaInfo();
            atualizaDtgv();
            atualizaTela();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            new frmEntradaSaida("Entrada", user, DateTime.Today.ToShortDateString(), true, "").ShowDialog();
            dtpData.Value = DateTime.Today;
            rbAmbas.Checked = true;
            atualizaInfo();
            atualizaDtgv();
            atualizaTela();
        }

        private void atualizaInfo()
        {
            entradas = Convert.ToDecimal(mov.getTotalEntradas());
            lblEntradas.Text = util.moneyFormata("" + entradas);
            saidas = Convert.ToDecimal(mov.getTotalSaidas());
            lblSaídas.Text = util.moneyFormata("" + saidas);
            Decimal movimento = entradas - saidas;
            lblMovimento.Text = util.moneyFormata("" + movimento);
            Decimal valorInicial;
            Decimal.TryParse(cai.CaiValorIni, out valorInicial);
            Decimal saldo = movimento + valorInicial;
            lblSaldo.Text = util.moneyFormata("" + saldo);

            lblAbertura.Text = cai.CaiAbert;
            lblValorAbertura.Text = util.moneyFormata("" + cai.CaiValorIni);

            Usuario userAux;
            userAux = new Usuario();
            if (cai.UserAbriu != "")
            {
                userAux.Id = Convert.ToInt32(cai.UserAbriu);
                userAux = userAux.getUserById();
                lblQuemRealizouAbertura.Text = userAux.Login;
            }
            else
                lblQuemRealizouAbertura.Text = "---";

            if (cai.isFechado())
            {
                lblHoraFechamento.Text = cai.CaiFech;
                ttbValorFechamento.Text = cai.CaiValorFin;
                if (cai.UserFechou != "")
                {
                    userAux.Id = Convert.ToInt32(cai.UserFechou);
                    userAux = userAux.getUserById();
                    lblQuemRealizouFechamento.Text = userAux.Login;
                    valorFinal = Convert.ToDecimal(cai.CaiValorIni) + entradas - saidas;
                    Decimal sobraFalta = Convert.ToDecimal(ttbValorFechamento.Text) - valorFinal;
                    lblSobraCaixa.Text = "---";
                    lblFaltaCaixa.Text = "---";
                    if (sobraFalta > 0)
                        lblSobraCaixa.Text = util.moneyFormata(""+sobraFalta);
                    else
                        lblFaltaCaixa.Text = util.moneyFormata(""+Math.Abs(sobraFalta));
                }

            }
            else
            {
                lblHoraFechamento.Text = "---";
                lblQuemRealizouFechamento.Text = "---";
                lblSobraCaixa.Text = "---";
                lblFaltaCaixa.Text = "---";
                ttbValorFechamento.Text = "";
            }

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            new frmEntradaSaida("Saída", user, DateTime.Today.ToShortDateString(), true, "").ShowDialog();
            dtpData.Value = DateTime.Today;
            rbAmbas.Checked = true;
            atualizaInfo();
            atualizaDtgv();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            mov.CaiData = dtpData.Value.ToShortDateString();
            cai.CaiData = mov.CaiData;
            cai = cai.getCaixaByData();
            atualizaDtgv();
            atualizaInfo();
            atualizaTela();
        }

        private void atualizaTela()
        {
            if (dtgvCaixa.Rows.Count == 0)
            {
                btnInfo.Enabled = false;
                btnExcluir.Enabled = false;
            }
            if (cai.CaiAbert == "") //selecionou data sem caixa aberto
            {
                dtpData.Value = Convert.ToDateTime(cai.getUltimoCaixa()); //volta ultimo caixa
            }
            if (cai.isFechado())
            {
                btnExcluir.Enabled = false;
                btnFecharCaixa.Enabled = false;
                btnEntrada.Enabled = false;
                btnSaida.Enabled = false;
                ttbValorFechamento.Enabled = false;
            }
            else
            {
                if (dtgvCaixa.Rows.Count > 0)
                    btnExcluir.Enabled = true;
                btnFecharCaixa.Enabled = true;
                btnEntrada.Enabled = true;
                btnSaida.Enabled = true;
                ttbValorFechamento.Enabled = true;
            }
        }

        private void atualizaDtgv()
        {
            dtMovimentacoes = mov.getMovByDia(filtro);
            dtgvCaixa.DataSource = dtMovimentacoes;
        }

        private void rbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbas.Checked)
                filtro = "ambas";
            if (rbEntrada.Checked)
                filtro = "entrada";
            if (rbSaida.Checked)
                filtro = "saida";
            atualizaDtgv();
        }

        private void dtgvCaixa_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvCaixa.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnInfo.Enabled = false;
            }
        }

        private void dtgvCaixa_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvCaixa.CurrentCell != null)
            {
                DataRow linha = ((DataRowView)dtgvCaixa.CurrentRow.DataBoundItem).Row;
                if (Convert.ToBoolean(linha["isEntrada"]))
                    mov.EntradaId = linha["id"].ToString();
                else
                    mov.SaidaId = linha["id"].ToString();
                mov.Desc = linha["desc"].ToString();
            }
        }

        private void ttbValorFechamento_Click(object sender, EventArgs e)
        {
            ttbValorFechamento.BackColor = Color.White;
        }

        private void ttbValorFechamento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnFecharCaixa_Click(object sender, EventArgs e)
        {
            if (ttbValorFechamento.Text == "")
                ttbValorFechamento.BackColor = Color.Red;
            else
                if (MessageBox.Show("Deseja realmente fechar o caixa?", "Fechar o caixa?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cai.CaiFech = DateTime.Now.ToString();
                    cai.UserFechou = user.Id + "";
                    cai.CaiValorFin = ttbValorFechamento.Text;
                    if (cai.fechar())
                    {
                        MessageBox.Show("Caixa fechado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cai = cai.getCaixaByData();
                        atualizaInfo();
                        atualizaTela();
                    }
                    else
                        MessageBox.Show("Ocorreu um problema no fechamento do caixa!", "Erro", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }

        }

        private void dtgvCaixa_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if(!cai.isFechado())
                btnExcluir.Enabled = true;
            btnInfo.Enabled = true;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (mov.EntradaId != "")
                new frmEntradaSaida("Entrada", user, cai.CaiData, false, mov.EntradaId).ShowDialog();
            else
                new frmEntradaSaida("Saída", user, cai.CaiData, false, mov.SaidaId).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir a movimentação: "+mov.Desc+"?", "Excluir movimentação?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (mov.excluir())
                {
                    MessageBox.Show("Movimentação excluida com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaInfo();
                    atualizaTela();
                    atualizaDtgv();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao excluir a movimentação", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dtgvCaixa_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                if (dtMovimentacoes.Rows[e.Row.Index]["movTipo"].Equals("Entrada")) //imagem seta
                    dtgvCaixa.Rows[e.Row.Index].Cells["img"].Value = imageList1.Images[1];
                else
                    dtgvCaixa.Rows[e.Row.Index].Cells["img"].Value = imageList1.Images[0];
                if(!dtgvCaixa.Rows[e.Row.Index].Cells["valor"].Value.ToString().Contains("R$"))
                    dtgvCaixa.Rows[e.Row.Index].Cells["valor"].Value = util.moneyFormata(dtgvCaixa.Rows[e.Row.Index].Cells["valor"].Value.ToString());
            }
        }


    }
}
