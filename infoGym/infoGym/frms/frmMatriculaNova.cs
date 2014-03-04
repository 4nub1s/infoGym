using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using infoGym.Classes.Negocio;
using infoGym.frms;

namespace infoGym
{
    public partial class frmMatriculaNova : Form
    {
        Usuario user;
        Aluno aluno;
        Modalidade mod;
        Matricula mat;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosAlunos\";
        public frmMatriculaNova(Usuario user, String matId, String aluId)
        {
            InitializeComponent();
            gpbCreditos.Enabled = false;
            mat = new Matricula();
            aluno = new Aluno();
            mod = new Modalidade();
            this.user = user;
            lblUserOn.Text = user.Login;
            lblDtIni.Text = DateTime.Today.ToShortDateString();
            rbMensalista.Checked = true;
            if (matId == "")
            {
                btnConfirmar.Image = imageList1.Images[0];
                chkEncerrar.Visible = false;
            }
            else
            {
                chkEncerrar.Visible = true;
                btnConfirmar.Image = imageList1.Images[1];
                mat.Id = matId;
                mat = mat.getById();
                aluno.Id = Convert.ToInt32(mat.AluId);
                aluno = aluno.getAlunoById();
                imagem.Image = new Bitmap(fotoPath + aluno.Id + ".jpg");
                ttbAluno.Text = aluno.Nome;
                mod.Id = mat.ModId;
                mod = mod.getById();
                ttbModalidade.Text = mod.Desc;
                if (mat.Tipo.Equals("d"))
                {
                    rbDiarista.Checked = true;
                    ttbQtdeDias.Value = Convert.ToDecimal(mat.QtdeDias);
                }
                else
                {
                    rbMensalista.Checked = true;
                    ttbDtVcmto.Value = Convert.ToDecimal(mat.DtVcmto);
                    ttbTolerancia.Value = Convert.ToDecimal(mat.Tolerancia);
                }
                ttbObs.Text = mat.Obs;
                lblDtIni.Text = DateTime.Parse(mat.DtIni).ToShortDateString();
                btnAluBuscar.Enabled = false;
                btnModBuscar.Enabled = false;

                if (mat.DtFim != "")
                {
                    lblEncerrada.Visible = true;
                    lblEncerrada.Text = "Matrícula encerrada!";
                    chkEncerrar.Visible = false;
                    chkEncerrar.Checked = true;
                    btnConfirmar.Enabled = false;
                    ttbDtVcmto.Enabled = false;
                    ttbObs.Enabled = false;
                    ttbQtdeDias.Enabled = false;
                    ttbTolerancia.Enabled = false;
                }

            }
            if (aluId != "")
            {
                aluno.Id = Convert.ToInt32(aluId);
                aluno = aluno.getAlunoById();
                ttbAluno.Text = aluno.Nome;
                btnAluBuscar.Enabled = false;
            }
        }

        private void rbDiarista_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDiarista.Checked)
            {
                gpbCreditos.Visible = true;
                gpbPagamento.Visible = false;
                mat.Tipo = "d";
            }

            if (rbMensalista.Checked)
            {
                gpbCreditos.Visible = false;
                gpbPagamento.Visible = true;
                mat.Tipo = "m";
            }
        }

        private void btnAluBuscar_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAlu = new frmAluGerenciamento(true, user);
            frmAlu.ShowDialog();
            if (frmAlu.getPesquisaRealizada())
            {
                aluno.Id = frmAlu.getAluId();
                aluno = aluno.getAlunoById();
                ttbAluno.Text = aluno.Nome;
                imagem.Image = new Bitmap(fotoPath + aluno.Id + ".jpg");
            }
            else
            {
                aluno.Id = 0;
                ttbAluno.Text = "";
            }
        }

        private void btnModBuscar_Click(object sender, EventArgs e)
        {
            frmModGerenciar frmMod = new frmModGerenciar(true);
            frmMod.ShowDialog();
            if (frmMod.getPesquisaConcluida())
            {
                mod.Id = frmMod.getModSelecionada();
                mod = mod.getById();
                ttbModalidade.Text = mod.Desc;
                if (!mod.ValorD.Contains(","))
                    lblModValorDiario.Text = "R$" + mod.ValorD + ",00";
                else
                    lblModValorDiario.Text = "R$" + mod.ValorD;
                if (!mod.ValorM.Contains(","))
                    lblModValor.Text = "R$" + mod.ValorM + ",00";
                else
                    lblModValor.Text = "R$" + mod.ValorM;
            }
            else
            {
                mod.Id = "";
                ttbModalidade.Text = "";
                lblModValor.Text = "---";
                lblModValorDiario.Text = "---";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ttbAluno.Text == "")
                ttbAluno.BackColor = Color.Red;
            if (ttbModalidade.Text == "")
                ttbModalidade.BackColor = Color.Red;
            if (ttbAluno.Text != "" && ttbModalidade.Text != "")
            {
                mat.Obs = ttbObs.Text;
                mat.AluId = "" + aluno.Id;
                mat.ModId = mod.Id;
                mat.DtIni = DateTime.Today.ToShortDateString();
                mat.QtdeDias = "" + ttbQtdeDias.Value;
                mat.DtVcmto = "" + ttbDtVcmto.Value;
                mat.Tolerancia = "" + ttbTolerancia.Value;
                if (mat.Id == "")
                {
                    String lastId = mat.nova();
                    if (lastId != "")
                    {
                        MessageBox.Show("Matrícula efetuada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (mat.Tipo.Equals("m"))
                        {
                            if (MessageBox.Show("Deseja efetuar pagamento da primeira mensalidade agora?", "Mensalidade",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                try
                                {
                                    new frmMensalidadePgmto(user, lastId).ShowDialog();
                                }
                                catch
                                {
                                }
                            }
                        }
                        if (ttbModalidade.Text.Equals("Musculação"))
                        {
                            if (MessageBox.Show("Deseja agendar avaliação física agora?", "Avaliação",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    if (user.hasPermissionField("escolher funcionário"))
                                        new frmAgendaAvNova("", "", mat.AluId).ShowDialog();
                                    else
                                    {
                                        Funcionario func = new Funcionario();
                                        func = func.getFuncByUser(user.Id);
                                        new frmAgendaAvNova(func.Id, "", mat.AluId).ShowDialog();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Você não tem acesso a essa opção!", "Acesso não permitido!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao realizar a matrícula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (chkEncerrar.Checked)
                    {
                        if (MessageBox.Show("Esta é uma operação irreversível! A matrícula não poderá mais ser reativada!", "Deseja realmente encerrar?",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            mat.DtFim = DateTime.Today.ToShortDateString();
                            if (mat.atualiza())
                            {
                                MessageBox.Show("Matrícula alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                mat.DtFim = "";
                                MessageBox.Show("Ocorreram problemas ao alterar a matrícula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        if (mat.atualiza())
                        {
                            MessageBox.Show("Matrícula alterada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreram problemas ao alterar a matrícula!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                       
                }
            }
        }

        private void ttbAluno_TextChanged(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

    }
}
