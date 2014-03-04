using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;

namespace infoGym.frms
{
    public partial class frmExeGerenciar : Form
    {
        Exercicio exe;
        public frmExeGerenciar()
        {
            InitializeComponent();
            exe = new Exercicio();
            lblTotExe.Text = exe.getTotal();
            exe.Desc = "";
            atualizaDtgv();
        }

        private void atualizaDtgv()
        {
            dtgvExe.DataSource = exe.getExercicios();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmExeNovo("").ShowDialog();
            exe.Desc = "";
            atualizaDtgv();
            lblTotExe.Text = exe.getTotal();
        }

        private void dtgvExe_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvExe.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                DataRow linha = ((DataRowView)dtgvExe.CurrentRow.DataBoundItem).Row;
                exe.Desc = linha["exe_desc"].ToString();
                exe.Id = linha["exe_id"].ToString();
            }
        }

        private void dtgvExe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvExe.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            exe.Desc = ttbNome.Text;
            atualizaDtgv();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmExeNovo(exe.Id).ShowDialog();
            exe.Desc = "";
            atualizaDtgv();
            lblTotExe.Text = exe.getTotal();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o exercício: " + exe.Desc + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (exe.exclui())
                {
                    MessageBox.Show("Exercício " + exe.Desc + " foi excluído com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotExe.Text = exe.getTotal();
                    exe.Desc = "";
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(exe.Desc + " possui depêndencias, como por exemplo, treinos vinculados a ele. Para excluí-lo você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
