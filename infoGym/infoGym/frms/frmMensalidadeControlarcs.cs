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
    public partial class frmMensalidadeControlarcs : Form
    {
        Usuario user;
        Matricula mat;
        public frmMensalidadeControlarcs(Usuario user, String matCod)
        {
            InitializeComponent();
            Caixa cai = new Caixa();
            cai.CaiData = DateTime.Today.ToShortDateString();
            cai = cai.getCaixaByData();
            if (cai.CaiAbert == "")
            {
                MessageBox.Show("Caixa não foi aberto!", "Venda não permitida!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }

            mat = new Matricula();
            mat.Id = matCod;
            mat = mat.getById();
            this.user = user;
            Aluno aluAux = new Aluno();
            aluAux.Id = Convert.ToInt32(mat.AluId);
            aluAux = aluAux.getAlunoById();
            lblAluno.Text = aluAux.Nome;
            lblCod.Text = mat.Id;
            lblDtVcmto.Text = mat.DtVcmto;
            lblDtInicio.Text = DateTime.Parse(mat.DtIni).ToShortDateString();
            Modalidade modAux = new Modalidade();
            modAux.Id = mat.ModId;
            modAux = modAux.getById();
            lblModalidade.Text = modAux.Desc;
            if (mat.DtFim != "")
            {
                btnNovo.Visible = false;
            }

            if (mat.Tipo == "d")
                atualizaInterface();
            else
            {
                lblQtdeDias.Visible = false;
                lblCreditos.Visible = false;
                lblDias.Visible = false;
                dtgvMensalidades.Columns["colunaCoringa"].Visible = false;
                dtgvMensalidades.Columns["vcmto"].Visible = true;
            }
            dtgvMensalidades.DataSource = mat.getMensalidades();
        }

        private void atualizaInterface()
        {
            this.Text = "Controlar Diárias";
            dtgvMensalidades.Columns["colunaCoringa"].Visible = true;
            dtgvMensalidades.Columns["vcmto"].Visible = false;
            lblVcmto.Visible = false;
            lblDtVcmto.Visible = false;
            lblQtdeDias.Text = mat.QtdeDias;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (mat.Tipo == "d")
            {
                try
                {
                    new frmDiariaPgmto(mat.Id, user).ShowDialog();
                }
                catch
                {
                }
            }
            else
            {
                try
                {
                    new frmMensalidadePgmto(user, mat.Id).ShowDialog();
                }
                catch
                {
                }
            }
            dtgvMensalidades.DataSource = mat.getMensalidades();
        }
    }
}
