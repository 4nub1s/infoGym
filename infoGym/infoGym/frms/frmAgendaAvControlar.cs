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
    public partial class frmAvControlar : Form
    {
        Usuario user;
        Avaliacao ava;
        Funcionario func;
        String status;
        Aluno alu;
        bool msmDia;
        bool isADM;
        public frmAvControlar(Usuario user)
        {
            InitializeComponent();
            msmDia = true;
            ava = new Avaliacao();
            status = "Todas";
            ttbAluno.Enabled = false;
            ttbAvaliador.Enabled = false;
            chAllAluno.Checked = true;
            rbTodas.Checked = true;
            dtpFim.Value = DateTime.Today;
            dtpInicio.Value = DateTime.Today;
            func = new Funcionario();
            alu = new Aluno();
            this.user = user;
            chkPeriodo.Checked = true;
            atualizaInfo();
            if (!user.hasPermissionField("escolher funcionário"))
            {
                isADM = false;
                func = func.getFuncByUser(user.Id);
                this.Text = "Agenda " + func.Nome;
                ttbAvaliador.Text = func.Nome;
                ava.FuncId = func.Id;
                gpbAvaliador.Enabled = false;
                gpbInfo.Visible = false;
            }
            else
                isADM = true;
            buscar();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buscar()
        {
            dtgvAva.DataSource = ava.getAgendaAvaliacoes(status, dtpInicio.Value.ToString(), dtpFim.Value.ToString(), !chkPeriodo.Checked, msmDia);
        }

        private void chkAllAvaliadores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllAvaliadores.Checked)
            {
                ttbAvaliador.Text = "";
                btnAvaliador.Enabled = false;
                ava.FuncId = "";
            }
            else
                btnAvaliador.Enabled = true;
            buscar();
        }

        private void chAllAluno_CheckedChanged(object sender, EventArgs e)
        {
            if (chAllAluno.Checked)
            {
                ttbAluno.Text = "";
                btnAluno.Enabled = false;
                ava.AluId = "";
            }
            else
                btnAluno.Enabled = true;
            buscar();
        }

        private void chkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeriodo.Checked)
            {
                dtpFim.Enabled = false;
                dtpInicio.Enabled = false;
            }
            else
            {
                dtpFim.Enabled = true;
                dtpInicio.Enabled = true;
            }
            buscar();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicio.Value == dtpFim.Value)
            {
                dtpFim.Enabled = false;
                msmDia = true;
            }
            else
            {
                msmDia = false;
                dtpFim.Enabled = true;
                if (dtpFim.Value < dtpInicio.Value)
                {
                    dtpInicio.Value = DateTime.Today.AddDays(-1);
                    dtpFim.Value = DateTime.Today;
                }
            }
            buscar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                if (isADM)
                    new frmAgendaAvNova("", "", "").ShowDialog();
                else
                    new frmAgendaAvNova(ava.FuncId, "", "").ShowDialog();
                atualizaInfo();
                buscar();
            }
            catch
            {
                MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void atualizaInfo()
        {
            lblTotal.Text = ava.getTotal();
            lblNaoRealizadas.Text = ava.getNaoRealizadas();
            lblEmAtraso.Text = ava.getEmAtraso();
        }

        private void ttbAvaliador_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void rbRealizadas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAtraso.Checked)
                status = rbAtraso.Text;
            else
                if (rbNRealizadas.Checked)
                    status = rbNRealizadas.Text;
                else
                    if (rbRealizadas.Checked)
                        status = rbRealizadas.Text;
                    else
                        if (rbTodas.Checked)
                            status = rbTodas.Text;
            buscar();
        }

        private void btnAvaliador_Click(object sender, EventArgs e)
        {
            frmFuncGerenciamento frmFunc = new frmFuncGerenciamento(true);
            frmFunc.ShowDialog();
            if (frmFunc.getPesquisaRealizada())
            {
                func.Id = frmFunc.getFuncID();
                func.getDadosFunc();
                ava.FuncId = func.Id;
                ttbAvaliador.Text = func.Nome;
            }
            else
            {
                func.Id = "";
                ttbAvaliador.Text = "";
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAlu = new frmAluGerenciamento(true, null);
            frmAlu.ShowDialog();
            if (frmAlu.getPesquisaRealizada())
            {
                alu.Id = frmAlu.getAluId();
                alu = alu.getAlunoById();
                ava.AluId = "" + alu.Id;
                ttbAluno.Text = alu.Nome;
            }
            else
            {
                alu = new Aluno();
                ttbAluno.Text = "";
            }
        }

        private void dtgvAva_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtgvAva.Rows.Count > 0)
            {
                btnExcluir.Enabled = true;
                btnAvaliacao.Enabled = true;
            }
        }

        private void dtgvAva_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtgvAva.Rows.Count == 0)
            {
                btnExcluir.Enabled = false;
                btnAvaliacao.Enabled = false;
            }
        }

        private void dtgvAva_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvAva.CurrentCell != null)
            {
                DataRow linha = ((DataRowView)dtgvAva.CurrentRow.DataBoundItem).Row;
                ava.Id = linha["ava_id"].ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ava.jaRealizada())
                MessageBox.Show("Essa avaliação já foi realizada e não pode ser excluída!", "Já realizada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (MessageBox.Show("Deseja realmente excluir o agendamento selecionado?", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes)
                {
                    if (ava.excluirAgendamento())
                    {
                        MessageBox.Show("Exclusão realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        atualizaInfo();
                        buscar();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro e a exclusão não foi realizada!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAvaliacao_Click(object sender, EventArgs e)
        {
            if (!ava.jaRealizada())
            {
                if (MessageBox.Show("Deseja realizar a avaliação agora?", "Avaliar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAvaliacao frmAva = new frmAvaliacao(ava.Id);
                    frmAva.ShowDialog();
                    atualizaInfo();
                    buscar();
                }
            }
            else
            {
                frmAvaliacao frmAva = new frmAvaliacao(ava.Id);
                frmAva.ShowDialog();
                atualizaInfo();
                buscar();
            }
            
        }


    }
}
