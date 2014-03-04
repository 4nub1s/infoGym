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
    public partial class frmUserConexoes : Form
    {
        Usuario user;
        DataTable dt;
        String filtro;
        public frmUserConexoes(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lblUser.Text = user.Login;
            noFiltro.Checked = true;
            carregaDt();
        }

        private void noFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (noFiltro.Checked)
            {
                filtro = "off";
                gpFiltro.Enabled = false;
                carregaDt();
            }
            else
            {
                filtro = "on";
                gpFiltro.Enabled = true;
            }
        }

        private void carregaDt()
        {
            dt = user.getConexoes(dtInicio.Value, dtFim.Value, filtro);
            dtgvConexoes.DataSource = dt;
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            carregaDt();
        }
    }
}
