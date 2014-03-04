namespace infoGym.frms
{
    partial class frmModNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModNova));
            this.ttbValorM = new System.Windows.Forms.TextBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ttbValorD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ttbValorM
            // 
            this.ttbValorM.Location = new System.Drawing.Point(77, 47);
            this.ttbValorM.MaxLength = 10;
            this.ttbValorM.Name = "ttbValorM";
            this.ttbValorM.Size = new System.Drawing.Size(66, 20);
            this.ttbValorM.TabIndex = 8;
            this.ttbValorM.Click += new System.EventHandler(this.ttbNome_Click);
            this.ttbValorM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValorM_KeyPress);
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(77, 20);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(205, 20);
            this.ttbNome.TabIndex = 7;
            this.ttbNome.Click += new System.EventHandler(this.ttbNome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor Mensal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnAdd.Location = new System.Drawing.Point(296, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 66);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ttbValorD
            // 
            this.ttbValorD.Location = new System.Drawing.Point(77, 77);
            this.ttbValorD.MaxLength = 10;
            this.ttbValorD.Name = "ttbValorD";
            this.ttbValorD.Size = new System.Drawing.Size(66, 20);
            this.ttbValorD.TabIndex = 12;
            this.ttbValorD.Click += new System.EventHandler(this.ttbNome_Click);
            this.ttbValorD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValorM_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Diário";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh_48x48.png");
            // 
            // frmModalidadeNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 131);
            this.Controls.Add(this.ttbValorD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ttbValorM);
            this.Controls.Add(this.ttbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(392, 169);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(392, 169);
            this.Name = "frmModalidadeNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Modalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox ttbValorM;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbValorD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
    }
}