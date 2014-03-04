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
    public partial class frmClick : Form
    {
        Bitmap aux;

        public Bitmap getImage()
        {
            return aux;
        }

        public frmClick()
        {
            InitializeComponent();
        }


        private void btnClick_Click(object sender, EventArgs e)
        {
            genericFilter1.Enabled = true;
        }

        private void btnConfirma_Click_1(object sender, EventArgs e)
        {
            genericFilter1.Dispose();
            dsCapture1.Dispose();
            this.Close();
        }

        private void genericFilter1_ProcessData(object Sender, Mitov.VideoLab.ProcessVideoNotifyArgs Args)
        {
            aux = new Bitmap(Args.InBuffer.ToBitmap(), new Size(150, 150));
            pictureBox1.Image = aux;
            genericFilter1.Enabled = false;
        }
    }
}
