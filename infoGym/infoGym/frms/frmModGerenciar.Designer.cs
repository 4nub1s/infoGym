namespace infoGym.frms
{
    partial class frmModGerenciar
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
            this.dtgvMod = new System.Windows.Forms.DataGridView();
            this.mod_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod_valord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod_valorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotMod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lblSelModalidade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMod)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMod
            // 
            this.dtgvMod.AllowUserToAddRows = false;
            this.dtgvMod.AllowUserToDeleteRows = false;
            this.dtgvMod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mod_desc,
            this.mod_id,
            this.mod_valord,
            this.mod_valorm});
            this.dtgvMod.Location = new System.Drawing.Point(58, 169);
            this.dtgvMod.Name = "dtgvMod";
            this.dtgvMod.ReadOnly = true;
            this.dtgvMod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMod.Size = new System.Drawing.Size(442, 250);
            this.dtgvMod.TabIndex = 42;
            this.dtgvMod.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMod_CellDoubleClick);
            this.dtgvMod.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvMod_RowsRemoved);
            this.dtgvMod.SelectionChanged += new System.EventHandler(this.dtgvMod_SelectionChanged);
            // 
            // mod_desc
            // 
            this.mod_desc.DataPropertyName = "mod_desc";
            this.mod_desc.HeaderText = "Nome / Descrição";
            this.mod_desc.MinimumWidth = 300;
            this.mod_desc.Name = "mod_desc";
            this.mod_desc.ReadOnly = true;
            this.mod_desc.Width = 400;
            // 
            // mod_id
            // 
            this.mod_id.DataPropertyName = "mod_id";
            this.mod_id.HeaderText = "Column1";
            this.mod_id.Name = "mod_id";
            this.mod_id.ReadOnly = true;
            this.mod_id.Visible = false;
            // 
            // mod_valord
            // 
            this.mod_valord.DataPropertyName = "mod_valord";
            this.mod_valord.HeaderText = "Column2";
            this.mod_valord.Name = "mod_valord";
            this.mod_valord.ReadOnly = true;
            this.mod_valord.Visible = false;
            // 
            // mod_valorm
            // 
            this.mod_valorm.DataPropertyName = "mod_valorm";
            this.mod_valorm.HeaderText = "Column3";
            this.mod_valorm.Name = "mod_valorm";
            this.mod_valorm.ReadOnly = true;
            this.mod_valorm.Visible = false;
            // 
            // lblTotMod
            // 
            this.lblTotMod.AutoSize = true;
            this.lblTotMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotMod.ForeColor = System.Drawing.Color.Red;
            this.lblTotMod.Location = new System.Drawing.Point(109, 23);
            this.lblTotMod.Name = "lblTotMod";
            this.lblTotMod.Size = new System.Drawing.Size(21, 13);
            this.lblTotMod.TabIndex = 1;
            this.lblTotMod.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de modalidades:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 68);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(103, 19);
            this.ttbNome.MaxLength = 100;
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(273, 20);
            this.ttbNome.TabIndex = 5;
            this.ttbNome.TextChanged += new System.EventHandler(this.ttbNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome/ Descrição";
            // 
            // Informações
            // 
            this.Informações.Controls.Add(this.lblTotMod);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(400, 12);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(145, 68);
            this.Informações.TabIndex = 45;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(385, 425);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 47;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(222, 425);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 46;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(58, 425);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 43;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lblSelModalidade
            // 
            this.lblSelModalidade.AutoSize = true;
            this.lblSelModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelModalidade.Location = new System.Drawing.Point(55, 153);
            this.lblSelModalidade.Name = "lblSelModalidade";
            this.lblSelModalidade.Size = new System.Drawing.Size(329, 13);
            this.lblSelModalidade.TabIndex = 48;
            this.lblSelModalidade.Text = "Para selecionar uma modalidade dê um duplo clique nela";
            this.lblSelModalidade.Visible = false;
            // 
            // frmModGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 562);
            this.Controls.Add(this.lblSelModalidade);
            this.Controls.Add(this.dtgvMod);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(584, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(584, 600);
            this.Name = "frmModGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Modalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMod;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblTotMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod_valord;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod_valorm;
        private System.Windows.Forms.Label lblSelModalidade;
    }
}