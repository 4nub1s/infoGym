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
    public partial class frmUserBloq : Form
    {
        Usuario user;
        public frmUserBloq(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblUser.Text = user.Login;
            user.getStatus();
            if (user.Status)
                rbBloq.Checked = true;
            else
                rbDesbloq.Checked = true;
        }

        private void rbBloq_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBloq.Checked)
                user.Status = false;
            else
                user.Status = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.atualizaStatus())
            {
                MessageBox.Show("Alteração realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ocorreu um erro ao atualizar o status!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
}
