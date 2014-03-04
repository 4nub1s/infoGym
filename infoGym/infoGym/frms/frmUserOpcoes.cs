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
    public partial class frmUserOpcoes : Form
    {
        Usuario user;
        public frmUserOpcoes(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblUser.Text = user.Login;
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            new frmUserConexoes(user).ShowDialog();
        }

        private void btnBloq_Click(object sender, EventArgs e)
        {
            new frmUserBloq(user).ShowDialog();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            new frmUserPerm(user).ShowDialog();
        }
    }
}
