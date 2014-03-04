namespace infoGym
{
    partial class frmTermoControlar
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
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvTermos = new System.Windows.Forms.DataGridView();
            this.alu_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTermos)).BeginInit();
            this.SuspendLayout();
            // 
            // ttbAluno
            // 
            this.ttbAluno.Location = new System.Drawing.Point(109, 22);
            this.ttbAluno.MaxLength = 100;
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(365, 20);
            this.ttbAluno.TabIndex = 0;
            this.ttbAluno.TextChanged += new System.EventHandler(this.ttbAluno_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aluno";
            // 
            // dtgvTermos
            // 
            this.dtgvTermos.AllowUserToAddRows = false;
            this.dtgvTermos.AllowUserToDeleteRows = false;
            this.dtgvTermos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTermos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alu_nome});
            this.dtgvTermos.Location = new System.Drawing.Point(78, 60);
            this.dtgvTermos.Name = "dtgvTermos";
            this.dtgvTermos.ReadOnly = true;
            this.dtgvTermos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvTermos.Size = new System.Drawing.Size(396, 357);
            this.dtgvTermos.TabIndex = 2;
            this.dtgvTermos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvTermos_RowsRemoved);
            this.dtgvTermos.SelectionChanged += new System.EventHandler(this.dtgvTermos_SelectionChanged);
            // 
            // alu_nome
            // 
            this.alu_nome.DataPropertyName = "alu_nome";
            this.alu_nome.HeaderText = "Aluno";
            this.alu_nome.Name = "alu_nome";
            this.alu_nome.ReadOnly = true;
            this.alu_nome.Width = 400;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(359, 433);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 83);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(214, 433);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 83);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(78, 433);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 83);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmTermoControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 540);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgvTermos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbAluno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 578);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 578);
            this.Name = "frmTermoControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Termos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTermos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTermos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn alu_nome;

    }
}