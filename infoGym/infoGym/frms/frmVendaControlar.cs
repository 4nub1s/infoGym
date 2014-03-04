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
    public partial class frmVendaControlar : Form
    {
        Usuario user;
        Venda ven;
        String alu_id;//aluno que possui produtos sem pagar(paga na mensalidade)
        public frmVendaControlar(Usuario user, String alu_id)
        {
            InitializeComponent();
            this.alu_id = alu_id;
            this.user = user;
            ven = new Venda();
            lblUserLogado.Text = user.Login;
            atualizaInfo();
            if (alu_id != "")
            {
                btnBuscar.Visible = false;
                btnExcluir.Visible = false;
                btnInfo.Enabled = false;
                gpbFiltros.Visible = false;
                gpbInfo.Visible = false;
                this.Text = "Vendas cobradas nesta mensalidade";
                dtgvVendas.DataSource = ven.getVendasSemEntrada(alu_id);
            }
            else
            {
                dtpInicio.Value = DateTime.Today.AddDays(-1);
                btnExcluir.Enabled = false;
                btnInfo.Enabled = false;
                btnBuscar_Click(this, null);
            }
        }

        private void atualizaInfo()
        {
            Produto prodAux = new Produto();
            try
            {
                prodAux.Id = ven.getProdMaisVendido();
                prodAux = prodAux.getById();
                lblVendasRealizadas.Text = ven.getQtdeVendas();
                lblProdMaisVendido.Text = prodAux.Desc;
            }
            catch
            {
                lblVendasRealizadas.Text = ven.getQtdeVendas();
            }
        }

        private void dtgvVendas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnExcluir.Enabled = true;
            btnInfo.Enabled = true;
        }

        private void dtgvVendas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvVendas.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnInfo.Enabled = false;
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value > dtpFim.Value)
            {
                dtpFim.Value = DateTime.Today;
                dtpInicio.Value = DateTime.Today.AddDays(-1);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dtgvVendas.DataSource = ven.getVendaByDia(dtpInicio.Value, dtpFim.Value);
        }

        private void dtgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvVendas.CurrentCell != null)
            {
                DataRow linha = ((DataRowView)dtgvVendas.CurrentRow.DataBoundItem).Row;
                ven.Cod = linha["ven_cod"].ToString();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new frmVendaNova(user, ven.Cod).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir a venda de código: "+ven.Cod+"?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (ven.excluir())
                {
                    MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgvVendas.DataSource = ven.getVendaByDia(dtpInicio.Value, dtpFim.Value);
                    atualizaInfo();
                }
                else
                    MessageBox.Show("Ocorreu um erro ao excluir a venda!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }



      
    }
}
