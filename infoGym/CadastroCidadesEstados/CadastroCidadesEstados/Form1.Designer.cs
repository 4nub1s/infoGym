namespace CadastroCidadesEstados
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbDataBase = new System.Windows.Forms.TextBox();
            this.ttbPass = new System.Windows.Forms.TextBox();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.ttbPorta = new System.Windows.Forms.TextBox();
            this.ttbIp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ttbScript = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Este aplicativo tem por objetivo importar cidades e estados para uma base de ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "dados à partir de arquivos .txt (Banco Postgree)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desenvolvido por: JC 2013";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 28);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(622, 41);
            this.panel3.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbDataBase);
            this.groupBox1.Controls.Add(this.ttbPass);
            this.groupBox1.Controls.Add(this.ttbLogin);
            this.groupBox1.Controls.Add(this.ttbPorta);
            this.groupBox1.Controls.Add(this.ttbIp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 216);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Base";
            // 
            // ttbDataBase
            // 
            this.ttbDataBase.Location = new System.Drawing.Point(104, 140);
            this.ttbDataBase.Name = "ttbDataBase";
            this.ttbDataBase.Size = new System.Drawing.Size(166, 20);
            this.ttbDataBase.TabIndex = 9;
            this.ttbDataBase.Text = "infoGym";
            this.ttbDataBase.Click += new System.EventHandler(this.ttbBase_Click);
            // 
            // ttbPass
            // 
            this.ttbPass.Location = new System.Drawing.Point(104, 110);
            this.ttbPass.Name = "ttbPass";
            this.ttbPass.PasswordChar = '*';
            this.ttbPass.Size = new System.Drawing.Size(166, 20);
            this.ttbPass.TabIndex = 8;
            this.ttbPass.Text = "postgres123";
            this.ttbPass.Click += new System.EventHandler(this.ttbBase_Click);
            // 
            // ttbLogin
            // 
            this.ttbLogin.Location = new System.Drawing.Point(104, 78);
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(166, 20);
            this.ttbLogin.TabIndex = 7;
            this.ttbLogin.Text = "postgres";
            this.ttbLogin.Click += new System.EventHandler(this.ttbBase_Click);
            // 
            // ttbPorta
            // 
            this.ttbPorta.Location = new System.Drawing.Point(104, 49);
            this.ttbPorta.Name = "ttbPorta";
            this.ttbPorta.Size = new System.Drawing.Size(166, 20);
            this.ttbPorta.TabIndex = 6;
            this.ttbPorta.Text = "5432";
            this.ttbPorta.Click += new System.EventHandler(this.ttbBase_Click);
            // 
            // ttbIp
            // 
            this.ttbIp.Location = new System.Drawing.Point(104, 17);
            this.ttbIp.Name = "ttbIp";
            this.ttbIp.Size = new System.Drawing.Size(166, 20);
            this.ttbIp.TabIndex = 5;
            this.ttbIp.Text = "127.0.0.1";
            this.ttbIp.Click += new System.EventHandler(this.ttbBase_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "DataBase Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Login";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Porta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IpServer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Estrutura Banco: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CadastroCidadesEstados.Properties.Resources.Sem_título1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 153);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::CadastroCidadesEstados.Properties.Resources.redo_48x48;
            this.btnStart.Location = new System.Drawing.Point(514, 378);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 74);
            this.btnStart.TabIndex = 10;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(3, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(305, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Para o programa funcionar as tabelas devem ter essa estrutura!";
            // 
            // ttbScript
            // 
            this.ttbScript.Location = new System.Drawing.Point(224, 299);
            this.ttbScript.Name = "ttbScript";
            this.ttbScript.Size = new System.Drawing.Size(266, 153);
            this.ttbScript.TabIndex = 15;
            this.ttbScript.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Script para criação das tabelas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 506);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ttbScript);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cadastro de Cidades e Estados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox ttbIp;
        private System.Windows.Forms.TextBox ttbPorta;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.TextBox ttbDataBase;
        private System.Windows.Forms.TextBox ttbPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox ttbScript;
        private System.Windows.Forms.Label label10;
    }
}

