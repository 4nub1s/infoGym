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
    public partial class frmCaixaNovo : Form
    {
        Usuario user;
        Caixa cai;
        public frmCaixaNovo(Usuario user)
        {
            InitializeComponent();
            cai = new Caixa();
            this.user = user;
            lblUser.Text = user.Login;
            lblCon.Text = user.getUltimaCon();  
        }

        

        private void ttbValor_Click(object sender, EventArgs e)
        {
            ttbValor.BackColor = Color.White;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ttbValor.Text == "")
                ttbValor.BackColor = Color.Red;
            else
            {
                cai.CaiData = DateTime.Today.ToShortDateString();
                cai.CaiAbert = DateTime.Now + "";
                cai.CaiValorIni = ttbValor.Text;
                cai.UserAbriu = user.Id + "";
                if (cai.novo())
                {
                    MessageBox.Show("Caixa do dia: " + cai.CaiData + " com valor inicial de R$"+ttbValor.Text + " foi aberto com sucesso!",
                        "Caixa iniciado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ocorreu um problema ao iniciar o caixa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
