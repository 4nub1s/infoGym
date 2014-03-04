namespace infoGym
{
    partial class frmEntradaSaida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaSaida));
            this.lblData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.ttbDesc = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.Red;
            this.lblData.Location = new System.Drawing.Point(305, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "xx/xx/xxxx";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 24);
            this.panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(94, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Conectado como:";
            // 
            // btnConfirma
            // 
            this.btnConfirma.ImageIndex = 0;
            this.btnConfirma.ImageList = this.imageList1;
            this.btnConfirma.Location = new System.Drawing.Point(348, 125);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(79, 59);
            this.btnConfirma.TabIndex = 2;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "down_48x48.png");
            this.imageList1.Images.SetKeyName(1, "up_48x48.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição";
            // 
            // ttbDesc
            // 
            this.ttbDesc.Location = new System.Drawing.Point(15, 34);
            this.ttbDesc.Name = "ttbDesc";
            this.ttbDesc.Size = new System.Drawing.Size(311, 113);
            this.ttbDesc.TabIndex = 4;
            this.ttbDesc.Text = "";
            this.ttbDesc.Click += new System.EventHandler(this.ttbDesc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor";
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(44, 164);
            this.ttbValor.MaxLength = 10;
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(74, 20);
            this.ttbValor.TabIndex = 20;
            this.ttbValor.Click += new System.EventHandler(this.ttbValor_Click);
            this.ttbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValor_KeyPress);
            // 
            // frmEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 223);
            this.Controls.Add(this.ttbValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ttbDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblData);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(457, 261);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(457, 261);
            this.Name = "frmEntradaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ttbDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox ttbValor;
    }
}