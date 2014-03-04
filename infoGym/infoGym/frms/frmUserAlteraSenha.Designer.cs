namespace infoGym
{
    partial class frmUserAlteraSenha
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
            this.ttbNewPasC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbNewPas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbOldPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNewPasC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ttbNewPas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ttbOldPas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Acesso";
            // 
            // ttbNewPasC
            // 
            this.ttbNewPasC.Location = new System.Drawing.Point(124, 122);
            this.ttbNewPasC.MaxLength = 10;
            this.ttbNewPasC.Name = "ttbNewPasC";
            this.ttbNewPasC.PasswordChar = '●';
            this.ttbNewPasC.Size = new System.Drawing.Size(120, 20);
            this.ttbNewPasC.TabIndex = 12;
            this.ttbNewPasC.Click += new System.EventHandler(this.ttbOldPas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirmar Nova Senha";
            // 
            // ttbNewPas
            // 
            this.ttbNewPas.Location = new System.Drawing.Point(124, 93);
            this.ttbNewPas.MaxLength = 10;
            this.ttbNewPas.Name = "ttbNewPas";
            this.ttbNewPas.PasswordChar = '●';
            this.ttbNewPas.Size = new System.Drawing.Size(120, 20);
            this.ttbNewPas.TabIndex = 10;
            this.ttbNewPas.Click += new System.EventHandler(this.ttbOldPas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nova Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(250, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Máximo de 10 caracteres alfanúmericos";
            // 
            // ttbOldPas
            // 
            this.ttbOldPas.Location = new System.Drawing.Point(124, 61);
            this.ttbOldPas.MaxLength = 10;
            this.ttbOldPas.Name = "ttbOldPas";
            this.ttbOldPas.PasswordChar = '●';
            this.ttbOldPas.Size = new System.Drawing.Size(120, 20);
            this.ttbOldPas.TabIndex = 7;
            this.ttbOldPas.Click += new System.EventHandler(this.ttbOldPas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha Antiga";
            // 
            // ttbLogin
            // 
            this.ttbLogin.Enabled = false;
            this.ttbLogin.Location = new System.Drawing.Point(124, 26);
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(120, 20);
            this.ttbLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(471, 154);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 39);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmUserAlteraSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 210);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(573, 248);
            this.Name = "frmUserAlteraSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar senha de acesso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbOldPas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbNewPasC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbNewPas;
        private System.Windows.Forms.Label label4;
    }
}