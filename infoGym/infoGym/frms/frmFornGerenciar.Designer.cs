namespace infoGym
{
    partial class frmFornGerenciar
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
            this.dtgvForn = new System.Windows.Forms.DataGridView();
            this.forn_razaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oculta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forn_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblTotForn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblSelecionar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvForn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvForn
            // 
            this.dtgvForn.AllowUserToAddRows = false;
            this.dtgvForn.AllowUserToDeleteRows = false;
            this.dtgvForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvForn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.forn_razaosocial,
            this.oculta,
            this.forn_id});
            this.dtgvForn.Location = new System.Drawing.Point(12, 169);
            this.dtgvForn.Name = "dtgvForn";
            this.dtgvForn.ReadOnly = true;
            this.dtgvForn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvForn.Size = new System.Drawing.Size(345, 338);
            this.dtgvForn.TabIndex = 24;
            this.dtgvForn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvForn_CellDoubleClick);
            this.dtgvForn.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvForn_RowsRemoved);
            this.dtgvForn.SelectionChanged += new System.EventHandler(this.dtgvForn_SelectionChanged);
            // 
            // forn_razaosocial
            // 
            this.forn_razaosocial.DataPropertyName = "forn_razaosocial";
            this.forn_razaosocial.HeaderText = "Nome";
            this.forn_razaosocial.MinimumWidth = 300;
            this.forn_razaosocial.Name = "forn_razaosocial";
            this.forn_razaosocial.ReadOnly = true;
            this.forn_razaosocial.Width = 300;
            // 
            // oculta
            // 
            this.oculta.DataPropertyName = "forn_cnpj";
            this.oculta.HeaderText = "oculta";
            this.oculta.Name = "oculta";
            this.oculta.ReadOnly = true;
            this.oculta.Visible = false;
            // 
            // forn_id
            // 
            this.forn_id.DataPropertyName = "forn_id";
            this.forn_id.HeaderText = "oculta2";
            this.forn_id.Name = "forn_id";
            this.forn_id.ReadOnly = true;
            this.forn_id.Visible = false;
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
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(701, 420);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(580, 420);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblTotForn
            // 
            this.lblTotForn.AutoSize = true;
            this.lblTotForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotForn.ForeColor = System.Drawing.Color.Red;
            this.lblTotForn.Location = new System.Drawing.Point(118, 22);
            this.lblTotForn.Name = "lblTotForn";
            this.lblTotForn.Size = new System.Drawing.Size(21, 13);
            this.lblTotForn.TabIndex = 1;
            this.lblTotForn.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 68);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.lblTotForn);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(459, 12);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(357, 68);
            this.Informações.TabIndex = 27;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de fornecedores:";
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(459, 420);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.CausesValidation = false;
            this.lblSelecionar.ForeColor = System.Drawing.Color.Red;
            this.lblSelecionar.Location = new System.Drawing.Point(9, 153);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(273, 13);
            this.lblSelecionar.TabIndex = 30;
            this.lblSelecionar.Text = "Dê um duplo clique no fornecedor que deseja selecionar";
            this.lblSelecionar.Visible = false;
            // 
            // frmFornGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 515);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.dtgvForn);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(848, 553);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 553);
            this.Name = "frmFornGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvForn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvForn;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotForn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_razaosocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn oculta;
        private System.Windows.Forms.DataGridViewTextBoxColumn forn_id;

    }
}