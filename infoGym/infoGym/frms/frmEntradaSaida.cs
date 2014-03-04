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
    public partial class frmEntradaSaida : Form
    {
        Usuario user;
        String tipoOp;
        String dtCaixa;
        Movimentacao mov;
        String opId = "";
        public frmEntradaSaida(String tipoOperacao, Usuario user, String dataCaixa, bool permiteEscrita, String opId)
        {
            InitializeComponent();
            this.opId = opId;
            mov = new Movimentacao();
            tipoOp = tipoOperacao;
            dtCaixa = dataCaixa;
            this.Text = tipoOperacao;
            this.user = user;
            lblUser.Text = user.Login;
            lblData.Text = dataCaixa;
            if (tipoOperacao.Equals("Entrada"))
                btnConfirma.Image = imageList1.Images[0];
            if (tipoOperacao.Equals("Saída"))
                btnConfirma.Image = imageList1.Images[1];
            if (!permiteEscrita)
            {
                ttbDesc.Enabled = false;
                ttbValor.Enabled = false;
                btnConfirma.Visible = false;
                mov.EntradaId = opId;
                if (tipoOperacao.Equals("Entrada"))
                    mov = mov.getEntradaById();
                else
                    mov = mov.getSaidaById();
                ttbDesc.Text = mov.Desc;
                ttbValor.Text = new Utils().moneyFormata(mov.Valor);
                lblData.Text = DateTime.Parse(mov.CaiData).ToShortDateString();
            }
        }

        private void ttbValor_Click(object sender, EventArgs e)
        {
            ttbValor.BackColor = Color.White;
        }

        private void ttbDesc_Click(object sender, EventArgs e)
        {
            ttbDesc.BackColor = Color.White;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (ttbValor.Text == "")
                ttbValor.BackColor = Color.Red;
            if (ttbDesc.Text == "")
                ttbDesc.BackColor = Color.Red;
            else
                if (ttbValor.Text != "")
                {
                    mov.AcessId = ""+user.Id;
                    mov.CaiData = dtCaixa;
                    mov.Desc = ttbDesc.Text;
                    mov.Valor = ttbValor.Text;
                    if (tipoOp.Equals("Entrada"))
                    {
                        if (mov.novaEntrada())
                        {
                            MessageBox.Show("Entrada efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreu um problema ao efetuar a entrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (mov.novaSaida())
                        {
                            MessageBox.Show("Saída efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreu um problema ao efetuar a saída!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
    }
}
