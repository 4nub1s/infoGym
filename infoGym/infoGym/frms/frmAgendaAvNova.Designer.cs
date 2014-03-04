namespace infoGym
{
    partial class frmAgendaAvNova
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
            this.gpbAluno = new System.Windows.Forms.GroupBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.gpbAvaliador = new System.Windows.Forms.GroupBox();
            this.btnAvaliador = new System.Windows.Forms.Button();
            this.ttbAvaliador = new System.Windows.Forms.TextBox();
            this.gpbHorario = new System.Windows.Forms.GroupBox();
            this.lblHorarioComRestricao = new System.Windows.Forms.Label();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpbAluno.SuspendLayout();
            this.gpbAvaliador.SuspendLayout();
            this.gpbHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAluno
            // 
            this.gpbAluno.Controls.Add(this.btnAluno);
            this.gpbAluno.Controls.Add(this.ttbAluno);
            this.gpbAluno.Location = new System.Drawing.Point(385, 12);
            this.gpbAluno.Name = "gpbAluno";
            this.gpbAluno.Size = new System.Drawing.Size(348, 100);
            this.gpbAluno.TabIndex = 3;
            this.gpbAluno.TabStop = false;
            this.gpbAluno.Text = "Aluno";
            // 
            // btnAluno
            // 
            this.btnAluno.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnAluno.Location = new System.Drawing.Point(268, 23);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(59, 33);
            this.btnAluno.TabIndex = 3;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // ttbAluno
            // 
            this.ttbAluno.Location = new System.Drawing.Point(6, 30);
            this.ttbAluno.MaxLength = 100;
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(245, 20);
            this.ttbAluno.TabIndex = 2;
            this.ttbAluno.Tag = "1";
            // 
            // gpbAvaliador
            // 
            this.gpbAvaliador.Controls.Add(this.btnAvaliador);
            this.gpbAvaliador.Controls.Add(this.ttbAvaliador);
            this.gpbAvaliador.Location = new System.Drawing.Point(12, 12);
            this.gpbAvaliador.Name = "gpbAvaliador";
            this.gpbAvaliador.Size = new System.Drawing.Size(346, 100);
            this.gpbAvaliador.TabIndex = 2;
            this.gpbAvaliador.TabStop = false;
            this.gpbAvaliador.Text = "Avaliador";
            // 
            // btnAvaliador
            // 
            this.btnAvaliador.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnAvaliador.Location = new System.Drawing.Point(268, 23);
            this.btnAvaliador.Name = "btnAvaliador";
            this.btnAvaliador.Size = new System.Drawing.Size(59, 33);
            this.btnAvaliador.TabIndex = 1;
            this.btnAvaliador.UseVisualStyleBackColor = true;
            this.btnAvaliador.Click += new System.EventHandler(this.btnAvaliador_Click);
            // 
            // ttbAvaliador
            // 
            this.ttbAvaliador.Location = new System.Drawing.Point(6, 30);
            this.ttbAvaliador.MaxLength = 100;
            this.ttbAvaliador.Name = "ttbAvaliador";
            this.ttbAvaliador.Size = new System.Drawing.Size(245, 20);
            this.ttbAvaliador.TabIndex = 0;
            this.ttbAvaliador.Tag = "1";
            // 
            // gpbHorario
            // 
            this.gpbHorario.Controls.Add(this.lblHorarioComRestricao);
            this.gpbHorario.Controls.Add(this.dtpHorario);
            this.gpbHorario.Controls.Add(this.label2);
            this.gpbHorario.Controls.Add(this.label1);
            this.gpbHorario.Controls.Add(this.dtpDia);
            this.gpbHorario.Location = new System.Drawing.Point(12, 134);
            this.gpbHorario.Name = "gpbHorario";
            this.gpbHorario.Size = new System.Drawing.Size(346, 100);
            this.gpbHorario.TabIndex = 4;
            this.gpbHorario.TabStop = false;
            this.gpbHorario.Text = "Horário";
            // 
            // lblHorarioComRestricao
            // 
            this.lblHorarioComRestricao.AutoSize = true;
            this.lblHorarioComRestricao.ForeColor = System.Drawing.Color.Red;
            this.lblHorarioComRestricao.Location = new System.Drawing.Point(172, 65);
            this.lblHorarioComRestricao.Name = "lblHorarioComRestricao";
            this.lblHorarioComRestricao.Size = new System.Drawing.Size(104, 13);
            this.lblHorarioComRestricao.TabIndex = 4;
            this.lblHorarioComRestricao.Text = "Horário indisponível!";
            // 
            // dtpHorario
            // 
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorario.Location = new System.Drawing.Point(49, 61);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.Size = new System.Drawing.Size(80, 20);
            this.dtpHorario.TabIndex = 3;
            this.dtpHorario.ValueChanged += new System.EventHandler(this.dtpHorario_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // dtpDia
            // 
            this.dtpDia.Location = new System.Drawing.Point(49, 24);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(227, 20);
            this.dtpDia.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::infoGym.Properties.Resources.accepted_481;
            this.btnConfirmar.Location = new System.Drawing.Point(622, 169);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 65);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmAgendaAvNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 258);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gpbHorario);
            this.Controls.Add(this.gpbAluno);
            this.Controls.Add(this.gpbAvaliador);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(758, 296);
            this.Name = "frmAgendaAvNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Avaliação";
            this.gpbAluno.ResumeLayout(false);
            this.gpbAluno.PerformLayout();
            this.gpbAvaliador.ResumeLayout(false);
            this.gpbAvaliador.PerformLayout();
            this.gpbHorario.ResumeLayout(false);
            this.gpbHorario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAluno;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.GroupBox gpbAvaliador;
        private System.Windows.Forms.Button btnAvaliador;
        private System.Windows.Forms.TextBox ttbAvaliador;
        private System.Windows.Forms.GroupBox gpbHorario;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label lblHorarioComRestricao;
        private System.Windows.Forms.Button btnConfirmar;
    }
}