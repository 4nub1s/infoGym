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
    public partial class frmDespesaNova : Form
    {
        Usuario user;
        Utils util;
        Despesa desp;
        public frmDespesaNova(Usuario user, String despId)
        {
            InitializeComponent();
            this.user = user;
            desp = new Despesa();
            util = new Utils();
            util.moneyMaskFormata(ttbValorPgmto);
            util.moneyMaskFormata(ttbValor);
            if (despId != "")
            {
                this.Text = "Alterar Despesa";
                desp.Id = despId;
                desp = desp.getById();
                ttbDesc.Text = desp.Desc;
                ttbValor.Text = desp.Valor;
                if (desp.DtPgmto != "")
                {
                    rbPaga.Checked = true;
                    gpbPagamento.Enabled = true;
                    ttbValorPgmto.Text = desp.ValorPg;
                    dtpPagamento.Value = DateTime.Parse(desp.DtPgmto);
                }
                else
                    rbApagar.Checked = true;
                dtpVcmto.Value = DateTime.Parse(desp.DtVcmto);
            }
            else
                rbApagar.Checked = true;
            util.setCamposObrigatorios(Controls);
        }

        private void rbApagar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApagar.Checked)
            {
                gpbPagamento.Enabled = false;
                ttbValorPgmto.Tag = "0";
            }
            else
            {
                gpbPagamento.Enabled = true;
                ttbValorPgmto.Tag = "1";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (util.verificarPreenchimentoCamposObrigatorios())
            {
                desp.Desc = ttbDesc.Text;
                desp.DtVcmto = dtpVcmto.Value.ToShortDateString();
                desp.Valor = ttbValor.Text;
                if (gpbPagamento.Enabled)
                {
                    desp.DtPgmto = dtpPagamento.Value.ToShortDateString();
                    desp.ValorPg = ttbValorPgmto.Text;
                }
                else
                {
                    desp.DtPgmto = "";
                    desp.ValorPg = "";
                }
                if (desp.Id != "") //atualizar
                {
                    if (desp.atualizar())
                    {
                        MessageBox.Show("Despesa atualizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao atualizar a despesa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else //cadastrar
                {
                    if (desp.nova())
                    {
                        MessageBox.Show("Despesa lançada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ocorreram problemas ao cadastrar a despesa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
