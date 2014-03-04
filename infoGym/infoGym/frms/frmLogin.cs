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
    public partial class frmLogin : Form
    {
        public Usuario user;
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = ttbLogin;
            user = new Usuario();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ttbLogin.Text == "")
                ttbLogin.BackColor = Color.Red;
            if (ttbSenha.Text == "")
                ttbSenha.BackColor = Color.Red;
            if (ttbLogin.Text != "" && ttbSenha.Text != "")
            {
                user.Login = ttbLogin.Text;
                user.Senha = ttbSenha.Text;
                user = new Usuario(ttbLogin.Text, ttbSenha.Text);

                if (user.isBloq())
                    MessageBox.Show("Usuário Bloqueado! Contate o administrador do sistema!", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    if (user.logar())
                    {
                        user.Logado = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Login / Senha errado(s)!", "Não foi possível efetuar seu login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ttbLogin_Click(object sender, EventArgs e)
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
                btnEntrar_Click(sender, e);

        }
    }
}
