namespace infoGym.frms
{
    partial class frmExeGerenciar
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
            this.dtgvExe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Informações = new System.Windows.Forms.GroupBox();
            this.lblTotExe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.exe_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exe_area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvExe
            // 
            this.dtgvExe.AllowUserToAddRows = false;
            this.dtgvExe.AllowUserToDeleteRows = false;
            this.dtgvExe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exe_desc,
            this.exe_area,
            this.Column1});
            this.dtgvExe.Location = new System.Drawing.Point(53, 108);
            this.dtgvExe.Name = "dtgvExe";
            this.dtgvExe.ReadOnly = true;
            this.dtgvExe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvExe.Size = new System.Drawing.Size(495, 250);
            this.dtgvExe.TabIndex = 36;
            this.dtgvExe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvExe_RowsRemoved);
            this.dtgvExe.SelectionChanged += new System.EventHandler(this.dtgvExe_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 68);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
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
            // Informações
            // 
            this.Informações.Controls.Add(this.lblTotExe);
            this.Informações.Controls.Add(this.label3);
            this.Informações.Location = new System.Drawing.Point(424, 12);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(148, 68);
            this.Informações.TabIndex = 39;
            this.Informações.TabStop = false;
            this.Informações.Text = "Informações";
            // 
            // lblTotExe
            // 
            this.lblTotExe.AutoSize = true;
            this.lblTotExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotExe.ForeColor = System.Drawing.Color.Red;
            this.lblTotExe.Location = new System.Drawing.Point(103, 23);
            this.lblTotExe.Name = "lblTotExe";
            this.lblTotExe.Size = new System.Drawing.Size(21, 13);
            this.lblTotExe.TabIndex = 1;
            this.lblTotExe.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de exercícios:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(241, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 40;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(433, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(53, 384);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // exe_desc
            // 
            this.exe_desc.DataPropertyName = "exe_desc";
            this.exe_desc.HeaderText = "Nome";
            this.exe_desc.MinimumWidth = 300;
            this.exe_desc.Name = "exe_desc";
            this.exe_desc.ReadOnly = true;
            this.exe_desc.Width = 300;
            // 
            // exe_area
            // 
            this.exe_area.DataPropertyName = "exe_area";
            this.exe_area.HeaderText = "Área";
            this.exe_area.Name = "exe_area";
            this.exe_area.ReadOnly = true;
            this.exe_area.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "exe_id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // frmExeGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 485);
            this.Controls.Add(this.dtgvExe);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Informações);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 523);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(649, 523);
            this.Name = "frmExeGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Exercícios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Informações.ResumeLayout(false);
            this.Informações.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvExe;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Informações;
        private System.Windows.Forms.Label lblTotExe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn exe_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn exe_area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}