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
    public partial class frmFuncNovo : Form
    {
        String userCod = "";
        Utils util;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\fotosFuncionarios\";
        Funcionario func = null;
        bool primeiroLoadCidades = true;
        bool erro = false;
        String categoria = "";
        String funcCod = "";
        public frmFuncNovo(String funcCod)
        {
            InitializeComponent();
            util = new Utils();
            if (funcCod != "") //atualização
            {
                func = new Funcionario();
                func.Id = funcCod;
                func.getDadosFunc();
                this.funcCod = funcCod;
                adptaInterface();
            }
            else //cadastro
            {
                rbInterno.Checked = true;
                carregaCbb();
                cbbEstado.SelectedIndex = cbbEstado.Items.Count - 2;
                cbbCidade.SelectedValue = util.getCodCidade("Presidente Prudente");
                primeiroLoadCidades = false;
            }
        }

        private void carregaCbb()
        {
            cbbEstado.DataSource = util.getEstados();
            cbbEstado.ValueMember = "est_cod";
            cbbEstado.DisplayMember = "est_sigla";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserCad frmUser = new frmUserCad();
            frmUser.ShowDialog();
            if (frmUser.getCadRealizado())
            {
                btnCadUser.Enabled = false;
                userCod = frmUser.getUserId();
            }
        }

        private void adptaInterface()
        {
            this.Text = "Atualizar dados do funcionário(a) " + func.Nome;
            checkDem.Enabled = true;
            btnCadastrar.Image = null;
            btnCadastrar.Image = imageList1.Images[0];
            ttbBairro.Text = func.Bairro;
            ttbCel.Text = func.getCel();
            ttbCelDDD.Text = func.getCelDDD();
            ttbCEP.Text = func.Cep;
            ttbCPF.Text = func.Cpf;
            ttbEmail.Text = func.Email;
            ttbFone.Text = func.getFone();
            ttbFoneDDD.Text = func.getFoneDDD();
            ttbNome.Text = func.Nome;
            ttbNum.Text = func.Numero;
            ttbRG.Text = func.Rg;
            ttbRua.Text = func.Rua;
            dtContrat.Value = Convert.ToDateTime(func.DtAdm);
            if (func.DtDem != "")
            {
                dtDemissao.Enabled = true;
                checkDem.Checked = true;
                dtDemissao.Value = Convert.ToDateTime(func.DtDem);
            }
            if (func.Categoria.Equals("Interno"))
                rbInterno.Checked = true;
            else
                rbExterno.Checked = true;
            imagem.ImageLocation = fotoPath + "" + func.Id + ".jpg";
            carregaCbb();
            cbbEstado.Text = util.getEstadoDaCidade(""+func.CidCod);
            cbbCidade.Text = util.getNomeCidade(""+func.CidCod);
            if (!func.possuiUsuario())
                btnCadUser.Enabled = true;
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

        private void ttbNome_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
                ((TextBox)sender).BackColor = Color.White;

            if (sender.GetType().Equals(typeof(MaskedTextBox)))
                ((MaskedTextBox)sender).BackColor = Color.White;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String fone, cel;
            fone = ttbFoneDDD.Text + ttbFone.Text;
            cel = ttbCelDDD.Text + ttbCel.Text;
            bool foneValido = false;
            bool celValido = false;

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
                celValido = true;
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
                func = new Funcionario();
                func.CidCod = codCid;
                func.Nome = ttbNome.Text;
                func.Numero = ttbNum.Text;
                func.Rg = ttbRG.Text;
                func.Rua = ttbRua.Text;
                func.Bairro = ttbBairro.Text;
                func.Cel = cel;
                func.Cep = cep;
                func.Cpf = cpf;
                func.DtAdm = util.dateToString(dtContrat.Value);
                func.DtDem = "";
                func.DtNasc = util.dateToString(dtNasc.Value);
                func.Email = ttbEmail.Text;
                func.Fone = fone;
                func.Categoria = categoria;
                if (funcCod != "" && !erro) //atualizar
                {
                    func.Id = funcCod;
                    if (checkDem.Checked)
                        func.DtDem = util.dateToString(dtDemissao.Value);
                    else
                        func.DtDem = "";
                    if (userCod != "")
                        func.Usuario = userCod;
                    else
                        func.Usuario = "";
                    if(func.atualizar())
                    {
                        util.gravarFoto(fotoPath + "" + func.Id + ".jpg", imagem.Image);
                        MessageBox.Show("Atualização realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro na atualização!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //cadastrar
                {
                    if (func.cadastrar())
                    {
                        func.Id = ""+func.getUltimoId();
                        util.gravarFoto(fotoPath + "" + func.Id + ".jpg", imagem.Image);
                        MessageBox.Show("Funcionário(a) " + func.Nome + " foi cadastrado(a) com sucesso!", "Cadastro realizado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Deseja criar um usuário para que o funcionário acesse o sistema? Também pode ser criado posteriormente!",
                            "Usuário Acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            frmUserCad frmUser = new frmUserCad();
                            frmUser.ShowDialog();
                            if (frmUser.getCadRealizado())
                            {
                                btnCadUser.Enabled = false;
                                func.Usuario = frmUser.getUserId();
                                func.atualizar();
                            }
                        }
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

        private void rbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExterno.Checked)
                categoria = "Externo";
            if (rbInterno.Checked)
                categoria = "Interno";
        }

        private void checkDem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDem.Checked)
                dtDemissao.Enabled = true;
            else
                dtDemissao.Enabled = false;
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




    }
}
