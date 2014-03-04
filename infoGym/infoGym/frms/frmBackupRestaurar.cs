using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using infoGym.Classes.BD;

namespace infoGym.frms
{
    public partial class frmBackupRestaurar : Form
    {
        Utils util;
        public frmBackupRestaurar()
        {
            InitializeComponent();
            util = new Utils();
            util.setCamposObrigatorios(Controls);
            rbApenasDados.Checked = true;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            BancoBackup bckp = new BancoBackup();
            if (util.verificarPreenchimentoCamposObrigatorios())
            {
                if (MessageBox.Show("Deseja realmente restaurar os dados? Você perderá tudo que não estiver presente no ponto de restauração!",
                    "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (bckp.restauraBackup(ttbOrigem.Text, rbAll.Checked))
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Restauração realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("O infoGym será reiniciado para que as alterações sejam efetivadas!", "Reiniciar!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Ocorreu um problema ao realizar a restauração do backup!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aceita apenas arquivos de backup|*.backup";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Path.GetExtension(ofd.FileName).Equals(".backup"))
                    MessageBox.Show("Extensão não permitida!", "Extensão Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ttbOrigem.Text = ofd.FileName;
            }
        }
    }
}
