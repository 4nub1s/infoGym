using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.BD;

namespace infoGym.frms
{
    public partial class frmBackupGerenciar : Form
    {
        Usuario user;
        public frmBackupGerenciar(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void lblRealizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBackupRealizar frmBckpRealizar = new frmBackupRealizar();
            frmBckpRealizar.ShowDialog();
        }

        private void lblRestaurar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBackupRestaurar frmBckpRestaurar = new frmBackupRestaurar();
            frmBckpRestaurar.ShowDialog();
        }
    }
}
