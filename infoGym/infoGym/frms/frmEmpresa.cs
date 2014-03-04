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
    public partial class frmEmpresa : Form
    {
        String acesso;
        Utils util;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        Empresa emp;
        public frmEmpresa(String acesso)
        {
            InitializeComponent();
            util = new Utils();
            this.acesso = acesso;
            emp = new Empresa();
            carregaCbb();
            if (acesso.Equals("Cadastro"))
            {
                btnCadastrar.Image = imageList1.Images[0];
                cbbEstado.SelectedIndex = cbbEstado.Items.Count - 2;
            }
            else
            {
                btnCadastrar.Image = imageList1.Images[1];
                emp = emp.getEmp();
                atualizaInterface();
            }
        }

        private void carregaCbb()
        {
            cbbEstado.DataSource = util.getEstados();
            cbbEstado.ValueMember = "est_cod";
            cbbEstado.DisplayMember = "est_sigla";
        }

        private void cbbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbCidade.DataSource = util.getCidades(cbbEstado.Text);
            cbbCidade.ValueMember = "cid_cod";
            cbbCidade.DisplayMember = "cid_nome";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String email = "";
            String site = "";
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

            if (util.validaEmail(ttbEmail.Text))
                email = ttbEmail.Text;
            if (util.validaSite(ttbSite.Text))
                site = ttbSite.Text;


            if (ttbBairro.Text == "")
                ttbBairro.BackColor = Color.Red;
            if (!ttbCEP.MaskCompleted)
                ttbCEP.BackColor = Color.Red;
            if (!ttbCNPJ.MaskCompleted)
                ttbCNPJ.BackColor = Color.Red;
            if (ttbNome.Text == "")
                ttbNome.BackColor = Color.Red;
            if (ttbNum.Text == "")
                ttbNum.BackColor = Color.Red;
            if (ttbProprietario.Text == "")
                ttbProprietario.BackColor = Color.Red;
            if (ttbRazaoS.Text == "")
                ttbRazaoS.BackColor = Color.Red;
            if (ttbRua.Text == "")
                ttbRua.BackColor = Color.Red;

            if (site == "")
                ttbSite.BackColor = Color.Red;
            if (email == "")
                ttbEmail.BackColor = Color.Red;

            if (ttbBairro.Text != "" && ttbCEP.MaskCompleted && ttbCNPJ.MaskCompleted &&
                ttbNome.Text != "" && ttbNum.Text != "" && ttbProprietario.Text != "" &&
                ttbRazaoS.Text != "" && ttbRua.Text != "" && foneValido)
            {
                String cnpj = util.filtraApenasNumeros(ttbCNPJ.Text);
                String cep = util.filtraApenasNumeros(ttbCEP.Text);
                String fone = util.filtraApenasNumeros(ttbFone.Text);
                emp.Bairro = ttbBairro.Text;
                emp.Cep = cep;
                emp.CidCod = "" + cbbCidade.SelectedValue;
                emp.Cnpj = cnpj;
                emp.Email = ttbEmail.Text;
                emp.Fone = fone;
                emp.Nome = ttbNome.Text;
                emp.Numero = ttbNum.Text;
                emp.Proprietario = ttbProprietario.Text;
                emp.RazaoSocial = ttbRazaoS.Text;
                emp.Rua = ttbRua.Text;
                emp.Site = ttbSite.Text;
                if (acesso == "Cadastro")
                {
                    if (emp.nova())
                    {
                        util.gravarFoto(fotoPath + "" + "logo.jpg", imagem.Image);
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro no cadastro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //atualiza
                {
                    if (emp.atualiza())
                    {
                        util.gravarFoto(fotoPath + "" + "logo.jpg", imagem.Image);
                        MessageBox.Show("Atualização realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro na atualização!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           
        }

        private void ttbNome_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
                ((TextBox)sender).BackColor = Color.White;

            if (sender.GetType().Equals(typeof(MaskedTextBox)))
                ((MaskedTextBox)sender).BackColor = Color.White;
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

        private void atualizaInterface()
        {
            ttbCNPJ.Enabled = false;
            cbbEstado.Text = util.getEstadoDaCidade(emp.CidCod);
            cbbCidade.Text = util.getNomeCidade(emp.CidCod);
            ttbBairro.Text = emp.Bairro;
            ttbCEP.Text = emp.Cep;
            ttbCNPJ.Text = emp.Cnpj;
            ttbEmail.Text = emp.Email;
            ttbFone.Text = emp.Fone;
            ttbNome.Text = emp.Nome;
            ttbNum.Text = emp.Numero;
            ttbProprietario.Text = emp.Proprietario;
            ttbRazaoS.Text = emp.RazaoSocial;
            ttbRua.Text = emp.Rua;
            ttbSite.Text = emp.Site;
            imagem.ImageLocation = fotoPath + "" + "logo.jpg";
        }

        private void ttbFoneDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

    }
}
