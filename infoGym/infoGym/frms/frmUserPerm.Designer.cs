namespace infoGym
{
    partial class frmUserPerm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbLiberar = new System.Windows.Forms.RadioButton();
            this.rbBloq = new System.Windows.Forms.RadioButton();
            this.dtgvCampos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.dtgvTelas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTelas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.dtgvTelas);
            this.groupBox1.Location = new System.Drawing.Point(25, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbLiberar);
            this.groupBox2.Controls.Add(this.rbBloq);
            this.groupBox2.Controls.Add(this.dtgvCampos);
            this.groupBox2.Location = new System.Drawing.Point(175, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 260);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos tela X";
            // 
            // rbLiberar
            // 
            this.rbLiberar.AutoSize = true;
            this.rbLiberar.Location = new System.Drawing.Point(256, 38);
            this.rbLiberar.Name = "rbLiberar";
            this.rbLiberar.Size = new System.Drawing.Size(90, 17);
            this.rbLiberar.TabIndex = 12;
            this.rbLiberar.TabStop = true;
            this.rbLiberar.Text = "Liberar Todos";
            this.rbLiberar.UseVisualStyleBackColor = true;
            this.rbLiberar.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // rbBloq
            // 
            this.rbBloq.AutoSize = true;
            this.rbBloq.Location = new System.Drawing.Point(256, 15);
            this.rbBloq.Name = "rbBloq";
            this.rbBloq.Size = new System.Drawing.Size(100, 17);
            this.rbBloq.TabIndex = 11;
            this.rbBloq.TabStop = true;
            this.rbBloq.Text = "Bloquear Todos";
            this.rbBloq.UseVisualStyleBackColor = true;
            this.rbBloq.CheckedChanged += new System.EventHandler(this.rbBloq_CheckedChanged);
            // 
            // dtgvCampos
            // 
            this.dtgvCampos.AllowUserToAddRows = false;
            this.dtgvCampos.AllowUserToDeleteRows = false;
            this.dtgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.Column2,
            this.dataGridViewTextBoxColumn2});
            this.dtgvCampos.Location = new System.Drawing.Point(6, 14);
            this.dtgvCampos.Name = "dtgvCampos";
            this.dtgvCampos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCampos.Size = new System.Drawing.Size(244, 240);
            this.dtgvCampos.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "camp_nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Campo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tela_id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "camp_id";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "usuariocamp_acesso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Acesso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Para selecionar basta dar duplo clique na tela desejada";
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(7, 20);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(248, 13);
            this.S.TabIndex = 8;
            this.S.Text = "Selecione uma tela para definir permissões para ela";
            // 
            // dtgvTelas
            // 
            this.dtgvTelas.AllowUserToAddRows = false;
            this.dtgvTelas.AllowUserToDeleteRows = false;
            this.dtgvTelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome});
            this.dtgvTelas.Location = new System.Drawing.Point(10, 49);
            this.dtgvTelas.Name = "dtgvTelas";
            this.dtgvTelas.ReadOnly = true;
            this.dtgvTelas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvTelas.Size = new System.Drawing.Size(143, 254);
            this.dtgvTelas.TabIndex = 7;
            this.dtgvTelas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvTelas_CellMouseDoubleClick);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "tela_nome";
            this.nome.HeaderText = "Tela";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(625, 330);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(107, 55);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuário:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(63, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "user";
            // 
            // frmUserPerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 394);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(771, 432);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(771, 432);
            this.Name = "frmUserPerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definir permissões";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvTelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLiberar;
        private System.Windows.Forms.RadioButton rbBloq;
        private System.Windows.Forms.DataGridView dtgvCampos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn2;
    }
}