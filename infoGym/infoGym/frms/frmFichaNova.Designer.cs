namespace infoGym
{
    partial class frmFichaNova
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbGeral = new System.Windows.Forms.TabPage();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbObj = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAluBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTreinos = new System.Windows.Forms.TabPage();
            this.btnTreiExcluir = new System.Windows.Forms.Button();
            this.btnTreiAtualizar = new System.Windows.Forms.Button();
            this.btnTreiAdd = new System.Windows.Forms.Button();
            this.dtgvTreinos = new System.Windows.Forms.DataGridView();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbGeral.SuspendLayout();
            this.tbTreinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbGeral);
            this.tabControl1.Controls.Add(this.tbTreinos);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tbGeral
            // 
            this.tbGeral.BackColor = System.Drawing.SystemColors.Control;
            this.tbGeral.Controls.Add(this.btnConfirmar);
            this.tbGeral.Controls.Add(this.dateTimePicker2);
            this.tbGeral.Controls.Add(this.label4);
            this.tbGeral.Controls.Add(this.cbbObj);
            this.tbGeral.Controls.Add(this.label3);
            this.tbGeral.Controls.Add(this.dateTimePicker1);
            this.tbGeral.Controls.Add(this.label2);
            this.tbGeral.Controls.Add(this.btnAluBuscar);
            this.tbGeral.Controls.Add(this.textBox1);
            this.tbGeral.Controls.Add(this.label1);
            this.tbGeral.Location = new System.Drawing.Point(4, 22);
            this.tbGeral.Name = "tbGeral";
            this.tbGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tbGeral.Size = new System.Drawing.Size(773, 534);
            this.tbGeral.TabIndex = 0;
            this.tbGeral.Text = "Geral";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(621, 433);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(133, 84);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(573, 53);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de reavaliação";
            // 
            // cbbObj
            // 
            this.cbbObj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbObj.FormattingEnabled = true;
            this.cbbObj.Items.AddRange(new object[] {
            "Condicionamento Físico",
            "Emagrecimento",
            "Hipertrofia",
            "Reabilitação"});
            this.cbbObj.Location = new System.Drawing.Point(52, 55);
            this.cbbObj.Name = "cbbObj";
            this.cbbObj.Size = new System.Drawing.Size(160, 21);
            this.cbbObj.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Objetivo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(341, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data início do treino";
            // 
            // btnAluBuscar
            // 
            this.btnAluBuscar.Location = new System.Drawing.Point(361, 16);
            this.btnAluBuscar.Name = "btnAluBuscar";
            this.btnAluBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAluBuscar.TabIndex = 2;
            this.btnAluBuscar.Text = "...";
            this.btnAluBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // tbTreinos
            // 
            this.tbTreinos.BackColor = System.Drawing.SystemColors.Control;
            this.tbTreinos.Controls.Add(this.btnTreiExcluir);
            this.tbTreinos.Controls.Add(this.btnTreiAtualizar);
            this.tbTreinos.Controls.Add(this.btnTreiAdd);
            this.tbTreinos.Controls.Add(this.dtgvTreinos);
            this.tbTreinos.Location = new System.Drawing.Point(4, 22);
            this.tbTreinos.Name = "tbTreinos";
            this.tbTreinos.Padding = new System.Windows.Forms.Padding(3);
            this.tbTreinos.Size = new System.Drawing.Size(773, 534);
            this.tbTreinos.TabIndex = 1;
            this.tbTreinos.Text = "Treinos";
            // 
            // btnTreiExcluir
            // 
            this.btnTreiExcluir.Location = new System.Drawing.Point(137, 313);
            this.btnTreiExcluir.Name = "btnTreiExcluir";
            this.btnTreiExcluir.Size = new System.Drawing.Size(104, 88);
            this.btnTreiExcluir.TabIndex = 3;
            this.btnTreiExcluir.Text = "Excluir";
            this.btnTreiExcluir.UseVisualStyleBackColor = true;
            // 
            // btnTreiAtualizar
            // 
            this.btnTreiAtualizar.Location = new System.Drawing.Point(308, 313);
            this.btnTreiAtualizar.Name = "btnTreiAtualizar";
            this.btnTreiAtualizar.Size = new System.Drawing.Size(104, 88);
            this.btnTreiAtualizar.TabIndex = 2;
            this.btnTreiAtualizar.Text = "Atualizar";
            this.btnTreiAtualizar.UseVisualStyleBackColor = true;
            this.btnTreiAtualizar.Click += new System.EventHandler(this.btnTreiAtualizar_Click);
            // 
            // btnTreiAdd
            // 
            this.btnTreiAdd.Location = new System.Drawing.Point(479, 313);
            this.btnTreiAdd.Name = "btnTreiAdd";
            this.btnTreiAdd.Size = new System.Drawing.Size(104, 88);
            this.btnTreiAdd.TabIndex = 1;
            this.btnTreiAdd.Text = "Cadastrar";
            this.btnTreiAdd.UseVisualStyleBackColor = true;
            this.btnTreiAdd.Click += new System.EventHandler(this.btnTreiAdd_Click);
            // 
            // dtgvTreinos
            // 
            this.dtgvTreinos.AllowUserToAddRows = false;
            this.dtgvTreinos.AllowUserToDeleteRows = false;
            this.dtgvTreinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTreinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desc});
            this.dtgvTreinos.Location = new System.Drawing.Point(281, 61);
            this.dtgvTreinos.Name = "dtgvTreinos";
            this.dtgvTreinos.ReadOnly = true;
            this.dtgvTreinos.Size = new System.Drawing.Size(143, 220);
            this.dtgvTreinos.TabIndex = 0;
            // 
            // desc
            // 
            this.desc.HeaderText = "Treinos";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // frmFichaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFichaNova";
            this.Text = "Nova Ficha";
            this.tabControl1.ResumeLayout(false);
            this.tbGeral.ResumeLayout(false);
            this.tbGeral.PerformLayout();
            this.tbTreinos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTreinos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbGeral;
        private System.Windows.Forms.TabPage tbTreinos;
        private System.Windows.Forms.Button btnAluBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbObj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dtgvTreinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.Button btnTreiExcluir;
        private System.Windows.Forms.Button btnTreiAtualizar;
        private System.Windows.Forms.Button btnTreiAdd;
    }
}