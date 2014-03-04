namespace infoGym
{
    partial class frmUsuarioControlar
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
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.usuario_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acesso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbDesbloq = new System.Windows.Forms.RadioButton();
            this.rbBloq = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AllowUserToAddRows = false;
            this.dtgvUsuarios.AllowUserToDeleteRows = false;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario_login,
            this.usuario_id,
            this.usuario_pass,
            this.func_nome,
            this.Acesso});
            this.dtgvUsuarios.Location = new System.Drawing.Point(12, 175);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.ReadOnly = true;
            this.dtgvUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvUsuarios.Size = new System.Drawing.Size(552, 332);
            this.dtgvUsuarios.TabIndex = 0;
            this.dtgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellDoubleClick);
            // 
            // usuario_login
            // 
            this.usuario_login.DataPropertyName = "usuario_login";
            this.usuario_login.HeaderText = "Login";
            this.usuario_login.MinimumWidth = 150;
            this.usuario_login.Name = "usuario_login";
            this.usuario_login.ReadOnly = true;
            this.usuario_login.Width = 150;
            // 
            // usuario_id
            // 
            this.usuario_id.DataPropertyName = "usuario_id";
            this.usuario_id.HeaderText = "Column1";
            this.usuario_id.Name = "usuario_id";
            this.usuario_id.ReadOnly = true;
            this.usuario_id.Visible = false;
            // 
            // usuario_pass
            // 
            this.usuario_pass.DataPropertyName = "usuario_pass";
            this.usuario_pass.HeaderText = "Column2";
            this.usuario_pass.Name = "usuario_pass";
            this.usuario_pass.ReadOnly = true;
            this.usuario_pass.Visible = false;
            // 
            // func_nome
            // 
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Funcionário";
            this.func_nome.MinimumWidth = 300;
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
            this.func_nome.Width = 300;
            // 
            // Acesso
            // 
            this.Acesso.DataPropertyName = "usuario_status";
            this.Acesso.FillWeight = 60F;
            this.Acesso.HeaderText = "Acesso";
            this.Acesso.MinimumWidth = 60;
            this.Acesso.Name = "Acesso";
            this.Acesso.ReadOnly = true;
            this.Acesso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Acesso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Acesso.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // ttbLogin
            // 
            this.ttbLogin.Location = new System.Drawing.Point(46, 19);
            this.ttbLogin.MaxLength = 20;
            this.ttbLogin.Name = "ttbLogin";
            this.ttbLogin.Size = new System.Drawing.Size(151, 20);
            this.ttbLogin.TabIndex = 5;
            this.ttbLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ttbLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ttbLogin_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ttbLogin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAll);
            this.groupBox2.Controls.Add(this.rbDesbloq);
            this.groupBox2.Controls.Add(this.rbBloq);
            this.groupBox2.Location = new System.Drawing.Point(9, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(194, 41);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(55, 17);
            this.rbAll.TabIndex = 11;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Todos";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // rbDesbloq
            // 
            this.rbDesbloq.AutoSize = true;
            this.rbDesbloq.Location = new System.Drawing.Point(94, 41);
            this.rbDesbloq.Name = "rbDesbloq";
            this.rbDesbloq.Size = new System.Drawing.Size(94, 17);
            this.rbDesbloq.TabIndex = 10;
            this.rbDesbloq.TabStop = true;
            this.rbDesbloq.Text = "Desbloqueado";
            this.rbDesbloq.UseVisualStyleBackColor = true;
            this.rbDesbloq.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // rbBloq
            // 
            this.rbBloq.AutoSize = true;
            this.rbBloq.Location = new System.Drawing.Point(12, 41);
            this.rbBloq.Name = "rbBloq";
            this.rbBloq.Size = new System.Drawing.Size(76, 17);
            this.rbBloq.TabIndex = 9;
            this.rbBloq.TabStop = true;
            this.rbBloq.Text = "Bloqueado";
            this.rbBloq.UseVisualStyleBackColor = true;
            this.rbBloq.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dê um duplo clique no usuário que deseja editar";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources._6420_128x128;
            this.btnNovo.Location = new System.Drawing.Point(583, 360);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 147);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmUsuarioControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgvUsuarios);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(726, 552);
            this.Name = "frmUsuarioControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbDesbloq;
        private System.Windows.Forms.RadioButton rbBloq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Acesso;
    }
}