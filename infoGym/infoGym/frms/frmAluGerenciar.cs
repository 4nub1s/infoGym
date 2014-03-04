using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace infoGym
{
    public partial class frmAluGerenciamento : Form
    {
        Aluno alu;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosAlunos\";
        DataTable dtAlunos;
        String filtro = "todos";
        bool isPesquisa;
        bool pesquisaConcluida;
        Usuario user;
        public frmAluGerenciamento(bool pesquisa, Usuario user)
        {
            InitializeComponent();
            this.user = user;
            pesquisaConcluida = false;
            lblSelecionar.Visible = false;
            alu = new Aluno();
            getEstatisticas();
            atualizaDtgv();
            isPesquisa = pesquisa;
            if (pesquisa)
                adptaParaPesquisa();
        }

        public int getAluId()
        {
            return alu.Id;
        }

        public bool getPesquisaRealizada()
        {
            return pesquisaConcluida;
        }

        private void adptaParaPesquisa()
        {
            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            Informações.Visible = false;
            this.Text = "Pesquisar Aluno";
            lblSelecionar.Visible = true;
        }

        private void getEstatisticas()
        {
            alu.Nome = "";
            dtAlunos = alu.getAlunos("todos");
            lblTotAlu.Text = ""+dtAlunos.Rows.Count;
            dtAlunos = alu.getAlunos("mulheres");
            lblMulheres.Text = "" + dtAlunos.Rows.Count;
            lblHomens.Text = "" + (Convert.ToInt32(lblTotAlu.Text) - Convert.ToInt32(lblMulheres.Text));
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmAluNovo("", user).ShowDialog();
            getEstatisticas();
            atualizaDtgv();
        }

        private void ttbNome_TextChanged(object sender, EventArgs e)
        {
            alu.Nome = ttbNome.Text;
            atualizaDtgv();
        }

        private void atualizaDtgv()
        {
            dtAlunos = alu.getAlunos(filtro);
            dtgvAlunos.DataSource = dtAlunos;
        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked)
                filtro = "todos";
            if (rbFem.Checked)
                filtro = "mulheres";
            if (rbMasc.Checked)
                filtro = "homens";
            alu.Nome = ttbNome.Text;
            atualizaDtgv();
        }
   
        private void dtgvAlunos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvAlunos.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                DataRow linha = ((DataRowView)dtgvAlunos.CurrentRow.DataBoundItem).Row;

                alu.Nome = linha["alu_nome"].ToString();
                alu.Id = Convert.ToInt32(linha["alu_id"]);
                alu.Cidade = linha["cid_cod"].ToString();
                alu.Rg = linha["alu_rg"].ToString();
                alu.Cpf = linha["alu_cpf"].ToString();
                alu.Bairro = linha["alu_bairro"].ToString();
                alu.Rua = linha["alu_rua"].ToString();
                alu.Numero = linha["alu_numero"].ToString();
                alu.Cep = linha["alu_cep"].ToString();
                alu.Fone = linha["alu_fone"].ToString();
                alu.Cel = linha["alu_cel"].ToString();
                alu.Email = linha["alu_email"].ToString();
                alu.DtNasc = linha["alu_dtnasc"].ToString();
                alu.Sexo = Convert.ToChar(linha["alu_sexo"]);

                if (alu.Sexo == 'm')
                {
                    lblNomeAtual.ForeColor = Color.Blue;
                    gpbAlunoSelecionado.Text = "Aluno Selecionado";
                }
                if (alu.Sexo == 'f')
                {
                    gpbAlunoSelecionado.Text = "Aluna Selecionada";
                    lblNomeAtual.ForeColor = Color.HotPink;
                }
               
                imgAluSele.ImageLocation = fotoPath + "" + alu.Id + ".jpg";
               
                
                lblNomeAtual.Text = alu.Nome;
            }
        }

        private void dtgvAlunos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvAlunos.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                lblNomeAtual.Text = "";
                imgAluSele.ImageLocation = "";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o aluno: " + alu.Nome + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (alu.excluir())
                {
                    String msg = "";
                    if (alu.Sexo == 'm')
                        msg = alu.Nome + " foi excluído com sucesso!";
                    else
                        msg = alu.Nome + " foi excluída com sucesso!";
                    MessageBox.Show(msg, "Exclusão realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getEstatisticas();
                    alu.Nome = ttbNome.Text;
                    atualizaDtgv();
                }
                else
                    MessageBox.Show(alu.Nome + " possui depêndencias, como por exemplo, matrículas em aberto. Para excluí-lo você deve excluir essas referências " +
                        "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmAluNovo(""+alu.Id, user).ShowDialog();
        }

        private void dtgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvAlunos.CurrentCell != null && isPesquisa)
            {
                pesquisaConcluida = true;
                this.Close();
            }
        }

        private void frmAluGerenciamento_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
