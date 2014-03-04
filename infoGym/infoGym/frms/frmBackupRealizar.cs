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
    public partial class frmBackupRealizar : Form
    {
        Utils util;
        public frmBackupRealizar()
        {
            InitializeComponent();
            util = new Utils();
            util.setCamposObrigatorios(Controls);
            rbApenasDados.Checked = true;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ttbDestino.Text = sfd.FileName;
                ttbDestino.Text += ".backup";
            }
            else
                ttbDestino.Text = "";
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            BancoBackup bckp = new BancoBackup();
            if (util.verificarPreenchimentoCamposObrigatorios())
            {
                this.Cursor = Cursors.WaitCursor;
                if (bckp.realizarBackup(ttbDestino.Text, rbAll.Checked))
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Backup Realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Ocorreu um problema ao realizar o backup!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
