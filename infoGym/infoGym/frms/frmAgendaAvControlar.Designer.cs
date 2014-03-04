namespace infoGym
{
    partial class frmAvControlar
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
            this.gpbAvaliador = new System.Windows.Forms.GroupBox();
            this.chkAllAvaliadores = new System.Windows.Forms.CheckBox();
            this.btnAvaliador = new System.Windows.Forms.Button();
            this.ttbAvaliador = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.rbAtraso = new System.Windows.Forms.RadioButton();
            this.rbRealizadas = new System.Windows.Forms.RadioButton();
            this.rbNRealizadas = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chAllAluno = new System.Windows.Forms.CheckBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblNaoRealizadas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEmAtraso = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvAva = new System.Windows.Forms.DataGridView();
            this.ava_dtagend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava_dtrealiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.func_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alu_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAvaliacao = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gpbAvaliador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAva)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAvaliador
            // 
            this.gpbAvaliador.Controls.Add(this.chkAllAvaliadores);
            this.gpbAvaliador.Controls.Add(this.btnAvaliador);
            this.gpbAvaliador.Controls.Add(this.ttbAvaliador);
            this.gpbAvaliador.Location = new System.Drawing.Point(6, 19);
            this.gpbAvaliador.Name = "gpbAvaliador";
            this.gpbAvaliador.Size = new System.Drawing.Size(346, 100);
            this.gpbAvaliador.TabIndex = 0;
            this.gpbAvaliador.TabStop = false;
            this.gpbAvaliador.Text = "Avaliador";
            // 
            // chkAllAvaliadores
            // 
            this.chkAllAvaliadores.AutoSize = true;
            this.chkAllAvaliadores.Location = new System.Drawing.Point(271, 71);
            this.chkAllAvaliadores.Name = "chkAllAvaliadores";
            this.chkAllAvaliadores.Size = new System.Drawing.Size(56, 17);
            this.chkAllAvaliadores.TabIndex = 5;
            this.chkAllAvaliadores.Text = "Todos";
            this.chkAllAvaliadores.UseVisualStyleBackColor = true;
            this.chkAllAvaliadores.CheckedChanged += new System.EventHandler(this.chkAllAvaliadores_CheckedChanged);
            // 
            // btnAvaliador
            // 
            this.btnAvaliador.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnAvaliador.Location = new System.Drawing.Point(268, 19);
            this.btnAvaliador.Name = "btnAvaliador";
            this.btnAvaliador.Size = new System.Drawing.Size(59, 33);
            this.btnAvaliador.TabIndex = 1;
            this.btnAvaliador.UseVisualStyleBackColor = true;
            this.btnAvaliador.Click += new System.EventHandler(this.btnAvaliador_Click);
            // 
            // ttbAvaliador
            // 
            this.ttbAvaliador.Location = new System.Drawing.Point(6, 26);
            this.ttbAvaliador.MaxLength = 100;
            this.ttbAvaliador.Name = "ttbAvaliador";
            this.ttbAvaliador.Size = new System.Drawing.Size(245, 20);
            this.ttbAvaliador.TabIndex = 0;
            this.ttbAvaliador.TextChanged += new System.EventHandler(this.ttbAvaliador_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.gpbAvaliador);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkPeriodo);
            this.groupBox5.Controls.Add(this.dtpFim);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.dtpInicio);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(379, 134);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 100);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Período";
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(211, 60);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(56, 17);
            this.chkPeriodo.TabIndex = 4;
            this.chkPeriodo.Text = "Todos";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(168, 19);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(99, 20);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "e";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(44, 19);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(99, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTodas);
            this.groupBox1.Controls.Add(this.rbAtraso);
            this.groupBox1.Controls.Add(this.rbRealizadas);
            this.groupBox1.Controls.Add(this.rbNRealizadas);
            this.groupBox1.Location = new System.Drawing.Point(6, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(6, 19);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 3;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbRealizadas_CheckedChanged);
            // 
            // rbAtraso
            // 
            this.rbAtraso.AutoSize = true;
            this.rbAtraso.Location = new System.Drawing.Point(125, 59);
            this.rbAtraso.Name = "rbAtraso";
            this.rbAtraso.Size = new System.Drawing.Size(72, 17);
            this.rbAtraso.TabIndex = 2;
            this.rbAtraso.TabStop = true;
            this.rbAtraso.Text = "Em atraso";
            this.rbAtraso.UseVisualStyleBackColor = true;
            this.rbAtraso.CheckedChanged += new System.EventHandler(this.rbRealizadas_CheckedChanged);
            // 
            // rbRealizadas
            // 
            this.rbRealizadas.AutoSize = true;
            this.rbRealizadas.Location = new System.Drawing.Point(125, 19);
            this.rbRealizadas.Name = "rbRealizadas";
            this.rbRealizadas.Size = new System.Drawing.Size(77, 17);
            this.rbRealizadas.TabIndex = 1;
            this.rbRealizadas.TabStop = true;
            this.rbRealizadas.Text = "Realizadas";
            this.rbRealizadas.UseVisualStyleBackColor = true;
            this.rbRealizadas.CheckedChanged += new System.EventHandler(this.rbRealizadas_CheckedChanged);
            // 
            // rbNRealizadas
            // 
            this.rbNRealizadas.AutoSize = true;
            this.rbNRealizadas.Location = new System.Drawing.Point(6, 59);
            this.rbNRealizadas.Name = "rbNRealizadas";
            this.rbNRealizadas.Size = new System.Drawing.Size(95, 17);
            this.rbNRealizadas.TabIndex = 0;
            this.rbNRealizadas.TabStop = true;
            this.rbNRealizadas.Text = "Não realizadas";
            this.rbNRealizadas.UseVisualStyleBackColor = true;
            this.rbNRealizadas.CheckedChanged += new System.EventHandler(this.rbRealizadas_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chAllAluno);
            this.groupBox4.Controls.Add(this.btnAluno);
            this.groupBox4.Controls.Add(this.ttbAluno);
            this.groupBox4.Location = new System.Drawing.Point(379, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aluno";
            // 
            // chAllAluno
            // 
            this.chAllAluno.AutoSize = true;
            this.chAllAluno.Location = new System.Drawing.Point(271, 71);
            this.chAllAluno.Name = "chAllAluno";
            this.chAllAluno.Size = new System.Drawing.Size(56, 17);
            this.chAllAluno.TabIndex = 4;
            this.chAllAluno.Text = "Todos";
            this.chAllAluno.UseVisualStyleBackColor = true;
            this.chAllAluno.CheckedChanged += new System.EventHandler(this.chAllAluno_CheckedChanged);
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
            this.ttbAluno.TextChanged += new System.EventHandler(this.ttbAvaliador_TextChanged);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblNaoRealizadas);
            this.gpbInfo.Controls.Add(this.label7);
            this.gpbInfo.Controls.Add(this.lblEmAtraso);
            this.gpbInfo.Controls.Add(this.label5);
            this.gpbInfo.Controls.Add(this.lblTotal);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Location = new System.Drawing.Point(766, 12);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(157, 249);
            this.gpbInfo.TabIndex = 2;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informações";
            // 
            // lblNaoRealizadas
            // 
            this.lblNaoRealizadas.AutoSize = true;
            this.lblNaoRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoRealizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNaoRealizadas.Location = new System.Drawing.Point(82, 56);
            this.lblNaoRealizadas.Name = "lblNaoRealizadas";
            this.lblNaoRealizadas.Size = new System.Drawing.Size(19, 13);
            this.lblNaoRealizadas.TabIndex = 5;
            this.lblNaoRealizadas.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Não realizadas:";
            // 
            // lblEmAtraso
            // 
            this.lblEmAtraso.AutoSize = true;
            this.lblEmAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmAtraso.ForeColor = System.Drawing.Color.Red;
            this.lblEmAtraso.Location = new System.Drawing.Point(82, 94);
            this.lblEmAtraso.Name = "lblEmAtraso";
            this.lblEmAtraso.Size = new System.Drawing.Size(19, 13);
            this.lblEmAtraso.TabIndex = 3;
            this.lblEmAtraso.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Em atraso:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(81, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total:";
            // 
            // dtgvAva
            // 
            this.dtgvAva.AllowUserToAddRows = false;
            this.dtgvAva.AllowUserToDeleteRows = false;
            this.dtgvAva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ava_dtagend,
            this.id,
            this.ava_dtrealiz,
            this.func_nome,
            this.alu_nome});
            this.dtgvAva.Location = new System.Drawing.Point(12, 267);
            this.dtgvAva.Name = "dtgvAva";
            this.dtgvAva.ReadOnly = true;
            this.dtgvAva.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvAva.Size = new System.Drawing.Size(748, 408);
            this.dtgvAva.TabIndex = 3;
            this.dtgvAva.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvAva_RowsAdded);
            this.dtgvAva.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvAva_RowsRemoved);
            this.dtgvAva.SelectionChanged += new System.EventHandler(this.dtgvAva_SelectionChanged);
            // 
            // ava_dtagend
            // 
            this.ava_dtagend.DataPropertyName = "ava_dtagend";
            this.ava_dtagend.HeaderText = "Data Agendamento";
            this.ava_dtagend.Name = "ava_dtagend";
            this.ava_dtagend.ReadOnly = true;
            this.ava_dtagend.Width = 130;
            // 
            // id
            // 
            this.id.DataPropertyName = "ava_id";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // ava_dtrealiz
            // 
            this.ava_dtrealiz.DataPropertyName = "ava_dtrealiz";
            this.ava_dtrealiz.HeaderText = "Data Realização";
            this.ava_dtrealiz.Name = "ava_dtrealiz";
            this.ava_dtrealiz.ReadOnly = true;
            this.ava_dtrealiz.Width = 130;
            // 
            // func_nome
            // 
            this.func_nome.DataPropertyName = "func_nome";
            this.func_nome.HeaderText = "Avaliador";
            this.func_nome.Name = "func_nome";
            this.func_nome.ReadOnly = true;
            this.func_nome.Width = 220;
            // 
            // alu_nome
            // 
            this.alu_nome.DataPropertyName = "alu_nome";
            this.alu_nome.HeaderText = "Aluno";
            this.alu_nome.Name = "alu_nome";
            this.alu_nome.ReadOnly = true;
            this.alu_nome.Width = 223;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnExcluir);
            this.groupBox3.Location = new System.Drawing.Point(766, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 293);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agendamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::infoGym.Properties.Resources.agenda2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources._6031_32x32;
            this.btnNovo.Location = new System.Drawing.Point(103, 19);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(48, 48);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.excluirP;
            this.btnExcluir.Location = new System.Drawing.Point(6, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 48);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAvaliacao
            // 
            this.btnAvaliacao.Enabled = false;
            this.btnAvaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliacao.Image = global::infoGym.Properties.Resources.app_481;
            this.btnAvaliacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAvaliacao.Location = new System.Drawing.Point(32, 39);
            this.btnAvaliacao.Name = "btnAvaliacao";
            this.btnAvaliacao.Size = new System.Drawing.Size(96, 55);
            this.btnAvaliacao.TabIndex = 22;
            this.btnAvaliacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAvaliacao.UseVisualStyleBackColor = true;
            this.btnAvaliacao.Click += new System.EventHandler(this.btnAvaliacao_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAvaliacao);
            this.groupBox6.Location = new System.Drawing.Point(766, 566);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(157, 109);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Avaliação";
            // 
            // frmAvControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 687);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvAva);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(953, 725);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(953, 725);
            this.Name = "frmAvControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Avaliações";
            this.gpbAvaliador.ResumeLayout(false);
            this.gpbAvaliador.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAva)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAvaliador;
        private System.Windows.Forms.TextBox ttbAvaliador;
        private System.Windows.Forms.Button btnAvaliador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.DataGridView dtgvAva;
        private System.Windows.Forms.CheckBox chkAllAvaliadores;
        private System.Windows.Forms.CheckBox chAllAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbAtraso;
        private System.Windows.Forms.RadioButton rbRealizadas;
        private System.Windows.Forms.RadioButton rbNRealizadas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPeriodo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNaoRealizadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEmAtraso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava_dtagend;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava_dtrealiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn func_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn alu_nome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAvaliacao;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}