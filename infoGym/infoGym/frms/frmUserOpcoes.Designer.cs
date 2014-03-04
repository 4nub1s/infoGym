namespace infoGym
{
    partial class frmUserOpcoes
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
            this.btnAcesso = new System.Windows.Forms.Button();
            this.btnBloq = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcesso
            // 
            this.btnAcesso.Location = new System.Drawing.Point(185, 41);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Size = new System.Drawing.Size(78, 37);
            this.btnAcesso.TabIndex = 10;
            this.btnAcesso.Text = "Alterar Acesso";
            this.btnAcesso.UseVisualStyleBackColor = true;
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // btnBloq
            // 
            this.btnBloq.Location = new System.Drawing.Point(91, 41);
            this.btnBloq.Name = "btnBloq";
            this.btnBloq.Size = new System.Drawing.Size(78, 37);
            this.btnBloq.TabIndex = 9;
            this.btnBloq.Text = "Bloquear / Desbloquear";
            this.btnBloq.UseVisualStyleBackColor = true;
            this.btnBloq.Click += new System.EventHandler(this.btnBloq_Click);
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(6, 41);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(65, 37);
            this.btnCon.TabIndex = 8;
            this.btnCon.Text = "Ver Conexões";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciando usuário:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(222, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.btnBloq);
            this.groupBox1.Controls.Add(this.btnAcesso);
            this.groupBox1.Location = new System.Drawing.Point(81, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha uma opção";
            // 
            // frmUserOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 152);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(442, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(442, 190);
            this.Name = "frmUserOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuário";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcesso;
        private System.Windows.Forms.Button btnBloq;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}