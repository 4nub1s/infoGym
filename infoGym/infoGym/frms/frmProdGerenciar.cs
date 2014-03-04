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
    public partial class frmProdGerenciar : Form
    {
        Produto prod;
        bool pesquisaConcluida;
        bool isBusca;
        public frmProdGerenciar(bool isBusca)
        {
            InitializeComponent();
            this.isBusca = isBusca;
            prod = new Produto();
            lblTotProd.Text = prod.getTotal();
            prod.Desc = "";
            atualizaDtgv();
            if(isBusca)
                adptaInterface();
        }

        public String getProduto()
        {
            return prod.Id;
        }

        public bool getIsPesquisa()
        {
            return pesquisaConcluida;
        }

        private void adptaInterface()
        {
            pesquisaConcluida = false;
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            btnNovo.Visible = false;
            this.Text = "Buscar Produto";
            lblDuploClique.Visible = true;
        }

        private void atualizaDtgv()
        {
            dtgvProd.DataSource = prod.getProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmProdNovo("").ShowDialog();
            lblTotProd.Text = prod.getTotal();
            prod.Desc = "";
            atualizaDtgv();
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            prod.Desc = ttbNome.Text;
            atualizaDtgv();
        }

        private void dtgvProd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvProd.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void dtgvProd_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvProd.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                DataRow linha = ((DataRowView)dtgvProd.CurrentRow.DataBoundItem).Row;
                prod.Desc = linha["prod_desc"].ToString();
                prod.Id = linha["prod_id"].ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o produto: " + prod.Desc + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (prod.excluir())
                {
                    MessageBox.Show("Produto " + prod.Desc + " foi excluído com sucesso!", "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTotProd.Text = prod.getTotal();
                    prod.Desc = "";
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(prod.Desc + " possui depêndencias, como por exemplo, vendas vinculadas a ele. Para excluí-lo você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmProdNovo(prod.Id).ShowDialog();
            lblTotProd.Text = prod.getTotal();
            prod.Desc = "";
            atualizaDtgv();
        }

        private void dtgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvProd.CurrentCell != null && isBusca)
            {
                pesquisaConcluida = true;
                this.Close();
            }
        }
    }
}
