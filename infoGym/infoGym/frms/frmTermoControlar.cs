using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym
{
    public partial class frmTermoControlar : Form
    {
        Termo ter;
        Usuario user;
        public frmTermoControlar(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            ter = new Termo();
            atualizaDtgv();
        }

        private void atualizaDtgv()
        {
            dtgvTermos.DataSource = ter.getTermos(ttbAluno.Text);
        }

        private void ttbAluno_TextChanged(object sender, EventArgs e)
        {
            atualizaDtgv();
        }

        private void dtgvTermos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvTermos.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void dtgvTermos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvTermos.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                DataRow linha = ((DataRowView)dtgvTermos.CurrentRow.DataBoundItem).Row;
                ter.TerId = linha["ter_id"].ToString();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                new frmTermoNovo(user, "").ShowDialog();
                atualizaDtgv();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new frmTermoNovo(user, ter.TerId).ShowDialog();
                atualizaDtgv();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o termo selecionado?",
               "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (ter.excluir())
                {
                    MessageBox.Show("Termo excluído com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaDtgv();
                }
                else
                    MessageBox.Show("Problemas na exclusão!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
