namespace infoGym
{
    partial class frmUserBloq
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesbloq = new System.Windows.Forms.RadioButton();
            this.rbBloq = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(62, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label4";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Image = global::infoGym.Properties.Resources.redo_48x48;
            this.btnAplicar.Location = new System.Drawing.Point(255, 80);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(105, 49);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDesbloq);
            this.groupBox1.Controls.Add(this.rbBloq);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbDesbloq
            // 
            this.rbDesbloq.AutoSize = true;
            this.rbDesbloq.Location = new System.Drawing.Point(100, 28);
            this.rbDesbloq.Name = "rbDesbloq";
            this.rbDesbloq.Size = new System.Drawing.Size(94, 17);
            this.rbDesbloq.TabIndex = 1;
            this.rbDesbloq.TabStop = true;
            this.rbDesbloq.Text = "Desbloqueado";
            this.rbDesbloq.UseVisualStyleBackColor = true;
            this.rbDesbloq.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // rbBloq
            // 
            this.rbBloq.AutoSize = true;
            this.rbBloq.Location = new System.Drawing.Point(6, 28);
            this.rbBloq.Name = "rbBloq";
            this.rbBloq.Size = new System.Drawing.Size(76, 17);
            this.rbBloq.TabIndex = 0;
            this.rbBloq.TabStop = true;
            this.rbBloq.Text = "Bloqueado";
            this.rbBloq.UseVisualStyleBackColor = true;
            this.rbBloq.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Importante: Um usuário bloqueado não consiguirá acessar o sistema até que seja de" +
                "sbloqueado!";
            // 
            // frmUserBloq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 197);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 197);
            this.Name = "frmUserBloq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloquear / Desbloquear Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDesbloq;
        private System.Windows.Forms.RadioButton rbBloq;
        private System.Windows.Forms.Label label2;
    }
}