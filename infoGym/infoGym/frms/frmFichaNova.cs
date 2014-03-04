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
    public partial class frmFichaNova : Form
    {
        Usuario user;
        public frmFichaNova(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnTreiAdd_Click(object sender, EventArgs e)
        {
            //add letra na grid
        }

        private void btnTreiAtualizar_Click(object sender, EventArgs e)
        {
            new frmFichaItemTreino("").ShowDialog();
        }
    }
}
