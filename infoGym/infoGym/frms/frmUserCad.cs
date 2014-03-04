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
    public partial class frmUserCad : Form
    {
        Usuario user;
        bool teste;
        bool cadastroRealizado = false;

        public frmUserCad()
        {
            InitializeComponent();
            this.ActiveControl = ttbLogin;
            teste = false;

            if (teste)
            {
                btnPerm.Enabled = true;
                user = new Usuario("shema", "123");
                user.Id = 12;
            }
            
        }

        public bool getCadRealizado()
        {
            return cadastroRealizado;
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (ttbLogin.Text == "")
                ttbLogin.BackColor = Color.Red;
            if (ttbSenha.Text == "")
                ttbSenha.BackColor = Color.Red;
            if (ttbConfirmaSenha.Text == "")
                ttbConfirmaSenha.BackColor = Color.Red;
            if (ttbLogin.Text != "" && ttbSenha.Text != "" && ttbConfirmaSenha.Text != "")
            {
                if (ttbSenha.Text != ttbConfirmaSenha.Text)
                {
                    ttbSenha.BackColor = Color.Green;
                    ttbConfirmaSenha.BackColor = Color.Beige;
                }
                else
                {
                    user = new Usuario(ttbLogin.Text, ttbSenha.Text);
                    if (user.criarNovo())
                    {
                        cadastroRealizado = true;
                        user.Id = user.getUltimoId();
                        btnCad.Enabled = false;
                        btnPerm.Enabled = true;
                        ttbLogin.Enabled = false;
                        ttbSenha.Enabled = false;
                        ttbConfirmaSenha.Enabled = false;
                    }
                    else
                        MessageBox.Show("Ocorreu um problema no cadastro!", "Não realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ttbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void ttbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ttbSenha.Focus();
        }

        private void ttbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                ttbConfirmaSenha.Focus();
        }

        private void ttbConfirmaSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnCad_Click(sender, e);
        }

        private void btnPerm_Click(object sender, EventArgs e)
        {
            new frmUserPerm(user).ShowDialog();
            this.Close();
        }

        public String getUserId()
        {
            return ""+user.Id;
        }
    }
}
