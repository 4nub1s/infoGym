namespace infoGym
{
    partial class frmUserCad
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ttbConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbSenha = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnPerm = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ttbConfirmaSenha);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ttbLogin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ttbSenha);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 129);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // ttbConfirmaSenha
            // 
            this.ttbConfirmaSenha.Location = new System.Drawing.Point(95, 77);
            this.ttbConfirmaSenha.MaxLength = 10;
            this.ttbConfirmaSenha.Name = "ttbConfirmaSenha";
            this.ttbConfirmaSenha.PasswordChar = '●';
            this.ttbConfirmaSenha.Size = new System.Drawing.Size(82, 20);
            this.ttbConfirmaSenha.TabIndex = 10;
            this.ttbConfirmaSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ttbLogin_MouseClick);
            this.ttbConfirmaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbConfirmaSenha_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(230, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Máx. 20 caracteres alfanuméricos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(183, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Máx. 10 caracteres alfanuméricos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar senha";
            // 
            // ttbLogin
            // 
            this.ttbLogin.Location = new System.Drawing.Point(95, 22);
            this.ttbLogin.MaxLength = 20;
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(129, 20);
            this.ttbLogin.TabIndex = 2;
            this.ttbLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ttbLogin_MouseClick);
            this.ttbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // ttbSenha
            // 
            this.ttbSenha.Location = new System.Drawing.Point(95, 48);
            this.ttbSenha.MaxLength = 10;
            this.ttbSenha.Name = "ttbSenha";
            this.ttbSenha.PasswordChar = '●';
            this.ttbSenha.Size = new System.Drawing.Size(82, 20);
            this.ttbSenha.TabIndex = 4;
            this.ttbSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ttbLogin_MouseClick);
            this.ttbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbSenha_KeyPress);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(440, 75);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(75, 23);
            this.btnCad.TabIndex = 10;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnPerm
            // 
            this.btnPerm.Enabled = false;
            this.btnPerm.Location = new System.Drawing.Point(440, 104);
            this.btnPerm.Name = "btnPerm";
            this.btnPerm.Size = new System.Drawing.Size(75, 37);
            this.btnPerm.TabIndex = 11;
            this.btnPerm.Text = "Definir permissões";
            this.btnPerm.UseVisualStyleBackColor = true;
            this.btnPerm.Click += new System.EventHandler(this.btnPerm_Click);
            // 
            // frmUserCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 164);
            this.Controls.Add(this.btnPerm);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(542, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 202);
            this.Name = "frmUserCad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de usuário";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ttbConfirmaSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbSenha;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnPerm;
    }
}