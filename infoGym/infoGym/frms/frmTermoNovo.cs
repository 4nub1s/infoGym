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
    public partial class frmTermoNovo : Form
    {
        Usuario user, userTermo;
        Aluno alu;
        Termo ter;
        Utils util;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\termos\";
        public frmTermoNovo(Usuario user, String terId)
        {
            InitializeComponent();
            ter = new Termo();
            util = new Utils();
            this.user = user;
            lblUserOn.Text = user.Login;
            alu = new Aluno();
            if (terId != "") //atualizar
            {
                lblUltimaAlter.Visible = true;
                lblUltimaAlter1.Visible = true;
                ter.TerId = terId;
                ter = ter.getTermoById();
                userTermo = new Usuario();
                userTermo.Id = Convert.ToInt32(ter.TerQuemCadastrou);
                userTermo = userTermo.getUserById();
                lblUltimaAlter.Text = userTermo.Login;
                btnSelecionar.Visible = false;
                alu.TerId = terId;
                ttbAluno.Text = alu.getAlunoByTermo();
                pictureBox1.ImageLocation = fotoPath + "" + ter.TerId + ".jpg";
            }
            else
            {
                lblUltimaAlter.Visible = false;
                lblUltimaAlter1.Visible = false;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aceita apenas imagens|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ttbAluno.Text == "")
                ttbAluno.BackColor = Color.Red;
            else
                if (pictureBox1.Image == null)
                    MessageBox.Show("Selecione uma imagem!", "Sem imagem!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (ter.TerId != "") //atualiza
                    {
                        ter = ter.getTermoById();
                        ter.TerQuemCadastrou =""+user.Id;
                        if (ter.atualiza())
                        {
                            util.gravarFoto(fotoPath + "" + ter.TerId + ".jpg", pictureBox1.Image);
                            MessageBox.Show("Termo alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreu um erro ao atualizar o termo!", "Erro!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        ter.AluId = alu.Id + "";
                        ter.TerQuemCadastrou = user.Id + "";
                        if (ter.novo())
                        {
                            ter.TerId = ter.getUltimoId();
                            util.gravarFoto(fotoPath + "" + ter.TerId + ".jpg", pictureBox1.Image);
                            MessageBox.Show("Termo cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Ocorreu um erro ao cadastrar o termo!", "Erro!", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                    }
                }
        }

        private void ttbAluno_TextChanged(object sender, EventArgs e)
        {
            ttbAluno.BackColor = Color.White;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmAluGerenciamento frmAluGer = new frmAluGerenciamento(true, user);
            frmAluGer.ShowDialog();
            if (frmAluGer.getPesquisaRealizada())
            {
                alu.Id = frmAluGer.getAluId();
                alu = alu.getAlunoById();
                if (alu.TerId == "")
                    ttbAluno.Text = alu.Nome;
                else
                {
                    MessageBox.Show("Aluno já possui termo cadastrado em seu nome!", "Não permitido!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    ttbAluno.Text = "";
                }
            }
            else
                ttbAluno.Text = "";
        }
    }
}
