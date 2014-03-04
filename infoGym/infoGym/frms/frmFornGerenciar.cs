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
    public partial class frmFornGerenciar : Form
    {
        Fornecedor forn;
        bool isBusca;
        bool buscaConcluida;
        public frmFornGerenciar(bool isBusca)
        {
            this.isBusca = isBusca;
            InitializeComponent();
            if (isBusca)
                adaptaInterface();
            forn = new Fornecedor();
            lblTotForn.Text = forn.getTotal();
            forn.RazaoS = "";
            atualizaDtgv();
        }

        private void adaptaInterface()
        {
            this.Text = "Buscar Fornecedor";
            lblSelecionar.Visible = true;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmFornNovo("").ShowDialog();
            lblTotForn.Text = forn.getTotal();
            forn.RazaoS = "";
            atualizaDtgv();
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            forn.RazaoS = ttbNome.Text;
            atualizaDtgv();
        }

        private void atualizaDtgv()
        {
            dtgvForn.DataSource = forn.getFornecedores();
        }

        private void dtgvForn_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvForn.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                DataRow linha = ((DataRowView)dtgvForn.CurrentRow.DataBoundItem).Row;
                forn.RazaoS = linha["forn_razaosocial"].ToString();
                forn.Id = linha["forn_id"].ToString();
            }
        }

        private void dtgvForn_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvForn.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o fornecedor: " + forn.RazaoS + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (forn.excluir())
                {
                    MessageBox.Show("Fornecedor "+ forn.RazaoS + " foi excluído com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotForn.Text = forn.getTotal();
                    forn.RazaoS = ttbNome.Text;
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(forn.RazaoS + " possui depêndencias, como por exemplo, produtos vinculados a ele. Para excluí-lo você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFornNovo(forn.Id).ShowDialog();
            lblTotForn.Text = forn.getTotal();
            forn.RazaoS = "";
            atualizaDtgv();
        }

        private void dtgvForn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isBusca && dtgvForn.CurrentCell != null)
            {
                buscaConcluida = true;
                this.Close();
            }
        }

        public String getForn()
        { 
            return forn.Id;
        }

        public bool isBuscaConcluida()
        {
            return buscaConcluida;
        }

    }
}
