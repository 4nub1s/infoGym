using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace infoGym
{
    public partial class frmUserAlteraSenha : Form
    {
        Usuario user;
        public frmUserAlteraSenha(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            ttbLogin.Text = user.Login;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ttbOldPas.Text == "")
                ttbOldPas.BackColor = Color.Red;
            if (ttbNewPas.Text == "")
                ttbNewPas.BackColor = Color.Red;
            if (ttbNewPasC.Text == "")
                ttbNewPasC.BackColor = Color.Red;
            if (ttbOldPas.Text != "" && ttbNewPas.Text != "" && ttbNewPasC.Text != "")
            {
                if (ttbOldPas.Text != user.Senha)
                    MessageBox.Show("Senha não confere com senha atual!", "Não foi possível realizar a alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (ttbNewPas.Text != ttbNewPasC.Text)
                    {
                        ttbNewPas.BackColor = Color.Green;
                        ttbNewPasC.BackColor = Color.Beige;
                    }
                    else
                    {
                        user.Senha = ttbNewPas.Text;
                        if (user.trocaSenha())
                        {
                            MessageBox.Show("Alteração realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreu um erro na alteração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
             
            }
        }

        private void ttbOldPas_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }
    }
}
