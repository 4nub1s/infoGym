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
    public partial class frmDespesaControlar : Form
    {
        Usuario user;
        Despesa desp;
        DataTable dtDesp;
        Utils util;
        public frmDespesaControlar(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            desp = new Despesa();
            util = new Utils();
            cbbSituação.Text = "Todas";
            chkPeriodo.Checked = true;
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 30);
            dtDesp = desp.consulta(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, false);
            dtgvDesp.DataSource = dtDesp;
            getInfos();
        }

        private void getInfos()
        {
            lblTotalPago.Text = desp.getTotalPago(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString());
            if (lblTotalPago.Text != "")
                lblTotalPago.Text = util.moneyFormata(lblTotalPago.Text);
            else
                lblTotalPago.Text = "---";


            lblTotalPagar.Text = desp.getTotalPagar(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString());
            if (lblTotalPagar.Text != "")
                lblTotalPagar.Text = util.moneyFormata(lblTotalPagar.Text);
            else
                lblTotalPagar.Text = "---";


            lblTotalGeral.Text = desp.getTotalGeral(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString());
            if (lblTotalGeral.Text != "")
                lblTotalGeral.Text = util.moneyFormata(lblTotalGeral.Text);
            else
                lblTotalGeral.Text = "---";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDespesaNova(user, "").ShowDialog();
                desp.Desc = "";
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cbbSituação.Text = "Todas";
            chkPeriodo.Checked = true;
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 30);
            dtDesp = desp.consulta(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, false);
            dtgvDesp.DataSource = dtDesp;

            getInfos();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value >= dtpFim.Value)
                dtpInicio.Value = dtpFim.Value.AddDays(-1);
            getInfos();
        }

        private void ttbDesc_TextChanged(object sender, EventArgs e)
        {
            if (ttbDesc.Text != "")
            {
                btnBuscar.Enabled = false;
                cbbSituação.Enabled = false;
                gpbPeriodo.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
                cbbSituação.Enabled = true;
                gpbPeriodo.Enabled = true;
            }
            dtDesp = desp.consulta("", "", "", ttbDesc.Text, false);
            dtgvDesp.DataSource = dtDesp;
        }

        private void dtgvDesp_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void dtgvDesp_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvDesp.Rows.Count == 0)
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void dtgvDesp_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index > -1)
            {
                if (dtDesp.Rows[e.Row.Index]["desp_dtpg"].ToString() != "")
                    dtgvDesp.Rows[e.Row.Index].Cells["ispago"].Value = imageList1.Images[0];
                else
                    dtgvDesp.Rows[e.Row.Index].Cells["ispago"].Value = new Bitmap(32, 32);


                if (!dtgvDesp.Rows[e.Row.Index].Cells["desp_valor"].Value.ToString().Contains("R$"))
                    dtgvDesp.Rows[e.Row.Index].Cells["desp_valor"].Value = util.moneyFormata(dtgvDesp.Rows[e.Row.Index].Cells["desp_valor"].Value.ToString());

                if (!dtgvDesp.Rows[e.Row.Index].Cells["desp_valorpg"].Value.ToString().Contains("R$"))
                    dtgvDesp.Rows[e.Row.Index].Cells["desp_valorpg"].Value = util.moneyFormata(dtgvDesp.Rows[e.Row.Index].Cells["desp_valorpg"].Value.ToString());

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ttbDesc.Text = "";
            if (chkPeriodo.Checked)
                dtDesp = desp.consulta(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, false);
            else
                dtDesp = desp.consulta("", dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, true);
            dtgvDesp.DataSource = dtDesp;
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeriodo.Checked)
            {
                gpbPeriodo.Enabled = true;
            }
            else
            {
                gpbPeriodo.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDespesaNova(user, desp.Id).ShowDialog();
                desp.Desc = "";
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cbbSituação.Text = "Todas";
            chkPeriodo.Checked = true;
            dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpFim.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 30);
            dtDesp = desp.consulta(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, false);
            dtgvDesp.DataSource = dtDesp;

            getInfos();
        }

        private void dtgvDesp_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvDesp.CurrentCell != null)
            {
                DataRow linha = ((DataRowView)dtgvDesp.CurrentRow.DataBoundItem).Row;
                desp.Id = linha["desp_id"].ToString();
                desp.Desc = linha["desp_desc"].ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir a despesa: " + desp.Desc + "?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                if (desp.excluir())
                {
                    MessageBox.Show("Despesa excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbSituação.Text = "Todas";
                    chkPeriodo.Checked = true;
                    dtpInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    dtpFim.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 30);
                    dtDesp = desp.consulta(dtpInicio.Value.ToShortDateString(), dtpFim.Value.ToShortDateString(), cbbSituação.Text, ttbDesc.Text, false);
                    dtgvDesp.DataSource = dtDesp;

                    getInfos();
                }
                else
                    MessageBox.Show("Ocorreram erros ao realizar a exclusão!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
