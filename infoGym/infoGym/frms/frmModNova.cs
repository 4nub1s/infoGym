using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym.frms
{
    public partial class frmModNova : Form
    {
        Modalidade mod;
        public frmModNova(String modId)
        {
            InitializeComponent();
            mod = new Modalidade();
            if (modId != "") //atualiza
            {
                mod.Id = modId;
                mod = mod.getById();
                adaptaInterface();
            }
        }

        private void adaptaInterface()
        {
            btnAdd.Image = imageList1.Images[0];
            ttbNome.Text = mod.Desc;
            ttbValorD.Text = mod.ValorD;
            ttbValorM.Text = mod.ValorM;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ttbNome.Text == "")
                ttbNome.BackColor = Color.Red;
            else
            {
                if (mod.Id != "") //atualiza
                {
                    mod.Desc = ttbNome.Text;
                    mod.ValorM = ttbValorM.Text;
                    mod.ValorD = ttbValorD.Text;
                    if (mod.altera())
                    {
                        MessageBox.Show("Modalidade alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um problema ao realizar a atualização da modalidade!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mod.Desc = ttbNome.Text;
                    mod.ValorD = ttbValorD.Text;
                    mod.ValorM = ttbValorM.Text;
                    if (mod.nova())
                    {
                        MessageBox.Show("Modalidade cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um problema ao realizar o cadastro da modalidade!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ttbNome_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void ttbValorM_KeyPress(object sender, KeyPressEventArgs e)
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
