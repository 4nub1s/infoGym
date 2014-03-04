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
    public partial class frmModGerenciar : Form
    {
        Modalidade mod;
        bool isPesquisa, pesquisaConcluida;
        public frmModGerenciar(bool isPesquisa)
        {
            InitializeComponent();
            pesquisaConcluida = false;
            this.isPesquisa = isPesquisa;
            if (isPesquisa)
                adptaInterfaceParaPesquisa();
            mod = new Modalidade();
            lblTotMod.Text = mod.getTotal();
            atualizaDtgv();
        }

        public bool getPesquisaConcluida()
        {
            return pesquisaConcluida;
        }

        public String getModSelecionada()
        {
            return mod.Id;
        }

        private void adptaInterfaceParaPesquisa()
        {
            this.Text = "Pesquisar modalidade";
            lblSelModalidade.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void atualizaDtgv()
        {
            dtgvMod.DataSource = mod.getModalidades();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmModNova("").ShowDialog();
            mod.Desc = "";
            atualizaDtgv();
            lblTotMod.Text = mod.getTotal();
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            mod.Desc = ttbNome.Text;
            atualizaDtgv();
        }

        private void dtgvMod_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvMod.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                DataRow linha = ((DataRowView)dtgvMod.CurrentRow.DataBoundItem).Row;
                mod.Desc = linha["mod_desc"].ToString();
                mod.Id = linha["mod_id"].ToString();
            }
        }

        private void dtgvMod_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvMod.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmModNova(mod.Id).ShowDialog();
            mod.Desc = "";
            atualizaDtgv();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a modalidade: " + mod.Desc + "?",
               "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (mod.exclui())
                {
                    MessageBox.Show("Modalidade " + mod.Desc + " foi excluída com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotMod.Text = mod.getTotal();
                    mod.Desc = "";
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(mod.Desc + " possui depêndencias, como por exemplo, alunos vinculados a ela. Para excluí-la você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgvMod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMod.CurrentCell != null && isPesquisa)
            {
                pesquisaConcluida = true;
                this.Close();
            }
        }
    }
}
