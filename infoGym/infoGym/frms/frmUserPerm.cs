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
    public partial class frmUserPerm : Form
    {
        Usuario user;
        DataTable dtTelas;
        DataTable dtAtual;
        DataTable dtUserCampo;
        public frmUserPerm(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblUser.Text = user.Login;

            carregarDttUserCampo();
            carregarDtgvTelas();
        }

        private void carregarDttUserCampo()
        {
            dtUserCampo = user.getCamposUsuario();
            dtAtual = dtUserCampo.Clone();
            dtAtual.Clear();
            dtgvCampos.DataSource = dtAtual;
        }

        private void carregarDtgvTelas()
        {
            dtTelas = user.gettela();
            dtgvTelas.DataSource = dtTelas;
        }

        private void salvaAlteracoes()
        {
            for (int i = 0; i < dtAtual.Rows.Count; i++)
            {
                for (int j = 0; j < dtUserCampo.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dtAtual.Rows[i]["tela_id"]) == Convert.ToInt32(dtUserCampo.Rows[j]["tela_id"]) &&
                        Convert.ToInt32(dtAtual.Rows[i]["camp_id"]) == Convert.ToInt32(dtUserCampo.Rows[j]["camp_id"]))
                    {
                        dtUserCampo.Rows[j]["usuariocamp_acesso"] = dtAtual.Rows[i]["usuariocamp_acesso"];
                    }
                }
            }
            dtAtual.Clear();
        }

        private void dtgvTelas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtAtual.Rows.Count > 0) //salva alterações
                {
                    salvaAlteracoes();
                }

                int tela = Convert.ToInt32(dtTelas.Rows[e.RowIndex]["tela_id"]);
                for (int i = 0; i < dtUserCampo.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtUserCampo.Rows[i]["tela_id"]) == tela)
                    {
                        int campoId = Convert.ToInt32(dtUserCampo.Rows[i]["camp_id"]);
                        bool campAcesso = Convert.ToBoolean(dtUserCampo.Rows[i]["usuariocamp_acesso"]);
                        String campNome = "" + dtUserCampo.Rows[i]["camp_nome"];
                        DataRow linha = dtAtual.NewRow();
                        linha["camp_id"] = campoId;
                        linha["tela_id"] = tela;
                        linha["usuariocamp_acesso"] = campAcesso;
                        linha["camp_nome"] = campNome;
                        dtAtual.Rows.Add(linha);
                    }
                }
            }
        }

        private void rbBloq_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBloq.Checked)
            {
                if (dtAtual.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUserCampo.Rows.Count; i++)
                    {
                        dtAtual.Rows[i]["usuariocamp_acesso"] = false;
                    }
                }
            }
            else
            {
                if (dtAtual.Rows.Count > 0)
                {
                    for (int i = 0; i < dtUserCampo.Rows.Count; i++)
                    {
                        dtAtual.Rows[i]["usuariocamp_acesso"] = true;
                    }
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dtAtual.Rows.Count > 0) //salva alterações
            {
                salvaAlteracoes();
            }
            if (user.atualizaPerm(dtUserCampo))
            {
                MessageBox.Show("Permissões atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Problemas durante a atualização das permissões!", "Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
