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
    public partial class frmMatriculaControlar : Form
    {
        Usuario user;
        Matricula mat;
        Modalidade mod;
        Aluno alu;
        String status, formapgmto;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosAlunos\";
        public frmMatriculaControlar(Usuario user)
        {
            InitializeComponent();
            status = "Ambas";
            formapgmto = "Ambas";
            this.user = user;
            mat = new Matricula();
            mod = new Modalidade();
            alu = new Aluno();
            rbAtivasInativas.Checked = true;
            rbDiaristaMensalista.Checked = true;
            btnBuscar_Click(this, null);
            atualizaInfos();
        }

        private void atualizaInfos()
        {
            try
            {
                lblTotal.Text = mat.getInfos("todas");
                lblAtivas.Text = mat.getInfos("ativas");
                lblInativas.Text = mat.getInfos("inativas");
                lblDiarista.Text = mat.getInfos("diaristas");
                lblMensalista.Text = mat.getInfos("mensalistas");
            }
            catch
            {
            }
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            frmModGerenciar frmMod = new frmModGerenciar(true);
            frmMod.ShowDialog();
            if (frmMod.getPesquisaConcluida())
            {
                alu.Id = 0;
                ttbAluno.Text = "Todos";
                mod.Id = frmMod.getModSelecionada();
                mod = mod.getById();
                ttbModalidade.Text = mod.Desc;
            }
            else
            {
                mod.Id = "";
                ttbModalidade.Text = "Todas";
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAlu = new frmAluGerenciamento(true, user);
            frmAlu.ShowDialog();
            if (frmAlu.getPesquisaRealizada())
            {
                mod.Id = "";
                ttbModalidade.Text = "Todas";
                rbAtivasInativas.Checked = true;
                rbDiaristaMensalista.Checked = true;
                alu.Id = frmAlu.getAluId();
                alu = alu.getAlunoById();
                ttbAluno.Text = alu.Nome;
            }
            else
            {
                alu.Id = 0;
                ttbAluno.Text = "Todos";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (alu.Id != 0)
            {
                rbDiaristaMensalista.Checked = true;
                rbAtivasInativas.Checked = true;
            }
            dtgvMatriculas.DataSource = mat.consulta(status, formapgmto, mod.Id, "" + alu.Id);
        }

        private void rbAtivas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAtivas.Checked)
                status = rbAtivas.Text;
            if (rbInativas.Checked)
                status = rbInativas.Text;
            if (rbAtivasInativas.Checked)
                status = "Ambas";
            if (rbDiarista.Checked)
                formapgmto = rbDiarista.Text;
            if (rbMensalista.Checked)
                formapgmto = rbMensalista.Text;
            if (rbDiaristaMensalista.Checked)
                formapgmto = rbDiaristaMensalista.Text;
        }

        private void dtgvMatriculas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvMatriculas.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnControlarMensalidades.Visible = false;
                btnAddDays.Visible = false;

            }
        }

        private void dtgvMatriculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvMatriculas.CurrentCell != null)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;

                DataRow linha = ((DataRowView)dtgvMatriculas.CurrentRow.DataBoundItem).Row;
                mat.Id = linha["mat_cod"].ToString();
                mat.Tipo = linha["formapgmto"].ToString();
                if (mat.Tipo.Equals("Mensalista"))
                {
                    btnControlarMensalidades.Visible = true;
                    btnAddDays.Visible = false;
                }
                else
                {
                    btnControlarMensalidades.Visible = false;
                    btnAddDays.Visible = true;
                }
            }
            else
            {
                mat.Tipo = "";
                alu.Id = 0;
                mat.AluId = "";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmMatriculaNova(user, "", "").ShowDialog();
            atualizaInfos();
            btnBuscar_Click(this, null);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            new frmMatriculaNova(user, mat.Id, "").ShowDialog();
            atualizaInfos();
            btnBuscar_Click(this, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir a matrícula de código: " + mat.Id + "?",
                "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (mat.excluir())
                {
                    MessageBox.Show("Matrícula excluída com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaInfos();
                    btnBuscar_Click(sender, e);
                }
                else
                    MessageBox.Show("Esta matrícula possui depêndencias! Como por exemplo, mensalidades vinculadas. Para excluí-la você deve excluir essas referências " +
                       "e depois voltar aqui!", "Não foi possível realizar a exclusão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnControlarMensalidades_Click(object sender, EventArgs e)
        {
            try
            {
                new frmMensalidadeControlarcs(user, mat.Id).ShowDialog();
            }
            catch
            {
            }
        }

        private void btnAddDays_Click(object sender, EventArgs e)
        {
            try
            {
                new frmMensalidadeControlarcs(user, mat.Id).ShowDialog();
            }
            catch
            {
            }
        }
    }
}
