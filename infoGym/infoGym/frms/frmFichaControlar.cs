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
    public partial class frmFichaControlar : Form
    {
        Usuario user;
        public frmFichaControlar(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            new frmFichaNova(user).ShowDialog();
        }
    }
}
