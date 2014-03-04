using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace infoGym
{
    public partial class frmTermoAnamnese : Form
    {
        Utils util;
        String fotoPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\anamnese\";
        String anaId;
        public frmTermoAnamnese(String anaId)
        {
            InitializeComponent();
            util = new Utils();
            this.anaId = anaId;
            if (util.existeImgAssociada("anamnese", anaId))
                pictureBox1.ImageLocation = fotoPath + anaId + ".jpg";
            else
                pictureBox1.ImageLocation = fotoPath + "default.jpg";

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap myBitmap1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(myBitmap1, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(myBitmap1, 0, 0);
            myBitmap1.Dispose();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Aceita apenas imagens|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            util.gravarFoto(fotoPath + anaId + ".jpg", pictureBox1.Image);
            MessageBox.Show("Termo cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
