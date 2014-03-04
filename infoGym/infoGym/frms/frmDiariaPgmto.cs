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
    public partial class frmDiariaPgmto : Form
    {
        Usuario user;
        Utils util;
        Decimal valorFinal, valorDesc, valorDiaria, creditosAtuais, creditoSaldo;
        Matricula mat;
        public frmDiariaPgmto(String matCod, Usuario user)
        {
            InitializeComponent();
            mat = new Matricula();
            valorFinal = valorDesc = valorDiaria = 0;
            util = new Utils();
            this.user = user;
            lblUserOn.Text = user.Login;
            mat.Id = matCod;
            mat = mat.getById();
            lblMatCod.Text = mat.Id;
            lblMatDtIni.Text = DateTime.Parse(mat.DtIni).ToShortDateString();
            creditosAtuais = Convert.ToDecimal(mat.QtdeDias);
            Modalidade mod = new Modalidade();
            mod.Id = mat.ModId;
            mod = mod.getById();
            valorDiaria = Convert.ToDecimal(mod.ValorD);
            atualizaTotal();
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

        private void atualizaTotal()
        {
            lblCreditosAtuais.Text = ""+creditosAtuais;
            creditoSaldo = creditosAtuais + numDias.Value;
            lblSaldoCreditos.Text = ""+creditoSaldo;
            valorFinal = numDias.Value * valorDiaria;
            valorFinal -= valorDesc;
            lblValorDiaria.Text = ""+valorDiaria;
            lblValorDiaria.Text = util.moneyFormata(lblValorDiaria.Text);
            lblValorFinal.Text = util.moneyFormata(""+valorFinal);
        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            mat.QtdeDias = ""+numDias.Value;
            if (MessageBox.Show("Deseja realmente efetuar o pagamento?", "Confirma?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (mat.adicionarCreditos("" + user.Id, valorFinal))
                {
                    MessageBox.Show("Créditos adicionados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Deseja imprimir o comprovante de pagamento?", "Imprimir comprovante", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        MessageBox.Show("Em breve, usar chamada relatório mensalidade!");
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao adicionar os créditos!", "Não realizada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
