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
    public partial class frmAluNovo : Form
    {
        Utils util;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosAlunos\";
        Aluno alu;
        char sexo;
        bool erro = false;
        bool primeiroLoadCidades = true;
        Usuario user;
        public frmAluNovo(String aluCod, Usuario user)
        {
            InitializeComponent();
            util = new Utils();
            this.user = user;
            if (aluCod != "") //atualiza
            {
                alu = new Aluno();
                alu.Id = Convert.ToInt32(aluCod);
                DataTable dtAux = alu.getAluno();
                DataRow linha = dtAux.Rows[0];
                alu.Nome = linha["alu_nome"].ToString();
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

                adptaInterface();
            }
            else //cadastro
            {
                carregaCbb();
                cbbEstado.SelectedIndex = cbbEstado.Items.Count - 2;
                cbbCidade.SelectedValue = util.getCodCidade("Presidente Prudente");
                primeiroLoadCidades = false;
                rbMasc.Checked = true;
            }
        }

        private void carregaCbb()
        {
            cbbEstado.DataSource = util.getEstados();
            cbbEstado.ValueMember = "est_cod";
            cbbEstado.DisplayMember = "est_sigla";
        }

        private void barraFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aceita apenas imagens|*.jpg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image imagemAux = new Bitmap(ofd.FileName);
                Bitmap img = new Bitmap(imagemAux, new Size(150, 150));
                imagem.Image = img;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String fone, cel;
            fone = ttbFoneDDD.Text + ttbFone.Text;
            cel = ttbCelDDD.Text + ttbCel.Text;
            bool celValido = false;
            bool foneValido = false;

            if (ttbFone.Text.Length >= 8 && ttbFoneDDD.Text.Length == 2)
                foneValido = true;
            else
            {
                if (ttbFone.Text.Length < 8)
                    ttbFone.BackColor = Color.Red;
                if (ttbFoneDDD.Text.Length != 2)
                    ttbFoneDDD.BackColor = Color.Red;
                foneValido = false;
            }

            if (ttbCel.Text.Length >= 8 && ttbCelDDD.Text.Length == 2)
                celValido= true;
            else
            {
                if (ttbCel.Text.Length < 8)
                    ttbCel.BackColor = Color.Red;
                if (ttbCelDDD.Text.Length != 2)
                    ttbCelDDD.BackColor = Color.Red;
                celValido = false;
            }


            if (ttbBairro.Text == "")
                ttbBairro.BackColor = Color.Red;
            if (!ttbCEP.MaskCompleted)
                ttbCEP.BackColor = Color.Red;
            if (!ttbCPF.MaskCompleted)
                ttbCPF.BackColor = Color.Red;
            if (ttbNome.Text == "")
                ttbNome.BackColor = Color.Red;
            if (ttbNum.Text == "")
                ttbNum.BackColor = Color.Red;
            if (ttbRG.Text == "")
                ttbRG.BackColor = Color.Red;
            if (ttbRua.Text == "")
                ttbRua.BackColor = Color.Red;
            if (!util.validaEmail(ttbEmail.Text))
                ttbEmail.BackColor = Color.Red;


            if (ttbBairro.Text != "" && celValido && ttbCEP.MaskCompleted && ttbCPF.MaskCompleted &&
                foneValido && ttbNome.Text != "" && ttbNum.Text != "" && ttbRG.Text != "" &&
                ttbRua.Text != "" && util.validaEmail(ttbEmail.Text))
            {
                String codCid = "" + util.getCodCidade(cbbCidade.Text);
                String cpf = util.filtraApenasNumeros(ttbCPF.Text);
                String cep = util.filtraApenasNumeros(ttbCEP.Text);
                if (alu != null && !erro) //atualizar
                {
                    int codigo = alu.Id;

                    alu = new Aluno(ttbNome.Text, ttbRG.Text, cpf, ttbBairro.Text, ttbRua.Text, ttbNum.Text, cep,
                        cel, fone, ttbEmail.Text, codCid, util.dateToString(dtNasc.Value), sexo);
                    alu.Id = codigo;
                    util.gravarFoto(fotoPath + "" + alu.Id + ".jpg", imagem.Image);
                    if (alu.atualizar())
                    {
                        MessageBox.Show("Atualização realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro e a atualização não foi realizada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //cadastrar
                {
                    alu = new Aluno(ttbNome.Text, ttbRG.Text, cpf, ttbBairro.Text, ttbRua.Text, ttbNum.Text, cep,
                        cel, fone, ttbEmail.Text, codCid, util.dateToString(dtNasc.Value), sexo);
                    if (alu.cadastrar())
                    {
                        alu.Id = alu.getUltimoId();
                        util.gravarFoto(fotoPath + "" + alu.Id + ".jpg", imagem.Image);

                        String msg = "";
                        if (alu.Sexo == 'm')
                            msg = "Aluno " + alu.Nome + " foi cadastrado com sucesso!";
                        else
                            msg = "Aluna " + alu.Nome + " foi cadastrada com sucesso!";
                        MessageBox.Show(msg, "Cadastro realizado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja realizar a matrícula do aluno em alguma modalidade?", "Matrícula", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) ==
                            DialogResult.Yes)
                            new frmMatriculaNova(user, "", "" + alu.Id).ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        erro = true;
                        MessageBox.Show("Ocorreu um erro e o cadastro não foi realizado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!primeiroLoadCidades)
            {
                cbbCidade.DataSource = null;
                cbbCidade.Sorted = true;
                primeiroLoadCidades = true;
            }
            cbbCidade.DataSource = util.getCidades(cbbEstado.Text);
            cbbCidade.ValueMember = "cid_cod";
            cbbCidade.DisplayMember = "cid_nome";
        }

        private void ttbBairro_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
                ((TextBox)sender).BackColor = Color.White;

            if (sender.GetType().Equals(typeof(MaskedTextBox)))
                ((MaskedTextBox)sender).BackColor = Color.White;
        }

        private void rbMasc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMasc.Checked)
                sexo = 'm';
            else
                sexo = 'f';
        }

        private void adptaInterface()
        {
            this.Text = "Atualizar dados do aluno(a) " + alu.Nome;
            btnCadastrar.Image = null;
            btnCadastrar.Image = imageList1.Images[0];
            ttbBairro.Text = alu.Bairro;
            ttbCel.Text = alu.getCel();
            ttbCelDDD.Text = alu.getCelDDD();
            ttbCEP.Text = alu.Cep;
            ttbCPF.Text = alu.Cpf;
            ttbEmail.Text = alu.Email;
            ttbFone.Text = alu.getFone();
            ttbFoneDDD.Text = alu.getFoneDDD();
            ttbNome.Text = alu.Nome;
            ttbNum.Text = alu.Numero;
            ttbRG.Text = alu.Rg;
            ttbRua.Text = alu.Rua;
            if (alu.Sexo == 'm')
                rbMasc.Checked = true;
            else
                rbFem.Checked = true;
            imagem.ImageLocation = fotoPath + "" + alu.Id + ".jpg";
            carregaCbb();
            cbbEstado.Text = util.getEstadoDaCidade(alu.Cidade);
            cbbCidade.Text = util.getNomeCidade(alu.Cidade);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmClick frm = new frmClick();
            frm.ShowDialog();
            imagem.Image = frm.getImage();
        }

        private void ttbFoneDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void ttbFone_Leave(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }





    }
}
