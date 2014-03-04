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
    public partial class frmFuncGerenciamento : Form
    {
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosFuncionarios\";
        Funcionario func = null;
        DataTable dtFunc = null;
        String filtro1 = "todos";
        String filtro2 = "internos";
        bool isPesquisa;
        bool pesquisaRealizada;
        public frmFuncGerenciamento(bool isPesquisa)
        {
            InitializeComponent();
            this.isPesquisa = isPesquisa;
            func = new Funcionario();
            chkAtivos.Checked = true;
            if (isPesquisa)
            {
                this.Text = "Pesquisa Funcionário";
                pesquisaRealizada = false;
                chkAtivos.Visible = false;
                gpbCategoria.Visible = false;
                btnAlterar.Visible = false;
                btnExcluir.Visible = false;
                Informações.Visible = false;
            }
            getEstatisticas();
            atualizaDtgv();
        }

        private void getEstatisticas()
        {
            func.Nome = "";
            dtFunc = func.getFunc("todos", "ambos");
            lblTotFunc.Text = "" + dtFunc.Rows.Count;
            dtFunc = func.getFunc("ativos", "ambos");
            lblAtivos.Text = "" + dtFunc.Rows.Count;
            lblInativos.Text = "" + (Convert.ToInt32(lblTotFunc.Text) - Convert.ToInt32(lblAtivos.Text));
            dtFunc = func.getFunc("todos", "internos");
            lblInternos.Text = "" + dtFunc.Rows.Count;
            dtFunc = func.getFunc("todos", "externos");
            lblExternos.Text = "" + dtFunc.Rows.Count;
        }

        private void atualizaDtgv()
        {
            dtFunc = func.getFunc(filtro1, filtro2);
            dtgvFunc.DataSource = dtFunc;
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            func.Nome = ttbNome.Text;
            atualizaDtgv();
        }

        private void chkAtivos_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAtivos.Checked)
                filtro1 = "ativos";
            else
                filtro1 = "todos";
            func.Nome = ttbNome.Text;
            atualizaDtgv();
        }

        private void rbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked)
                filtro2 = "ambos";
            if (rbExterno.Checked)
                filtro2 = "externos";
            if (rbInterno.Checked)
                filtro2 = "internos";
            func.Nome = ttbNome.Text;
            atualizaDtgv();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmFuncNovo("").ShowDialog();
            filtro1 = "todos";
            filtro2 = "internos";
            getEstatisticas();
            atualizaDtgv();
        }

        private void dtgvFunc_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvFunc.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                DataRow linha = ((DataRowView)dtgvFunc.CurrentRow.DataBoundItem).Row;
                func.Id = ""+linha["func_id"];
                func.Nome = linha["func_nome"].ToString();
                imgFuncSele.ImageLocation = fotoPath + "" + func.Id + ".jpg";
                lblNomeAtual.Text = func.Nome;
            }
        }

        private void dtgvFunc_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvFunc.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                lblNomeAtual.Text = "";
                imgFuncSele.ImageLocation = "";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmFuncNovo("" + func.Id).ShowDialog();
            filtro1 = "todos";
            filtro2 = "internos";
            getEstatisticas();
            atualizaDtgv();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o funcionário: " + func.Nome + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (func.excluir())
                {
                    MessageBox.Show(func.Nome+" foi excluída com sucesso!","Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getEstatisticas();
                    func.Nome = ttbNome.Text;
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(func.Nome + " possui depêndencias, como por exemplo, matrículas em aberto. Para excluí-lo você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public String getFuncID()
        {
            return func.Id;
        }

        public bool getPesquisaRealizada()
        {
            return pesquisaRealizada;
        }

        private void dtgvFunc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvFunc.CurrentCell != null && isPesquisa)
            {
                pesquisaRealizada = true;
                this.Close();
            }
        }
    }
}
