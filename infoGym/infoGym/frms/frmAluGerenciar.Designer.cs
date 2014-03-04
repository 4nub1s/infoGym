namespace infoGym
{
    partial class frmAluGerenciamento
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
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvAlunos = new System.Windows.Forms.DataGridView();
            this.alu_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHomens = new System.Windows.Forms.Label();
            this.lblMulheres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotAlu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbAlunoSelecionado = new System.Windows.Forms.GroupBox();
            this.lblNomeAtual = new System.Windows.Forms.Label();
            this.imgAluSele = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlunos)).BeginInit();
            this.Informações.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbAlunoSelecionado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAluSele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAmbos);
            this.groupBox2.Controls.Add(this.rbFem);
            this.groupBox2.Controls.Add(this.rbMasc);
            this.groupBox2.Location = new System.Drawing.Point(9, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Location = new System.Drawing.Point(168, 41);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 11;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            this.rbAmbos.CheckedChanged += new System.EventHandler(this.rbMasc_CheckedChanged);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(94, 41);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(67, 17);
            this.rbFem.TabIndex = 10;
            this.rbFem.TabStop = true;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            this.rbFem.CheckedChanged += new System.EventHandler(this.rbMasc_CheckedChanged);
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(12, 41);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(73, 17);
            this.rbMasc.TabIndex = 9;
            this.rbMasc.TabStop = true;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            this.rbMasc.CheckedChanged += new System.EventHandler(this.rbMasc_CheckedChanged);
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
            // dtgvAlunos
            // 
            this.dtgvAlunos.AllowUserToAddRows = false;
            this.dtgvAlunos.AllowUserToDeleteRows = false;
            this.dtgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alu_nome});
            this.dtgvAlunos.Location = new System.Drawing.Point(12, 169);
            this.dtgvAlunos.Name = "dtgvAlunos";
            this.dtgvAlunos.ReadOnly = true;
            this.dtgvAlunos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvAlunos.Size = new System.Drawing.Size(343, 338);
            this.dtgvAlunos.TabIndex = 9;
            this.dtgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAlunos_CellDoubleClick);
            this.dtgvAlunos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvAlunos_RowsRemoved);
            this.dtgvAlunos.SelectionChanged += new System.EventHandler(this.dtgvAlunos_SelectionChanged);
            // 
            // alu_nome
            // 
            this.alu_nome.DataPropertyName = "alu_nome";
            this.alu_nome.HeaderText = "Nome";
            this.alu_nome.MinimumWidth = 300;
            this.alu_nome.Name = "alu_nome";
            this.alu_nome.ReadOnly = true;
            this.alu_nome.Width = 300;
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.pictureBox1);
            this.Informações.Controls.Add(this.lblHomens);
            this.Informações.Controls.Add(this.lblMulheres);
            this.Informações.Controls.Add(this.label5);
            this.Informações.Controls.Add(this.label4);
            this.Informações.Controls.Add(this.lblTotAlu);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(436, 15);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(336, 137);
            this.Informações.TabIndex = 13;
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
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblHomens
            // 
            this.lblHomens.AutoSize = true;
            this.lblHomens.ForeColor = System.Drawing.Color.Blue;
            this.lblHomens.Location = new System.Drawing.Point(54, 83);
            this.lblHomens.Name = "lblHomens";
            this.lblHomens.Size = new System.Drawing.Size(35, 13);
            this.lblHomens.TabIndex = 5;
            this.lblHomens.Text = "label4";
            // 
            // lblMulheres
            // 
            this.lblMulheres.AutoSize = true;
            this.lblMulheres.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblMulheres.Location = new System.Drawing.Point(54, 52);
            this.lblMulheres.Name = "lblMulheres";
            this.lblMulheres.Size = new System.Drawing.Size(35, 13);
            this.lblMulheres.TabIndex = 4;
            this.lblMulheres.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Homens:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mulheres:";
            // 
            // lblTotAlu
            // 
            this.lblTotAlu.AutoSize = true;
            this.lblTotAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAlu.ForeColor = System.Drawing.Color.Red;
            this.lblTotAlu.Location = new System.Drawing.Point(86, 23);
            this.lblTotAlu.Name = "lblTotAlu";
            this.lblTotAlu.Size = new System.Drawing.Size(41, 13);
            this.lblTotAlu.TabIndex = 1;
            this.lblTotAlu.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de alunos:";
            // 
            // gpbAlunoSelecionado
            // 
            this.gpbAlunoSelecionado.Controls.Add(this.lblNomeAtual);
            this.gpbAlunoSelecionado.Controls.Add(this.imgAluSele);
            this.gpbAlunoSelecionado.Location = new System.Drawing.Point(436, 175);
            this.gpbAlunoSelecionado.Name = "gpbAlunoSelecionado";
            this.gpbAlunoSelecionado.Size = new System.Drawing.Size(336, 205);
            this.gpbAlunoSelecionado.TabIndex = 16;
            this.gpbAlunoSelecionado.TabStop = false;
            this.gpbAlunoSelecionado.Text = "Aluno Selecionado";
            // 
            // lblNomeAtual
            // 
            this.lblNomeAtual.AutoSize = true;
            this.lblNomeAtual.ForeColor = System.Drawing.Color.Blue;
            this.lblNomeAtual.Location = new System.Drawing.Point(88, 172);
            this.lblNomeAtual.Name = "lblNomeAtual";
            this.lblNomeAtual.Size = new System.Drawing.Size(33, 13);
            this.lblNomeAtual.TabIndex = 1;
            this.lblNomeAtual.Text = "aluno";
            // 
            // imgAluSele
            // 
            this.imgAluSele.Image = global::infoGym.Properties.Resources._1441_128x128;
            this.imgAluSele.Location = new System.Drawing.Point(89, 19);
            this.imgAluSele.Name = "imgAluSele";
            this.imgAluSele.Size = new System.Drawing.Size(150, 150);
            this.imgAluSele.TabIndex = 0;
            this.imgAluSele.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(657, 424);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(512, 424);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(376, 424);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecionar.Location = new System.Drawing.Point(12, 155);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(297, 13);
            this.lblSelecionar.TabIndex = 17;
            this.lblSelecionar.Text = "Dê um duplo clique no aluno que deseja selecionar";
            // 
            // frmAluGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 513);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.gpbAlunoSelecionado);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgvAlunos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 551);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(823, 551);
            this.Name = "frmAluGerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Alunos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAluGerenciamento_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAlunos)).EndInit();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbAlunoSelecionado.ResumeLayout(false);
            this.gpbAlunoSelecionado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAluSele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgvAlunos;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Label lblHomens;
        private System.Windows.Forms.Label lblMulheres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotAlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbAlunoSelecionado;
        private System.Windows.Forms.Label lblNomeAtual;
        private System.Windows.Forms.PictureBox imgAluSele;
        private System.Windows.Forms.DataGridViewTextBoxColumn alu_nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelecionar;
    }
}