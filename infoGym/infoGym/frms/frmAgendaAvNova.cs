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
    public partial class frmAgendaAvNova : Form
    {
        Funcionario func;
        Avaliacao ava;
        Utils util;
        Aluno alu;
        bool restricaoHorario;
        public frmAgendaAvNova(String funcId, String avaId, String aluId)
        {
            InitializeComponent();
            restricaoHorario = false;
            ttbAluno.Enabled = ttbAvaliador.Enabled = false;
            lblHorarioComRestricao.Visible = false;
            func = new Funcionario();
            ava = new Avaliacao();
            util = new Utils();
            alu = new Aluno();
            util.setCamposObrigatorios(Controls);
            func.Id = funcId;
            ava.Id = avaId;
            if (aluId != "") //chamada a partir da matricual na musculação
            {
                alu.Id = Convert.ToInt32(aluId);
                alu = alu.getAlunoById();
                ava.AluId = aluId;
                gpbAluno.Enabled = false;
                ttbAluno.Text = alu.Nome;
            }
            if (func.Id != "")
            {
                func.getDadosFunc();
                ttbAvaliador.Text = func.Nome;
                gpbAvaliador.Enabled = false;
            }
            else  //pode escolher avaliador(adm)
            {
                
                
            }
            if (ava.Id != "") //atualizar
            {

            }
            else //nova avaliação
            {

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            verificaHorario();
            if (restricaoHorario)
                MessageBox.Show("Alterar horário!", "Horário não disponível!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if (util.verificarPreenchimentoCamposObrigatorios())
                {
                    ava.AluId = "" + alu.Id;
                    ava.FuncId = func.Id;
                    if (ava.novoAgendamento())
                    {
                        MessageBox.Show("Agendamento realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao realizar o agendamento!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAvaliador_Click(object sender, EventArgs e)
        {
            frmFuncGerenciamento frmFunc = new frmFuncGerenciamento(true);
            frmFunc.ShowDialog();
            if (frmFunc.getPesquisaRealizada())
            {
                func.Id = frmFunc.getFuncID();
                func.getDadosFunc();
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
                ttbAluno.Text = alu.Nome;
            }
            else
            {
                alu = new Aluno();
                ttbAluno.Text = "";
            }
        }

        private void dtpHorario_ValueChanged(object sender, EventArgs e)
        {
            verificaHorario();
        }

        private void verificaHorario()
        {
            ava.DtAgen = new DateTime(dtpDia.Value.Year, dtpDia.Value.Month, dtpDia.Value.Day,
                        dtpHorario.Value.Hour, dtpHorario.Value.Minute, dtpHorario.Value.Second).ToString();
            if (ava.getRestricaoHorario())
            {
                lblHorarioComRestricao.Visible = true;
                restricaoHorario = true;
            }
            else
            {
                lblHorarioComRestricao.Visible = false;
                restricaoHorario = false;
            }
        }
    }
}
