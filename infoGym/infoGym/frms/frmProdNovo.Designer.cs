namespace infoGym
{
    partial class frmProdNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdNovo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbEstMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbEstAtual = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnForn = new System.Windows.Forms.Button();
            this.ttbForn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbEstMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttbEstAtual)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbValor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ttbEstMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ttbEstAtual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 132);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados produto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(138, 81);
            this.ttbValor.MaxLength = 10;
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(74, 20);
            this.ttbValor.TabIndex = 19;
            this.ttbValor.Click += new System.EventHandler(this.ttbValor_Click);
            this.ttbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValor_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ttbEstMin
            // 
            this.ttbEstMin.Location = new System.Drawing.Point(318, 50);
            this.ttbEstMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ttbEstMin.Name = "ttbEstMin";
            this.ttbEstMin.Size = new System.Drawing.Size(42, 20);
            this.ttbEstMin.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Estoque Mínimo";
            // 
            // ttbEstAtual
            // 
            this.ttbEstAtual.Location = new System.Drawing.Point(138, 50);
            this.ttbEstAtual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ttbEstAtual.Name = "ttbEstAtual";
            this.ttbEstAtual.Size = new System.Drawing.Size(42, 20);
            this.ttbEstAtual.TabIndex = 15;
            this.ttbEstAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Estoque Atual";
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(138, 19);
            this.ttbNome.MaxLength = 100;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(448, 20);
            this.ttbNome.TabIndex = 1;
            this.ttbNome.Click += new System.EventHandler(this.ttbNome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome / Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnForn);
            this.groupBox2.Controls.Add(this.ttbForn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(2, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 82);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fornecedor";
            // 
            // btnForn
            // 
            this.btnForn.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnForn.Location = new System.Drawing.Point(191, 17);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(61, 33);
            this.btnForn.TabIndex = 2;
            this.btnForn.UseVisualStyleBackColor = true;
            this.btnForn.Click += new System.EventHandler(this.btnForn_Click);
            // 
            // ttbForn
            // 
            this.ttbForn.Enabled = false;
            this.ttbForn.Location = new System.Drawing.Point(6, 19);
            this.ttbForn.Name = "ttbForn";
            this.ttbForn.Size = new System.Drawing.Size(182, 20);
            this.ttbForn.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnCadastrar.Location = new System.Drawing.Point(482, 163);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 69);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh_48x48.png");
            // 
            // frmProdNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 239);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 277);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 277);
            this.Name = "frmProdNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbEstMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttbEstAtual)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown ttbEstMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ttbEstAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.TextBox ttbForn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox ttbValor;
        private System.Windows.Forms.Label label7;
    }
}