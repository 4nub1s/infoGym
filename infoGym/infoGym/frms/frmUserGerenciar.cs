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
    public partial class frmUsuarioControlar : Form
    {
        String nomeTela = "Gerenciar Usuários";
        String filtro;
        Usuario userLogado;
        Usuario user;
        DataTable dtUser;
        public frmUsuarioControlar(Usuario userLogado)
        {
            InitializeComponent();
            this.userLogado = userLogado;
            if (!userLogado.hasAcessoTela(nomeTela))
                this.Close();
            user = new Usuario();
            user.Login = "";
            filtro = "all";
            carregaDt();
        }

        private void exibeOcultaCampos()
        {
            DataTable campos = user.getCamposUsuario();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmUserCad().ShowDialog();
            carregaDt();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void carregaDt()
        {
            dtUser = user.getUsuarios(filtro);
            dtgvUsuarios.DataSource = dtUser;
        }

        private void ttbLogin_KeyUp(object sender, KeyEventArgs e)
        {
            user.Login = ttbLogin.Text;
            carregaDt();
        }

        private void rbBloq_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBloq.Checked)
                filtro = "bloq";
            if (rbAll.Checked)
                filtro = "all";
            if (rbDesbloq.Checked)
                filtro = "desbloq";
            carregaDt();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            new frmUserPerm(user).ShowDialog();
        }

        private void dtgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                user.Id = Convert.ToInt32(dtgvUsuarios["usuario_id", e.RowIndex].Value);
                user.Login = dtgvUsuarios["usuario_login", e.RowIndex].Value.ToString();
                new frmUserOpcoes(user).ShowDialog();
                user.Login = "";
         
            }
        }





    }
}
