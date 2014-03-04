namespace infoGym.frms
{
    partial class frmBackupRealizar
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
            this.rbApenasDados = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbDestino = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbApenasDados
            // 
            this.rbApenasDados.AutoSize = true;
            this.rbApenasDados.Location = new System.Drawing.Point(24, 12);
            this.rbApenasDados.Name = "rbApenasDados";
            this.rbApenasDados.Size = new System.Drawing.Size(93, 17);
            this.rbApenasDados.TabIndex = 0;
            this.rbApenasDados.TabStop = true;
            this.rbApenasDados.Text = "Apenas dados";
            this.rbApenasDados.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(148, 12);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(91, 17);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Dados e fotos";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbDestino);
            this.groupBox1.Controls.Add(this.btnDestino);
            this.groupBox1.Location = new System.Drawing.Point(24, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o destino da cópia de segurança";
            // 
            // ttbDestino
            // 
            this.ttbDestino.Enabled = false;
            this.ttbDestino.Location = new System.Drawing.Point(6, 34);
            this.ttbDestino.Name = "ttbDestino";
            this.ttbDestino.Size = new System.Drawing.Size(353, 20);
            this.ttbDestino.TabIndex = 4;
            this.ttbDestino.Tag = "1";
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
            // btnGerar
            // 
            this.btnGerar.Image = global::infoGym.Properties.Resources.cdrom_unmount1;
            this.btnGerar.Location = new System.Drawing.Point(375, 212);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(108, 69);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmBackupRealizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbApenasDados);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 331);
            this.Name = "frmBackupRealizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbApenasDados;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbDestino;
    }
}