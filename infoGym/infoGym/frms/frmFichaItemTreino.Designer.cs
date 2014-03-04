namespace infoGym
{
    partial class frmFichaItemTreino
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
            this.dtgvItensTreino = new System.Windows.Forms.DataGridView();
            this.exe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeRepe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeTempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTreiDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItensTreino)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvItensTreino
            // 
            this.dtgvItensTreino.AllowUserToAddRows = false;
            this.dtgvItensTreino.AllowUserToDeleteRows = false;
            this.dtgvItensTreino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItensTreino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exe,
            this.qtdeRepe,
            this.qtdeCarga,
            this.qtdeSeries,
            this.qtdeTempo});
            this.dtgvItensTreino.Location = new System.Drawing.Point(38, 25);
            this.dtgvItensTreino.Name = "dtgvItensTreino";
            this.dtgvItensTreino.ReadOnly = true;
            this.dtgvItensTreino.Size = new System.Drawing.Size(662, 420);
            this.dtgvItensTreino.TabIndex = 0;
            // 
            // exe
            // 
            this.exe.HeaderText = "Exercício";
            this.exe.Name = "exe";
            this.exe.ReadOnly = true;
            this.exe.Width = 200;
            // 
            // qtdeRepe
            // 
            this.qtdeRepe.HeaderText = "Repetições";
            this.qtdeRepe.Name = "qtdeRepe";
            this.qtdeRepe.ReadOnly = true;
            // 
            // qtdeCarga
            // 
            this.qtdeCarga.HeaderText = "Carga";
            this.qtdeCarga.Name = "qtdeCarga";
            this.qtdeCarga.ReadOnly = true;
            // 
            // qtdeSeries
            // 
            this.qtdeSeries.HeaderText = "Série";
            this.qtdeSeries.Name = "qtdeSeries";
            this.qtdeSeries.ReadOnly = true;
            // 
            // qtdeTempo
            // 
            this.qtdeTempo.HeaderText = "Tempo";
            this.qtdeTempo.Name = "qtdeTempo";
            this.qtdeTempo.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Image = global::infoGym.Properties.Resources.edit_remove;
            this.button1.Location = new System.Drawing.Point(38, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 99);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAtualizar.Location = new System.Drawing.Point(302, 451);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(137, 99);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnAdd.Location = new System.Drawing.Point(563, 451);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 99);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Treino:";
            // 
            // lblTreiDesc
            // 
            this.lblTreiDesc.AutoSize = true;
            this.lblTreiDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreiDesc.Location = new System.Drawing.Point(71, 9);
            this.lblTreiDesc.Name = "lblTreiDesc";
            this.lblTreiDesc.Size = new System.Drawing.Size(15, 13);
            this.lblTreiDesc.TabIndex = 5;
            this.lblTreiDesc.Text = "A";
            // 
            // frmFichaItemTreino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblTreiDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvItensTreino);
            this.Name = "frmFichaItemTreino";
            this.Text = "Itens Treino";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItensTreino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvItensTreino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn exe;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeRepe;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTreiDesc;
    }
}