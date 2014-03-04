namespace infoGym
{
    partial class frmFuncGerenciamento
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
            this.gpbAlunoSelecionado = new System.Windows.Forms.GroupBox();
            this.lblNomeAtual = new System.Windows.Forms.Label();
            this.imgFuncSele = new System.Windows.Forms.PictureBox();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExternos = new System.Windows.Forms.Label();
            this.lblInternos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblInativos = new System.Windows.Forms.Label();
            this.lblAtivos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotFunc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAtivos = new System.Windows.Forms.CheckBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbExterno = new System.Windows.Forms.RadioButton();
            this.rbInterno = new System.Windows.Forms.RadioButton();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvFunc = new System.Windows.Forms.DataGridView();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbAlunoSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncSele)).BeginInit();
            this.Informações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbAlunoSelecionado
            // 
            this.gpbAlunoSelecionado.Controls.Add(this.lblNomeAtual);
            this.gpbAlunoSelecionado.Controls.Add(this.imgFuncSele);
            this.gpbAlunoSelecionado.Location = new System.Drawing.Point(592, 206);
            this.gpbAlunoSelecionado.Name = "gpbAlunoSelecionado";
            this.gpbAlunoSelecionado.Size = new System.Drawing.Size(336, 205);
            this.gpbAlunoSelecionado.TabIndex = 23;
            this.gpbAlunoSelecionado.TabStop = false;
            this.gpbAlunoSelecionado.Text = "Aluno Selecionado";
            // 
            // lblNomeAtual
            // 
            this.lblNomeAtual.AutoSize = true;
            this.lblNomeAtual.ForeColor = System.Drawing.Color.Blue;
            this.lblNomeAtual.Location = new System.Drawing.Point(88, 172);
            this.lblNomeAtual.Name = "lblNomeAtual";
            this.lblNomeAtual.Size = new System.Drawing.Size(59, 13);
            this.lblNomeAtual.TabIndex = 1;
            this.lblNomeAtual.Text = "funcionário";
            // 
            // imgFuncSele
            // 
            this.imgFuncSele.Image = global::infoGym.Properties.Resources._1441_128x128;
            this.imgFuncSele.Location = new System.Drawing.Point(89, 19);
            this.imgFuncSele.Name = "imgFuncSele";
            this.imgFuncSele.Size = new System.Drawing.Size(150, 150);
            this.imgFuncSele.TabIndex = 0;
            this.imgFuncSele.TabStop = false;
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.pictureBox1);
            this.Informações.Controls.Add(this.lblExternos);
            this.Informações.Controls.Add(this.lblInternos);
            this.Informações.Controls.Add(this.label7);
            this.Informações.Controls.Add(this.label8);
            this.Informações.Controls.Add(this.lblInativos);
            this.Informações.Controls.Add(this.lblAtivos);
            this.Informações.Controls.Add(this.label5);
            this.Informações.Controls.Add(this.label4);
            this.Informações.Controls.Add(this.lblTotFunc);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(592, 37);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(336, 137);
            this.Informações.TabIndex = 20;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::infoGym.Properties.Resources.imageres_dll_I00b2_0409;
            this.pictureBox1.Location = new System.Drawing.Point(230, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblExternos
            // 
            this.lblExternos.AutoSize = true;
            this.lblExternos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblExternos.Location = new System.Drawing.Point(186, 87);
            this.lblExternos.Name = "lblExternos";
            this.lblExternos.Size = new System.Drawing.Size(35, 13);
            this.lblExternos.TabIndex = 9;
            this.lblExternos.Text = "label4";
            // 
            // lblInternos
            // 
            this.lblInternos.AutoSize = true;
            this.lblInternos.ForeColor = System.Drawing.Color.Blue;
            this.lblInternos.Location = new System.Drawing.Point(51, 87);
            this.lblInternos.Name = "lblInternos";
            this.lblInternos.Size = new System.Drawing.Size(35, 13);
            this.lblInternos.TabIndex = 8;
            this.lblInternos.Text = "label4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Externos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Internos:";
            // 
            // lblInativos
            // 
            this.lblInativos.AutoSize = true;
            this.lblInativos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblInativos.Location = new System.Drawing.Point(186, 52);
            this.lblInativos.Name = "lblInativos";
            this.lblInativos.Size = new System.Drawing.Size(35, 13);
            this.lblInativos.TabIndex = 5;
            this.lblInativos.Text = "label4";
            // 
            // lblAtivos
            // 
            this.lblAtivos.AutoSize = true;
            this.lblAtivos.ForeColor = System.Drawing.Color.Blue;
            this.lblAtivos.Location = new System.Drawing.Point(42, 52);
            this.lblAtivos.Name = "lblAtivos";
            this.lblAtivos.Size = new System.Drawing.Size(35, 13);
            this.lblAtivos.TabIndex = 4;
            this.lblAtivos.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Inativos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ativos:";
            // 
            // lblTotFunc
            // 
            this.lblTotFunc.AutoSize = true;
            this.lblTotFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotFunc.ForeColor = System.Drawing.Color.Red;
            this.lblTotFunc.Location = new System.Drawing.Point(111, 23);
            this.lblTotFunc.Name = "lblTotFunc";
            this.lblTotFunc.Size = new System.Drawing.Size(41, 13);
            this.lblTotFunc.TabIndex = 1;
            this.lblTotFunc.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de funcionários:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAtivos);
            this.groupBox1.Controls.Add(this.gpbCategoria);
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 140);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // chkAtivos
            // 
            this.chkAtivos.AutoSize = true;
            this.chkAtivos.Location = new System.Drawing.Point(282, 51);
            this.chkAtivos.Name = "chkAtivos";
            this.chkAtivos.Size = new System.Drawing.Size(94, 17);
            this.chkAtivos.TabIndex = 10;
            this.chkAtivos.Text = "Apenas Ativos";
            this.chkAtivos.UseVisualStyleBackColor = true;
            this.chkAtivos.CheckStateChanged += new System.EventHandler(this.chkAtivos_CheckStateChanged);
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.rbAmbos);
            this.gpbCategoria.Controls.Add(this.rbExterno);
            this.gpbCategoria.Controls.Add(this.rbInterno);
            this.gpbCategoria.Location = new System.Drawing.Point(9, 45);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(257, 78);
            this.gpbCategoria.TabIndex = 9;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(161, 41);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 11;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            this.rbAmbos.CheckedChanged += new System.EventHandler(this.rbInterno_CheckedChanged);
            // 
            // rbExterno
            // 
            this.rbExterno.AutoSize = true;
            this.rbExterno.Location = new System.Drawing.Point(85, 41);
            this.rbExterno.Name = "rbExterno";
            this.rbExterno.Size = new System.Drawing.Size(61, 17);
            this.rbExterno.TabIndex = 10;
            this.rbExterno.TabStop = true;
            this.rbExterno.Text = "Externo";
            this.rbExterno.UseVisualStyleBackColor = true;
            this.rbExterno.CheckedChanged += new System.EventHandler(this.rbInterno_CheckedChanged);
            // 
            // rbInterno
            // 
            this.rbInterno.AutoSize = true;
            this.rbInterno.Location = new System.Drawing.Point(12, 41);
            this.rbInterno.Name = "rbInterno";
            this.rbInterno.Size = new System.Drawing.Size(58, 17);
            this.rbInterno.TabIndex = 9;
            this.rbInterno.TabStop = true;
            this.rbInterno.Text = "Interno";
            this.rbInterno.UseVisualStyleBackColor = true;
            this.rbInterno.CheckedChanged += new System.EventHandler(this.rbInterno_CheckedChanged);
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(46, 19);
            this.ttbNome.MaxLength = 60;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(220, 20);
            this.ttbNome.TabIndex = 5;
            this.ttbNome.TextChanged += new System.EventHandler(this.ttbNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // dtgvFunc
            // 
            this.dtgvFunc.AllowUserToAddRows = false;
            this.dtgvFunc.AllowUserToDeleteRows = false;
            this.dtgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.func_nome,
            this.categoria,
            this.status});
            this.dtgvFunc.Location = new System.Drawing.Point(12, 191);
            this.dtgvFunc.Name = "dtgvFunc";
            this.dtgvFunc.ReadOnly = true;
            this.dtgvFunc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvFunc.Size = new System.Drawing.Size(513, 338);
            this.dtgvFunc.TabIndex = 17;
            this.dtgvFunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFunc_CellDoubleClick);
            this.dtgvFunc.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvFunc_RowsRemoved);
            this.dtgvFunc.SelectionChanged += new System.EventHandler(this.dtgvFunc_SelectionChanged);
            // 
            // func_nome
            // 
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Nome";
            this.func_nome.MinimumWidth = 300;
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
            this.func_nome.Width = 300;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 70;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 70;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(813, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(683, 446);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(554, 446);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 18;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmFuncGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 548);
            this.Controls.Add(this.gpbAlunoSelecionado);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgvFunc);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 586);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 586);
            this.Name = "frmFuncGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Funcionários";
            this.gpbAlunoSelecionado.ResumeLayout(false);
            this.gpbAlunoSelecionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFuncSele)).EndInit();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbCategoria.ResumeLayout(false);
            this.gpbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAlunoSelecionado;
        private System.Windows.Forms.Label lblNomeAtual;
        private System.Windows.Forms.PictureBox imgFuncSele;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Label lblInativos;
        private System.Windows.Forms.Label lblAtivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbExterno;
        private System.Windows.Forms.RadioButton rbInterno;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgvFunc;
        private System.Windows.Forms.Label lblExternos;
        private System.Windows.Forms.Label lblInternos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAtivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}