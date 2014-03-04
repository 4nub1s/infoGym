namespace infoGym.frms
{
    partial class frmBackupRestaurar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbOrigem = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbApenasDados = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbOrigem);
            this.groupBox1.Controls.Add(this.btnDestino);
            this.groupBox1.Location = new System.Drawing.Point(24, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a localização da cópia de segurança (.backup)";
            // 
            // ttbOrigem
            // 
            this.ttbOrigem.Enabled = false;
            this.ttbOrigem.Location = new System.Drawing.Point(6, 34);
            this.ttbOrigem.Name = "ttbOrigem";
            this.ttbOrigem.Size = new System.Drawing.Size(353, 20);
            this.ttbOrigem.TabIndex = 4;
            this.ttbOrigem.Tag = "1";
            // 
            // btnDestino
            // 
            this.btnDestino.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnDestino.Location = new System.Drawing.Point(365, 21);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(75, 44);
            this.btnDestino.TabIndex = 3;
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(148, 12);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(91, 17);
            this.rbAll.TabIndex = 6;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Dados e fotos";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbApenasDados
            // 
            this.rbApenasDados.AutoSize = true;
            this.rbApenasDados.Location = new System.Drawing.Point(24, 12);
            this.rbApenasDados.Name = "rbApenasDados";
            this.rbApenasDados.Size = new System.Drawing.Size(93, 17);
            this.rbApenasDados.TabIndex = 5;
            this.rbApenasDados.TabStop = true;
            this.rbApenasDados.Text = "Apenas dados";
            this.rbApenasDados.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Image = global::infoGym.Properties.Resources.cdrom_mount1;
            this.btnGerar.Location = new System.Drawing.Point(375, 212);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(108, 69);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ao restaurar o backup o InfoGym reiniciará e você perderá os dados atuais!";
            // 
            // frmBackupRestaurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbApenasDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 331);
            this.Name = "frmBackupRestaurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurar Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbOrigem;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbApenasDados;
        private System.Windows.Forms.Label label1;

    }
}