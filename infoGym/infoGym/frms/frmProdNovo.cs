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
    public partial class frmProdNovo : Form
    {
        Fornecedor forn;
        Produto prod;
        public frmProdNovo(String prodCod)
        {
            InitializeComponent();
            prod = new Produto();
            if (prodCod != "") //atualiza
            {
                prod.Id = prodCod;
                prod = prod.getById();
                adaptaInterface();
            }
        }

        private void adaptaInterface()
        {
            ttbNome.Text = prod.Desc;
            ttbEstAtual.Value = Convert.ToInt32(prod.EstoqueA);
            ttbEstMin.Value = Convert.ToInt32(prod.EstoqueMin);
            ttbValor.Text = prod.Valor;
            forn = new Fornecedor();
            forn.Id = prod.FornId;
            forn = forn.getById();
            ttbForn.Text = forn.RazaoS;
            btnCadastrar.Image = imageList1.Images[0];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnForn_Click(object sender, EventArgs e)
        {
            ttbForn.BackColor = Color.White;
            frmFornGerenciar frmForn = new frmFornGerenciar(true);
            frmForn.ShowDialog();
            if (frmForn.isBuscaConcluida())
            {
                String fornId = frmForn.getForn();
                forn = new Fornecedor();
                forn.Id = fornId;
                forn = forn.getById();
                ttbForn.Text = forn.RazaoS;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ttbForn.Text == "")
                ttbForn.BackColor = Color.Red;
            if (ttbValor.Text == "")
                ttbValor.BackColor = Color.Red;
            if (ttbNome.Text == "")
                ttbNome.BackColor = Color.Red;
            if (ttbForn.Text != "" && ttbValor.Text != "" && ttbNome.Text != "")
            {
                prod.FornId = forn.Id;
                prod.Desc = ttbNome.Text;
                prod.EstoqueA = "" + ttbEstAtual.Value;
                prod.EstoqueMin = "" + ttbEstMin.Value;
                prod.Valor = ttbValor.Text;
                if (prod.Id != "") //atualiza
                {
                    if (prod.atualiza())
                    {
                        MessageBox.Show("Alteração realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um erro ao efetuar a alteração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else //cadastra
                {
                    if (prod.novo())
                    {
                        MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreu um problema ao realizar o cadastro", "Problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ttbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool jaPossuiVirgula = false;
            int numCasasPosVirgula = 0;
            int i = 0;
            while (i < ((TextBox)sender).Text.Length && !jaPossuiVirgula)
            {
                if (((TextBox)sender).Text[i] == ',')
                    jaPossuiVirgula = true;
                i++;
                if (jaPossuiVirgula)
                    numCasasPosVirgula = ((TextBox)sender).Text.Length - i;
            }

            if (e.KeyChar == '.') //substitui . por , deixando no padrão decimal
                e.KeyChar = ',';

            if (e.KeyChar == ',')
                if (jaPossuiVirgula)
                    e.Handled = true; //impede digitação

            if (e.KeyChar != ',' && e.KeyChar != (char)8)
                if (!char.IsDigit(e.KeyChar) || numCasasPosVirgula > 1)
                    e.Handled = true;
        }

        private void ttbValor_Click(object sender, EventArgs e)
        {
            ttbValor.BackColor = Color.White;
        }

        private void ttbNome_Click(object sender, EventArgs e)
        {
            ttbNome.BackColor = Color.White;
        }
    }
}
