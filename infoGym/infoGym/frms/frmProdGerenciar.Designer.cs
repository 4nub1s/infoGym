namespace infoGym
{
    partial class frmProdGerenciar
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
            this.dtgvProd = new System.Windows.Forms.DataGridView();
            this.prod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estatual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_estmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotProd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblDuploClique = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvProd
            // 
            this.dtgvProd.AllowUserToAddRows = false;
            this.dtgvProd.AllowUserToDeleteRows = false;
            this.dtgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prod_desc,
            this.prod_estatual,
            this.prod_estmin,
            this.a,
            this.b,
            this.c});
            this.dtgvProd.Location = new System.Drawing.Point(47, 169);
            this.dtgvProd.Name = "dtgvProd";
            this.dtgvProd.ReadOnly = true;
            this.dtgvProd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvProd.Size = new System.Drawing.Size(443, 250);
            this.dtgvProd.TabIndex = 30;
            this.dtgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProd_CellDoubleClick);
            this.dtgvProd.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvProd_RowsRemoved);
            this.dtgvProd.SelectionChanged += new System.EventHandler(this.dtgvProd_SelectionChanged);
            // 
            // prod_desc
            // 
            this.prod_desc.DataPropertyName = "prod_desc";
            this.prod_desc.HeaderText = "Nome/ Descrição";
            this.prod_desc.MinimumWidth = 300;
            this.prod_desc.Name = "prod_desc";
            this.prod_desc.ReadOnly = true;
            this.prod_desc.Width = 300;
            // 
            // prod_estatual
            // 
            this.prod_estatual.DataPropertyName = "prod_estatual";
            this.prod_estatual.HeaderText = "Estoque Atual";
            this.prod_estatual.Name = "prod_estatual";
            this.prod_estatual.ReadOnly = true;
            this.prod_estatual.Width = 50;
            // 
            // prod_estmin
            // 
            this.prod_estmin.DataPropertyName = "prod_estmin";
            this.prod_estmin.HeaderText = "Estoque Mínimo";
            this.prod_estmin.Name = "prod_estmin";
            this.prod_estmin.ReadOnly = true;
            this.prod_estmin.Width = 50;
            // 
            // a
            // 
            this.a.DataPropertyName = "prod_id";
            this.a.HeaderText = "Column1";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Visible = false;
            // 
            // b
            // 
            this.b.DataPropertyName = "forn_id";
            this.b.HeaderText = "Column1";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Visible = false;
            // 
            // c
            // 
            this.c.DataPropertyName = "prod_valor";
            this.c.HeaderText = "Column1";
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Visible = false;
            // 
            // lblTotProd
            // 
            this.lblTotProd.AutoSize = true;
            this.lblTotProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotProd.ForeColor = System.Drawing.Color.Red;
            this.lblTotProd.Location = new System.Drawing.Point(96, 23);
            this.lblTotProd.Name = "lblTotProd";
            this.lblTotProd.Size = new System.Drawing.Size(21, 13);
            this.lblTotProd.TabIndex = 1;
            this.lblTotProd.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de produtos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 68);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(106, 16);
            this.ttbNome.MaxLength = 100;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(270, 20);
            this.ttbNome.TabIndex = 5;
            this.ttbNome.TextChanged += new System.EventHandler(this.ttbNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome/ Descrição";
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.lblTotProd);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(391, 12);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(130, 68);
            this.Informações.TabIndex = 33;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(211, 425);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(375, 425);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 35;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(47, 425);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblDuploClique
            // 
            this.lblDuploClique.AutoSize = true;
            this.lblDuploClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuploClique.Location = new System.Drawing.Point(44, 153);
            this.lblDuploClique.Name = "lblDuploClique";
            this.lblDuploClique.Size = new System.Drawing.Size(289, 13);
            this.lblDuploClique.TabIndex = 36;
            this.lblDuploClique.Text = "Dê um duplo clique no item que deseja selecionar";
            this.lblDuploClique.Visible = false;
            // 
            // frmProdGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 511);
            this.Controls.Add(this.lblDuploClique);
            this.Controls.Add(this.dtgvProd);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 549);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 549);
            this.Name = "frmProdGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotProd;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estatual;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_estmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.Label lblDuploClique;
    }
}