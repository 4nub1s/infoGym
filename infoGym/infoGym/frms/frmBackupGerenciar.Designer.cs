namespace infoGym.frms
{
    partial class frmBackupGerenciar
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
            this.lblRealizar = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRestaurar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizar
            // 
            this.lblRealizar.AutoSize = true;
            this.lblRealizar.Location = new System.Drawing.Point(172, 81);
            this.lblRealizar.Name = "lblRealizar";
            this.lblRealizar.Size = new System.Drawing.Size(142, 13);
            this.lblRealizar.TabIndex = 1;
            this.lblRealizar.TabStop = true;
            this.lblRealizar.Text = "Realizar cópia de segurança";
            this.lblRealizar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRealizar_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::infoGym.Properties.Resources.cdrom_mount;
            this.pictureBox2.Location = new System.Drawing.Point(36, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 136);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::infoGym.Properties.Resources.cdrom_unmount;
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRestaurar
            // 
            this.lblRestaurar.AutoSize = true;
            this.lblRestaurar.Location = new System.Drawing.Point(172, 238);
            this.lblRestaurar.Name = "lblRestaurar";
            this.lblRestaurar.Size = new System.Drawing.Size(150, 13);
            this.lblRestaurar.TabIndex = 3;
            this.lblRestaurar.TabStop = true;
            this.lblRestaurar.Text = "Restaurar cópia de segurança";
            this.lblRestaurar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRestaurar_LinkClicked);
            // 
            // frmBackupGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 346);
            this.Controls.Add(this.lblRestaurar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRealizar);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(511, 384);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(511, 384);
            this.Name = "frmBackupGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Backup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblRealizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lblRestaurar;
    }
}