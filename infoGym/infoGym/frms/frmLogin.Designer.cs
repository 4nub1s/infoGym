namespace infoGym
{
    partial class frmLogin
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
            this.ttbSenha = new System.Windows.Forms.TextBox();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttbSenha
            // 
            this.ttbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ttbSenha.Location = new System.Drawing.Point(104, 134);
            this.ttbSenha.MaxLength = 10;
            this.ttbSenha.Name = "ttbSenha";
            this.ttbSenha.PasswordChar = '●';
            this.ttbSenha.Size = new System.Drawing.Size(213, 31);
            this.ttbSenha.TabIndex = 11;
            this.ttbSenha.Text = "adm";
            this.ttbSenha.Click += new System.EventHandler(this.ttbLogin_Click);
            this.ttbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbSenha_KeyPress);
            // 
            // ttbLogin
            // 
            this.ttbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ttbLogin.Location = new System.Drawing.Point(104, 76);
            this.ttbLogin.MaxLength = 50;
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(213, 31);
            this.ttbLogin.TabIndex = 10;
            this.ttbLogin.Text = "adm";
            this.ttbLogin.Click += new System.EventHandler(this.ttbLogin_Click);
            this.ttbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbLogin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Para utilizar o sistema você deve estar logado.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(11, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnEntrar.Image = global::infoGym.Properties.Resources._33_128x128;
            this.btnEntrar.Location = new System.Drawing.Point(323, 118);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(142, 136);
            this.btnEntrar.TabIndex = 9;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 266);
            this.Controls.Add(this.ttbSenha);
            this.Controls.Add(this.ttbLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 304);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 304);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Logar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbSenha;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}