namespace infoGym
{
    partial class frmTermoNovo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserOn = new System.Windows.Forms.Label();
            this.lblUltimaAlter1 = new System.Windows.Forms.Label();
            this.lblUltimaAlter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 594);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o termo digitalizado";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUltimaAlter);
            this.panel2.Controls.Add(this.lblUltimaAlter1);
            this.panel2.Controls.Add(this.lblUserOn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 699);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 31);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionar);
            this.groupBox1.Controls.Add(this.ttbAluno);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // ttbAluno
            // 
            this.ttbAluno.Enabled = false;
            this.ttbAluno.Location = new System.Drawing.Point(6, 19);
            this.ttbAluno.MaxLength = 100;
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(322, 20);
            this.ttbAluno.TabIndex = 0;
            this.ttbAluno.TextChanged += new System.EventHandler(this.ttbAluno_TextChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Image = global::infoGym.Properties.Resources.search_481;
            this.btnSelecionar.Location = new System.Drawing.Point(334, 10);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(54, 65);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = global::infoGym.Properties.Resources.folder_add_48;
            this.btnAbrir.Location = new System.Drawing.Point(527, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 44);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::infoGym.Properties.Resources.apply;
            this.btnGravar.Location = new System.Drawing.Point(806, 565);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(141, 128);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Logado como:";
            // 
            // lblUserOn
            // 
            this.lblUserOn.AutoSize = true;
            this.lblUserOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOn.Location = new System.Drawing.Point(82, 9);
            this.lblUserOn.Name = "lblUserOn";
            this.lblUserOn.Size = new System.Drawing.Size(45, 13);
            this.lblUserOn.TabIndex = 1;
            this.lblUserOn.Text = "Fulano";
            // 
            // lblUltimaAlter1
            // 
            this.lblUltimaAlter1.AutoSize = true;
            this.lblUltimaAlter1.Location = new System.Drawing.Point(269, 9);
            this.lblUltimaAlter1.Name = "lblUltimaAlter1";
            this.lblUltimaAlter1.Size = new System.Drawing.Size(114, 13);
            this.lblUltimaAlter1.TabIndex = 2;
            this.lblUltimaAlter1.Text = "Última atualização por:";
            // 
            // lblUltimaAlter
            // 
            this.lblUltimaAlter.AutoSize = true;
            this.lblUltimaAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaAlter.Location = new System.Drawing.Point(378, 9);
            this.lblUltimaAlter.Name = "lblUltimaAlter";
            this.lblUltimaAlter.Size = new System.Drawing.Size(45, 13);
            this.lblUltimaAlter.TabIndex = 3;
            this.lblUltimaAlter.Text = "Fulano";
            // 
            // frmTermoNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 730);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(975, 768);
            this.Name = "frmTermoNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo termo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblUserOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUltimaAlter;
        private System.Windows.Forms.Label lblUltimaAlter1;

    }
}