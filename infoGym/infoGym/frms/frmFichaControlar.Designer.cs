namespace infoGym
{
    partial class frmFichaControlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.btnAluBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbObj = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbVencidaS = new System.Windows.Forms.RadioButton();
            this.rbVencidaN = new System.Windows.Forms.RadioButton();
            this.dtgvFichas = new System.Windows.Forms.DataGridView();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnNova = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFichas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbbObj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAluBuscar);
            this.groupBox1.Controls.Add(this.ttbAluno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno";
            // 
            // ttbAluno
            // 
            this.ttbAluno.Enabled = false;
            this.ttbAluno.Location = new System.Drawing.Point(54, 31);
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(262, 20);
            this.ttbAluno.TabIndex = 1;
            // 
            // btnAluBuscar
            // 
            this.btnAluBuscar.Location = new System.Drawing.Point(322, 29);
            this.btnAluBuscar.Name = "btnAluBuscar";
            this.btnAluBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnAluBuscar.TabIndex = 2;
            this.btnAluBuscar.Text = "...";
            this.btnAluBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Objetivo";
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
            this.cbbObj.Location = new System.Drawing.Point(54, 67);
            this.cbbObj.Name = "cbbObj";
            this.cbbObj.Size = new System.Drawing.Size(160, 21);
            this.cbbObj.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVencidaN);
            this.groupBox2.Controls.Add(this.rbVencidaS);
            this.groupBox2.Controls.Add(this.rbTodas);
            this.groupBox2.Location = new System.Drawing.Point(491, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(18, 14);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // rbVencidaS
            // 
            this.rbVencidaS.AutoSize = true;
            this.rbVencidaS.Location = new System.Drawing.Point(18, 37);
            this.rbVencidaS.Name = "rbVencidaS";
            this.rbVencidaS.Size = new System.Drawing.Size(69, 17);
            this.rbVencidaS.TabIndex = 1;
            this.rbVencidaS.TabStop = true;
            this.rbVencidaS.Text = "Vencidas";
            this.rbVencidaS.UseVisualStyleBackColor = true;
            // 
            // rbVencidaN
            // 
            this.rbVencidaN.AutoSize = true;
            this.rbVencidaN.Location = new System.Drawing.Point(18, 60);
            this.rbVencidaN.Name = "rbVencidaN";
            this.rbVencidaN.Size = new System.Drawing.Size(91, 17);
            this.rbVencidaN.TabIndex = 2;
            this.rbVencidaN.TabStop = true;
            this.rbVencidaN.Text = "Não vencidas";
            this.rbVencidaN.UseVisualStyleBackColor = true;
            // 
            // dtgvFichas
            // 
            this.dtgvFichas.AllowUserToAddRows = false;
            this.dtgvFichas.AllowUserToDeleteRows = false;
            this.dtgvFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFichas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aluno,
            this.obj,
            this.dtInicio,
            this.reav});
            this.dtgvFichas.Location = new System.Drawing.Point(12, 180);
            this.dtgvFichas.Name = "dtgvFichas";
            this.dtgvFichas.ReadOnly = true;
            this.dtgvFichas.Size = new System.Drawing.Size(646, 300);
            this.dtgvFichas.TabIndex = 1;
            // 
            // Aluno
            // 
            this.Aluno.HeaderText = "aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            this.Aluno.Width = 200;
            // 
            // obj
            // 
            this.obj.HeaderText = "Objetivo";
            this.obj.Name = "obj";
            this.obj.ReadOnly = true;
            this.obj.Width = 200;
            // 
            // dtInicio
            // 
            this.dtInicio.HeaderText = "Data Início";
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.ReadOnly = true;
            // 
            // reav
            // 
            this.reav.HeaderText = "Reavaliação";
            this.reav.Name = "reav";
            this.reav.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 486);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 64);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnNova
            // 
            this.btnNova.Location = new System.Drawing.Point(564, 486);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(94, 64);
            this.btnNova.TabIndex = 3;
            this.btnNova.Text = "Nova";
            this.btnNova.UseVisualStyleBackColor = true;
            this.btnNova.Click += new System.EventHandler(this.btnNova_Click);
            // 
            // frmFichaControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 557);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtgvFichas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 595);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 595);
            this.Name = "frmFichaControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Fichas de Treinamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFichas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAluBuscar;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbVencidaN;
        private System.Windows.Forms.RadioButton rbVencidaS;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.DataGridView dtgvFichas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn reav;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnNova;
    }
}