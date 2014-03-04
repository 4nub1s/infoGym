namespace infoGym.frms
{
    partial class frmMatriculaControlar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.ttbAluno = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnModalidade = new System.Windows.Forms.Button();
            this.ttbModalidade = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbDiaristaMensalista = new System.Windows.Forms.RadioButton();
            this.rbMensalista = new System.Windows.Forms.RadioButton();
            this.rbDiarista = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAtivasInativas = new System.Windows.Forms.RadioButton();
            this.rbInativas = new System.Windows.Forms.RadioButton();
            this.rbAtivas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMensalista = new System.Windows.Forms.Label();
            this.lblDiarista = new System.Windows.Forms.Label();
            this.lblInativas = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAtivas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgvMatriculas = new System.Windows.Forms.DataGridView();
            this.matcod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnControlarMensalidades = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAddDays = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(523, 148);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 46);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAluno);
            this.groupBox6.Controls.Add(this.ttbAluno);
            this.groupBox6.Location = new System.Drawing.Point(272, 129);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 65);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Aluno";
            // 
            // btnAluno
            // 
            this.btnAluno.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnAluno.Location = new System.Drawing.Point(189, 19);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(46, 20);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // ttbAluno
            // 
            this.ttbAluno.Enabled = false;
            this.ttbAluno.Location = new System.Drawing.Point(6, 19);
            this.ttbAluno.Name = "ttbAluno";
            this.ttbAluno.Size = new System.Drawing.Size(177, 20);
            this.ttbAluno.TabIndex = 0;
            this.ttbAluno.Text = "Todos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnModalidade);
            this.groupBox5.Controls.Add(this.ttbModalidade);
            this.groupBox5.Location = new System.Drawing.Point(6, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 65);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modalidade";
            // 
            // btnModalidade
            // 
            this.btnModalidade.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnModalidade.Location = new System.Drawing.Point(189, 19);
            this.btnModalidade.Name = "btnModalidade";
            this.btnModalidade.Size = new System.Drawing.Size(46, 20);
            this.btnModalidade.TabIndex = 1;
            this.btnModalidade.UseVisualStyleBackColor = true;
            this.btnModalidade.Click += new System.EventHandler(this.btnModalidade_Click);
            // 
            // ttbModalidade
            // 
            this.ttbModalidade.Enabled = false;
            this.ttbModalidade.Location = new System.Drawing.Point(6, 19);
            this.ttbModalidade.Name = "ttbModalidade";
            this.ttbModalidade.Size = new System.Drawing.Size(177, 20);
            this.ttbModalidade.TabIndex = 0;
            this.ttbModalidade.Text = "Todas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbDiaristaMensalista);
            this.groupBox4.Controls.Add(this.rbMensalista);
            this.groupBox4.Controls.Add(this.rbDiarista);
            this.groupBox4.Location = new System.Drawing.Point(272, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forma de pagamento";
            // 
            // rbDiaristaMensalista
            // 
            this.rbDiaristaMensalista.AutoSize = true;
            this.rbDiaristaMensalista.Location = new System.Drawing.Point(7, 46);
            this.rbDiaristaMensalista.Name = "rbDiaristaMensalista";
            this.rbDiaristaMensalista.Size = new System.Drawing.Size(57, 17);
            this.rbDiaristaMensalista.TabIndex = 2;
            this.rbDiaristaMensalista.TabStop = true;
            this.rbDiaristaMensalista.Text = "Ambas";
            this.rbDiaristaMensalista.UseVisualStyleBackColor = true;
            this.rbDiaristaMensalista.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // rbMensalista
            // 
            this.rbMensalista.AutoSize = true;
            this.rbMensalista.Location = new System.Drawing.Point(116, 19);
            this.rbMensalista.Name = "rbMensalista";
            this.rbMensalista.Size = new System.Drawing.Size(80, 17);
            this.rbMensalista.TabIndex = 1;
            this.rbMensalista.TabStop = true;
            this.rbMensalista.Text = "Mensalistas";
            this.rbMensalista.UseVisualStyleBackColor = true;
            this.rbMensalista.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // rbDiarista
            // 
            this.rbDiarista.AutoSize = true;
            this.rbDiarista.Location = new System.Drawing.Point(6, 19);
            this.rbDiarista.Name = "rbDiarista";
            this.rbDiarista.Size = new System.Drawing.Size(65, 17);
            this.rbDiarista.TabIndex = 0;
            this.rbDiarista.TabStop = true;
            this.rbDiarista.Text = "Diaristas";
            this.rbDiarista.UseVisualStyleBackColor = true;
            this.rbDiarista.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAtivasInativas);
            this.groupBox3.Controls.Add(this.rbInativas);
            this.groupBox3.Controls.Add(this.rbAtivas);
            this.groupBox3.Location = new System.Drawing.Point(68, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 79);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // rbAtivasInativas
            // 
            this.rbAtivasInativas.AutoSize = true;
            this.rbAtivasInativas.Location = new System.Drawing.Point(6, 46);
            this.rbAtivasInativas.Name = "rbAtivasInativas";
            this.rbAtivasInativas.Size = new System.Drawing.Size(57, 17);
            this.rbAtivasInativas.TabIndex = 2;
            this.rbAtivasInativas.TabStop = true;
            this.rbAtivasInativas.Text = "Ambas";
            this.rbAtivasInativas.UseVisualStyleBackColor = true;
            this.rbAtivasInativas.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // rbInativas
            // 
            this.rbInativas.AutoSize = true;
            this.rbInativas.Location = new System.Drawing.Point(108, 19);
            this.rbInativas.Name = "rbInativas";
            this.rbInativas.Size = new System.Drawing.Size(62, 17);
            this.rbInativas.TabIndex = 1;
            this.rbInativas.TabStop = true;
            this.rbInativas.Text = "Inativas";
            this.rbInativas.UseVisualStyleBackColor = true;
            this.rbInativas.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // rbAtivas
            // 
            this.rbAtivas.AutoSize = true;
            this.rbAtivas.Location = new System.Drawing.Point(6, 19);
            this.rbAtivas.Name = "rbAtivas";
            this.rbAtivas.Size = new System.Drawing.Size(54, 17);
            this.rbAtivas.TabIndex = 0;
            this.rbAtivas.TabStop = true;
            this.rbAtivas.Text = "Ativas";
            this.rbAtivas.UseVisualStyleBackColor = true;
            this.rbAtivas.CheckedChanged += new System.EventHandler(this.rbAtivas_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMensalista);
            this.groupBox2.Controls.Add(this.lblDiarista);
            this.groupBox2.Controls.Add(this.lblInativas);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblAtivas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(789, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 417);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // lblMensalista
            // 
            this.lblMensalista.AutoSize = true;
            this.lblMensalista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensalista.ForeColor = System.Drawing.Color.Purple;
            this.lblMensalista.Location = new System.Drawing.Point(68, 107);
            this.lblMensalista.Name = "lblMensalista";
            this.lblMensalista.Size = new System.Drawing.Size(19, 13);
            this.lblMensalista.TabIndex = 36;
            this.lblMensalista.Text = "---";
            // 
            // lblDiarista
            // 
            this.lblDiarista.AutoSize = true;
            this.lblDiarista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiarista.ForeColor = System.Drawing.Color.Green;
            this.lblDiarista.Location = new System.Drawing.Point(66, 85);
            this.lblDiarista.Name = "lblDiarista";
            this.lblDiarista.Size = new System.Drawing.Size(19, 13);
            this.lblDiarista.TabIndex = 35;
            this.lblDiarista.Text = "---";
            // 
            // lblInativas
            // 
            this.lblInativas.AutoSize = true;
            this.lblInativas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInativas.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInativas.Location = new System.Drawing.Point(65, 62);
            this.lblInativas.Name = "lblInativas";
            this.lblInativas.Size = new System.Drawing.Size(19, 13);
            this.lblInativas.TabIndex = 34;
            this.lblInativas.Text = "---";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(62, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 13);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "---";
            // 
            // lblAtivas
            // 
            this.lblAtivas.AutoSize = true;
            this.lblAtivas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivas.ForeColor = System.Drawing.Color.Blue;
            this.lblAtivas.Location = new System.Drawing.Point(63, 40);
            this.lblAtivas.Name = "lblAtivas";
            this.lblAtivas.Size = new System.Drawing.Size(19, 13);
            this.lblAtivas.TabIndex = 32;
            this.lblAtivas.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mensalistas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Diaristas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inativas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ativas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::infoGym.Properties.Resources.icone_cadastro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 141);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // dtgvMatriculas
            // 
            this.dtgvMatriculas.AllowUserToAddRows = false;
            this.dtgvMatriculas.AllowUserToDeleteRows = false;
            this.dtgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matcod,
            this.aluno,
            this.modalidade,
            this.tipo,
            this.statusM});
            this.dtgvMatriculas.Location = new System.Drawing.Point(12, 225);
            this.dtgvMatriculas.Name = "dtgvMatriculas";
            this.dtgvMatriculas.ReadOnly = true;
            this.dtgvMatriculas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMatriculas.Size = new System.Drawing.Size(620, 325);
            this.dtgvMatriculas.TabIndex = 2;
            this.dtgvMatriculas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvMatriculas_RowsRemoved);
            this.dtgvMatriculas.SelectionChanged += new System.EventHandler(this.dtgvMatriculas_SelectionChanged);
            // 
            // matcod
            // 
            this.matcod.DataPropertyName = "mat_cod";
            this.matcod.HeaderText = "Código";
            this.matcod.Name = "matcod";
            this.matcod.ReadOnly = true;
            this.matcod.Width = 50;
            // 
            // aluno
            // 
            this.aluno.DataPropertyName = "alu_nome";
            this.aluno.HeaderText = "Aluno";
            this.aluno.Name = "aluno";
            this.aluno.ReadOnly = true;
            this.aluno.Width = 150;
            // 
            // modalidade
            // 
            this.modalidade.DataPropertyName = "mod_desc";
            this.modalidade.HeaderText = "Modalidade";
            this.modalidade.Name = "modalidade";
            this.modalidade.ReadOnly = true;
            this.modalidade.Width = 150;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "formapgmto";
            this.tipo.HeaderText = "Forma Pagamento";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 90;
            // 
            // statusM
            // 
            this.statusM.DataPropertyName = "status";
            this.statusM.HeaderText = "Status";
            this.statusM.Name = "statusM";
            this.statusM.ReadOnly = true;
            this.statusM.Width = 140;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnControlarMensalidades
            // 
            this.btnControlarMensalidades.Location = new System.Drawing.Point(806, 439);
            this.btnControlarMensalidades.Name = "btnControlarMensalidades";
            this.btnControlarMensalidades.Size = new System.Drawing.Size(120, 45);
            this.btnControlarMensalidades.TabIndex = 26;
            this.btnControlarMensalidades.Text = "Controlar Mensalidades";
            this.btnControlarMensalidades.UseVisualStyleBackColor = true;
            this.btnControlarMensalidades.Visible = false;
            this.btnControlarMensalidades.Click += new System.EventHandler(this.btnControlarMensalidades_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(843, 490);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 60);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(742, 490);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(83, 60);
            this.btnAlterar.TabIndex = 24;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(638, 490);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(83, 60);
            this.btnNovo.TabIndex = 23;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAddDays
            // 
            this.btnAddDays.Location = new System.Drawing.Point(680, 439);
            this.btnAddDays.Name = "btnAddDays";
            this.btnAddDays.Size = new System.Drawing.Size(120, 45);
            this.btnAddDays.TabIndex = 27;
            this.btnAddDays.Text = "Controlar Diárias";
            this.btnAddDays.UseVisualStyleBackColor = true;
            this.btnAddDays.Visible = false;
            this.btnAddDays.Click += new System.EventHandler(this.btnAddDays_Click);
            // 
            // frmMatriculaControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 562);
            this.Controls.Add(this.btnAddDays);
            this.Controls.Add(this.btnControlarMensalidades);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dtgvMatriculas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(958, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(958, 600);
            this.Name = "frmMatriculaControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlar Matrículas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMatriculas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAtivasInativas;
        private System.Windows.Forms.RadioButton rbInativas;
        private System.Windows.Forms.RadioButton rbAtivas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbDiaristaMensalista;
        private System.Windows.Forms.RadioButton rbMensalista;
        private System.Windows.Forms.RadioButton rbDiarista;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.TextBox ttbAluno;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnModalidade;
        private System.Windows.Forms.TextBox ttbModalidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgvMatriculas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensalista;
        private System.Windows.Forms.Label lblDiarista;
        private System.Windows.Forms.Label lblInativas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAtivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn matcod;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusM;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnControlarMensalidades;
        private System.Windows.Forms.Button btnAddDays;
    }
}