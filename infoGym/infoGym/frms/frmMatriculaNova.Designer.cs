namespace infoGym
{
    partial class frmMatriculaNova
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatriculaNova));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.btnAluBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModValorDiario = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblModValor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModBuscar = new System.Windows.Forms.Button();
            this.ttbModalidade = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEncerrada = new System.Windows.Forms.Label();
            this.chkEncerrar = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbObs = new System.Windows.Forms.RichTextBox();
            this.gpbPagamento = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbTolerancia = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbDtVcmto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbCreditos = new System.Windows.Forms.GroupBox();
            this.ttbQtdeDias = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDtIni = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMensalista = new System.Windows.Forms.RadioButton();
            this.rbDiarista = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imagem = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbTolerancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttbDtVcmto)).BeginInit();
            this.gpbCreditos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbQtdeDias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserOn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 21);
            this.panel1.TabIndex = 0;
            // 
            // lblUserOn
            // 
            this.lblUserOn.AutoSize = true;
            this.lblUserOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOn.Location = new System.Drawing.Point(83, 4);
            this.lblUserOn.Name = "lblUserOn";
            this.lblUserOn.Size = new System.Drawing.Size(19, 13);
            this.lblUserOn.TabIndex = 1;
            this.lblUserOn.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logado como:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aluno";
            // 
            // ttbAluno
            // 
            this.ttbAluno.Enabled = false;
            this.ttbAluno.Location = new System.Drawing.Point(43, 16);
            this.ttbAluno.MaxLength = 100;
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(205, 20);
            this.ttbAluno.TabIndex = 2;
            this.ttbAluno.TextChanged += new System.EventHandler(this.ttbAluno_TextChanged);
            // 
            // btnAluBuscar
            // 
            this.btnAluBuscar.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnAluBuscar.Location = new System.Drawing.Point(252, 16);
            this.btnAluBuscar.Name = "btnAluBuscar";
            this.btnAluBuscar.Size = new System.Drawing.Size(45, 20);
            this.btnAluBuscar.TabIndex = 3;
            this.btnAluBuscar.UseVisualStyleBackColor = true;
            this.btnAluBuscar.Click += new System.EventHandler(this.btnAluBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModValorDiario);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblModValor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnModBuscar);
            this.groupBox1.Controls.Add(this.ttbModalidade);
            this.groupBox1.Location = new System.Drawing.Point(350, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidade";
            // 
            // lblModValorDiario
            // 
            this.lblModValorDiario.AutoSize = true;
            this.lblModValorDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModValorDiario.Location = new System.Drawing.Point(74, 73);
            this.lblModValorDiario.Name = "lblModValorDiario";
            this.lblModValorDiario.Size = new System.Drawing.Size(19, 13);
            this.lblModValorDiario.TabIndex = 9;
            this.lblModValorDiario.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Valor Diário:";
            // 
            // lblModValor
            // 
            this.lblModValor.AutoSize = true;
            this.lblModValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModValor.Location = new System.Drawing.Point(74, 51);
            this.lblModValor.Name = "lblModValor";
            this.lblModValor.Size = new System.Drawing.Size(19, 13);
            this.lblModValor.TabIndex = 7;
            this.lblModValor.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Mensal:";
            // 
            // btnModBuscar
            // 
            this.btnModBuscar.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnModBuscar.Location = new System.Drawing.Point(236, 18);
            this.btnModBuscar.Name = "btnModBuscar";
            this.btnModBuscar.Size = new System.Drawing.Size(45, 20);
            this.btnModBuscar.TabIndex = 5;
            this.btnModBuscar.UseVisualStyleBackColor = true;
            this.btnModBuscar.Click += new System.EventHandler(this.btnModBuscar_Click);
            // 
            // ttbModalidade
            // 
            this.ttbModalidade.Enabled = false;
            this.ttbModalidade.Location = new System.Drawing.Point(6, 19);
            this.ttbModalidade.Name = "ttbModalidade";
            this.ttbModalidade.Size = new System.Drawing.Size(225, 20);
            this.ttbModalidade.TabIndex = 0;
            this.ttbModalidade.TextChanged += new System.EventHandler(this.ttbAluno_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEncerrada);
            this.groupBox2.Controls.Add(this.chkEncerrar);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ttbObs);
            this.groupBox2.Controls.Add(this.gpbPagamento);
            this.groupBox2.Controls.Add(this.gpbCreditos);
            this.groupBox2.Controls.Add(this.lblDtIni);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(15, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 329);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrícula";
            // 
            // lblEncerrada
            // 
            this.lblEncerrada.AutoSize = true;
            this.lblEncerrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncerrada.ForeColor = System.Drawing.Color.Red;
            this.lblEncerrada.Location = new System.Drawing.Point(19, 21);
            this.lblEncerrada.Name = "lblEncerrada";
            this.lblEncerrada.Size = new System.Drawing.Size(19, 13);
            this.lblEncerrada.TabIndex = 8;
            this.lblEncerrada.Text = "---";
            this.lblEncerrada.Visible = false;
            // 
            // chkEncerrar
            // 
            this.chkEncerrar.AutoSize = true;
            this.chkEncerrar.Location = new System.Drawing.Point(397, 238);
            this.chkEncerrar.Name = "chkEncerrar";
            this.chkEncerrar.Size = new System.Drawing.Size(113, 17);
            this.chkEncerrar.TabIndex = 9;
            this.chkEncerrar.Text = "Encerrar matrícula";
            this.chkEncerrar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Observações";
            // 
            // ttbObs
            // 
            this.ttbObs.Location = new System.Drawing.Point(20, 238);
            this.ttbObs.MaxLength = 100;
            this.ttbObs.Name = "ttbObs";
            this.ttbObs.Size = new System.Drawing.Size(351, 73);
            this.ttbObs.TabIndex = 7;
            this.ttbObs.Text = "";
            // 
            // gpbPagamento
            // 
            this.gpbPagamento.Controls.Add(this.label10);
            this.gpbPagamento.Controls.Add(this.label9);
            this.gpbPagamento.Controls.Add(this.label8);
            this.gpbPagamento.Controls.Add(this.ttbTolerancia);
            this.gpbPagamento.Controls.Add(this.label7);
            this.gpbPagamento.Controls.Add(this.ttbDtVcmto);
            this.gpbPagamento.Controls.Add(this.label6);
            this.gpbPagamento.Location = new System.Drawing.Point(237, 49);
            this.gpbPagamento.Name = "gpbPagamento";
            this.gpbPagamento.Size = new System.Drawing.Size(402, 156);
            this.gpbPagamento.TabIndex = 6;
            this.gpbPagamento.TabStop = false;
            this.gpbPagamento.Text = "Pagamento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(381, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "em débito o sistema aguardará para bloquear o acesso do cliente.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tolerância significa que mesmo estando";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "dias";
            // 
            // ttbTolerancia
            // 
            this.ttbTolerancia.Location = new System.Drawing.Point(88, 65);
            this.ttbTolerancia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ttbTolerancia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ttbTolerancia.Name = "ttbTolerancia";
            this.ttbTolerancia.Size = new System.Drawing.Size(49, 20);
            this.ttbTolerancia.TabIndex = 3;
            this.ttbTolerancia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tolerância";
            // 
            // ttbDtVcmto
            // 
            this.ttbDtVcmto.Location = new System.Drawing.Point(88, 32);
            this.ttbDtVcmto.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.ttbDtVcmto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ttbDtVcmto.Name = "ttbDtVcmto";
            this.ttbDtVcmto.Size = new System.Drawing.Size(49, 20);
            this.ttbDtVcmto.TabIndex = 1;
            this.ttbDtVcmto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dia vencimento";
            // 
            // gpbCreditos
            // 
            this.gpbCreditos.Controls.Add(this.ttbQtdeDias);
            this.gpbCreditos.Controls.Add(this.label5);
            this.gpbCreditos.Location = new System.Drawing.Point(19, 135);
            this.gpbCreditos.Name = "gpbCreditos";
            this.gpbCreditos.Size = new System.Drawing.Size(200, 70);
            this.gpbCreditos.TabIndex = 5;
            this.gpbCreditos.TabStop = false;
            this.gpbCreditos.Text = "Créditos";
            // 
            // ttbQtdeDias
            // 
            this.ttbQtdeDias.Location = new System.Drawing.Point(11, 25);
            this.ttbQtdeDias.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ttbQtdeDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ttbQtdeDias.Name = "ttbQtdeDias";
            this.ttbQtdeDias.Size = new System.Drawing.Size(49, 20);
            this.ttbQtdeDias.TabIndex = 1;
            this.ttbQtdeDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "dias de acesso";
            // 
            // lblDtIni
            // 
            this.lblDtIni.AutoSize = true;
            this.lblDtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtIni.Location = new System.Drawing.Point(544, 22);
            this.lblDtIni.Name = "lblDtIni";
            this.lblDtIni.Size = new System.Drawing.Size(19, 13);
            this.lblDtIni.TabIndex = 4;
            this.lblDtIni.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data início:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMensalista);
            this.groupBox3.Controls.Add(this.rbDiarista);
            this.groupBox3.Location = new System.Drawing.Point(19, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 66);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rbMensalista
            // 
            this.rbMensalista.AutoSize = true;
            this.rbMensalista.Location = new System.Drawing.Point(96, 19);
            this.rbMensalista.Name = "rbMensalista";
            this.rbMensalista.Size = new System.Drawing.Size(75, 17);
            this.rbMensalista.TabIndex = 2;
            this.rbMensalista.TabStop = true;
            this.rbMensalista.Text = "Mensalista";
            this.rbMensalista.UseVisualStyleBackColor = true;
            this.rbMensalista.CheckedChanged += new System.EventHandler(this.rbDiarista_CheckedChanged);
            // 
            // rbDiarista
            // 
            this.rbDiarista.AutoSize = true;
            this.rbDiarista.Location = new System.Drawing.Point(21, 19);
            this.rbDiarista.Name = "rbDiarista";
            this.rbDiarista.Size = new System.Drawing.Size(60, 17);
            this.rbDiarista.TabIndex = 1;
            this.rbDiarista.TabStop = true;
            this.rbDiarista.Text = "Diarista";
            this.rbDiarista.UseVisualStyleBackColor = true;
            this.rbDiarista.CheckedChanged += new System.EventHandler(this.rbDiarista_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(666, 369);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 91);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add_48x48.png");
            this.imageList1.Images.SetKeyName(1, "refresh_48x48.png");
            // 
            // imagem
            // 
            this.imagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imagem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.imagem.Image = global::infoGym.Properties.Resources._1441_128x128;
            this.imagem.Location = new System.Drawing.Point(666, 19);
            this.imagem.Name = "imagem";
            this.imagem.Size = new System.Drawing.Size(150, 150);
            this.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagem.TabIndex = 7;
            this.imagem.TabStop = false;
            // 
            // frmMatriculaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 502);
            this.Controls.Add(this.imagem);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAluBuscar);
            this.Controls.Add(this.ttbAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(836, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(836, 540);
            this.Name = "frmMatriculaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar matrícula";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbPagamento.ResumeLayout(false);
            this.gpbPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbTolerancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttbDtVcmto)).EndInit();
            this.gpbCreditos.ResumeLayout(false);
            this.gpbCreditos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbQtdeDias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.Button btnAluBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModBuscar;
        private System.Windows.Forms.TextBox ttbModalidade;
        private System.Windows.Forms.Label lblModValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMensalista;
        private System.Windows.Forms.RadioButton rbDiarista;
        private System.Windows.Forms.Label lblDtIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbCreditos;
        private System.Windows.Forms.NumericUpDown ttbQtdeDias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbPagamento;
        private System.Windows.Forms.NumericUpDown ttbDtVcmto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ttbTolerancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ttbObs;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblModValorDiario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkEncerrar;
        private System.Windows.Forms.PictureBox imagem;
        private System.Windows.Forms.Label lblEncerrada;
    }
}