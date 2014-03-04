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
    public partial class frmFornNovo : Form
    {
        Utils util;
        bool primeiroLoadCidades = true;
        Fornecedor forn;
        DataTable aux;
        public frmFornNovo(String fornId)
        {
            InitializeComponent();
            util = new Utils();
            forn = new Fornecedor();
            carregaCbb();
            if (fornId != "") //atualiza
            {
                forn.Id = fornId;
                forn = forn.getById();
                adptaInterface();
            }
            else //cadastro
            {
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

        private void adptaInterface()
        {
            btnCadastrar.Image = imageList1.Images[0];
            cbbEstado.Text = util.getEstadoDaCidade(forn.CidCod);
            cbbCidade.Text = util.getNomeCidade(forn.CidCod);
            ttbBairro.Text = forn.Bairro;
            ttbCel.Text = forn.getCel();
            ttbCelDDD.Text = forn.getCelDDD();
            ttbCEP.Text = forn.Cep;
            ttbCNPJ.Text = forn.Cnpj;
            ttbEmail.Text = forn.Email;
            ttbFone.Text = forn.getFone();
            ttbFoneDDD.Text = forn.getFoneDDD();
            ttbInscEst.Text = forn.InscEst;
            ttbNum.Text = forn.Num;
            ttbRazaoS.Text = forn.RazaoS;
            ttbRepresentante.Text = forn.Representante;
            ttbRua.Text = forn.Rua;
            ttbSite.Text = forn.Site;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String fone, cel;
            fone = ttbFoneDDD.Text + ttbFone.Text;
            bool foneValido = false;
            cel = ttbCelDDD.Text + ttbCel.Text;
            bool celValido = false;
            bool emailValido = util.validaEmail(ttbEmail.Text);
            bool siteValido = util.validaSite(ttbSite.Text);

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

            if (ttbRazaoS.Text == "")
                ttbRazaoS.BackColor = Color.Red;
            if (ttbBairro.Text == "")
                ttbBairro.BackColor = Color.Red;
            if (!ttbCEP.MaskCompleted)
                ttbCEP.BackColor = Color.Red;
            if (!ttbCNPJ.MaskCompleted)
                ttbCNPJ.BackColor = Color.Red;
            if (!emailValido)
                ttbEmail.BackColor = Color.Red;
            if (ttbNum.Text == "")
                ttbNum.BackColor = Color.Red;
            if (ttbRepresentante.Text == "")
                ttbRepresentante.BackColor = Color.Red;
            if (ttbRua.Text == "")
                ttbRua.BackColor = Color.Red;
            if (!siteValido)
                ttbSite.BackColor = Color.Red;
            if (ttbInscEst.Text == "")
                ttbInscEst.BackColor = Color.Red;

            if (celValido && emailValido && siteValido && ttbRazaoS.Text != "" && ttbBairro.Text != "" &&
                ttbCEP.MaskCompleted && ttbCNPJ.MaskCompleted && foneValido && celValido &&
                ttbNum.Text != "" && ttbRepresentante.Text != "" && ttbRua.Text != "" && ttbInscEst.Text != "")
            {
                forn.Cel = cel;
                forn.Email = ttbEmail.Text;
                forn.Site = ttbSite.Text;
                forn.RazaoS = ttbRazaoS.Text;
                forn.Bairro = ttbBairro.Text;
                forn.Cep = util.filtraApenasNumeros(ttbCEP.Text);
                forn.Cnpj = util.filtraApenasNumeros(ttbCNPJ.Text);
                forn.Fone = fone;
                forn.Cel = cel;
                forn.Num = ttbNum.Text;
                forn.Representante = ttbRepresentante.Text;
                forn.Rua = ttbRua.Text;
                forn.InscEst = ttbInscEst.Text;
                forn.CidCod = ""+util.getCodCidade(cbbCidade.Text);

                if (forn.Id != "") //atualiza
                {
                    if (forn.altera())
                    {
                        MessageBox.Show("Alteração realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao efetuar a alteração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else //cadastra
                {
                    if (forn.novo())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao efetuar o cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void ttbRazaoS_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(TextBox)))
                ((TextBox)sender).BackColor = Color.White;

            if (sender.GetType().Equals(typeof(MaskedTextBox)))
                ((MaskedTextBox)sender).BackColor = Color.White;
        }

        private void ttbFoneDDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
