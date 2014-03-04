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
    public partial class frmExeNovo : Form
    {
        Exercicio exe;
        public frmExeNovo(String exeId)
        {
            InitializeComponent();
            exe = new Exercicio();
            exe.Id = exeId;
            if (exe.Id != "")
            {
                exe = exe.getById();
                adptaInterface();
            }
        }

        private void adptaInterface()
        {
            this.Text = "Atualizar exercício";
            ttbArea.Text = exe.Area;
            ttbNome.Text = exe.Desc;
            btnAdd.Image = imageList1.Images[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ttbArea.Text == "")
                ttbArea.BackColor = Color.Red;
            if (ttbNome.Text == "")
                ttbNome.BackColor = Color.Red;

            if (ttbNome.Text != "" && ttbArea.Text != "")
            {
                exe.Desc = ttbNome.Text;
                exe.Area = ttbArea.Text;
                if (exe.Id != "") //altera
                {
                    if (exe.altera())
                    {
                        MessageBox.Show("Alteração realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao realizar a alteração!", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //cadastra
                {
                    if (exe.novo())
                    {
                        MessageBox.Show("Exercício cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao realizar o cadastro!", "Problemas!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ttbNome_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
