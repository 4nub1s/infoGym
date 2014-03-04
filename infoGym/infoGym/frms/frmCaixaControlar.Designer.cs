namespace infoGym
{
    partial class frmCaixaControlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixaControlar));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.rbAmbas = new System.Windows.Forms.RadioButton();
            this.rbSaida = new System.Windows.Forms.RadioButton();
            this.rbEntrada = new System.Windows.Forms.RadioButton();
            this.dtgvCaixa = new System.Windows.Forms.DataGridView();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gpbFechamento = new System.Windows.Forms.GroupBox();
            this.ttbValorFechamento = new System.Windows.Forms.TextBox();
            this.lblFaltaCaixa = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSobraCaixa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblQuemRealizouFechamento = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHoraFechamento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEntradas = new System.Windows.Forms.Label();
            this.lblSaídas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbAbertura = new System.Windows.Forms.GroupBox();
            this.lblQuemRealizouAbertura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValorAbertura = new System.Windows.Forms.Label();
            this.lblMovimento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCaixa)).BeginInit();
            this.gpbInfo.SuspendLayout();
            this.gpbFechamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbAbertura.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.rbAmbas);
            this.gpbFiltros.Controls.Add(this.rbSaida);
            this.gpbFiltros.Controls.Add(this.rbEntrada);
            this.gpbFiltros.Location = new System.Drawing.Point(151, 12);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(264, 57);
            this.gpbFiltros.TabIndex = 3;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Exibir";
            // 
            // rbAmbas
            // 
            this.rbAmbas.AutoSize = true;
            this.rbAmbas.Checked = true;
            this.rbAmbas.Location = new System.Drawing.Point(185, 19);
            this.rbAmbas.Name = "rbAmbas";
            this.rbAmbas.Size = new System.Drawing.Size(57, 17);
            this.rbAmbas.TabIndex = 2;
            this.rbAmbas.TabStop = true;
            this.rbAmbas.Text = "Ambas";
            this.rbAmbas.UseVisualStyleBackColor = true;
            this.rbAmbas.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbSaida
            // 
            this.rbSaida.AutoSize = true;
            this.rbSaida.Location = new System.Drawing.Point(108, 19);
            this.rbSaida.Name = "rbSaida";
            this.rbSaida.Size = new System.Drawing.Size(59, 17);
            this.rbSaida.TabIndex = 1;
            this.rbSaida.Text = "Saídas";
            this.rbSaida.UseVisualStyleBackColor = true;
            this.rbSaida.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // rbEntrada
            // 
            this.rbEntrada.AutoSize = true;
            this.rbEntrada.Location = new System.Drawing.Point(22, 19);
            this.rbEntrada.Name = "rbEntrada";
            this.rbEntrada.Size = new System.Drawing.Size(67, 17);
            this.rbEntrada.TabIndex = 0;
            this.rbEntrada.Text = "Entradas";
            this.rbEntrada.UseVisualStyleBackColor = true;
            this.rbEntrada.CheckedChanged += new System.EventHandler(this.rbEntrada_CheckedChanged);
            // 
            // dtgvCaixa
            // 
            this.dtgvCaixa.AllowUserToAddRows = false;
            this.dtgvCaixa.AllowUserToDeleteRows = false;
            this.dtgvCaixa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desc,
            this.valor,
            this.id,
            this.isEntrada,
            this.movTipo,
            this.img});
            this.dtgvCaixa.Location = new System.Drawing.Point(12, 75);
            this.dtgvCaixa.Name = "dtgvCaixa";
            this.dtgvCaixa.ReadOnly = true;
            this.dtgvCaixa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvCaixa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCaixa.Size = new System.Drawing.Size(403, 372);
            this.dtgvCaixa.TabIndex = 2;
            this.dtgvCaixa.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvCaixa_RowsAdded);
            this.dtgvCaixa.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvCaixa_RowsRemoved);
            this.dtgvCaixa.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgvCaixa_RowStateChanged);
            this.dtgvCaixa.SelectionChanged += new System.EventHandler(this.dtgvCaixa_SelectionChanged);
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.DataPropertyName = "desc";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Desc.DefaultCellStyle = dataGridViewCellStyle5;
            this.Desc.HeaderText = "Descrição";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle6;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 80;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // isEntrada
            // 
            this.isEntrada.DataPropertyName = "isEntrada";
            this.isEntrada.HeaderText = "Column1";
            this.isEntrada.Name = "isEntrada";
            this.isEntrada.ReadOnly = true;
            this.isEntrada.Visible = false;
            // 
            // movTipo
            // 
            this.movTipo.DataPropertyName = "movTipo";
            this.movTipo.HeaderText = "Natureza";
            this.movTipo.Name = "movTipo";
            this.movTipo.ReadOnly = true;
            this.movTipo.Visible = false;
            // 
            // img
            // 
            this.img.DataPropertyName = "img";
            this.img.HeaderText = "Tipo";
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.img.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(48, 12);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(96, 20);
            this.dtpData.TabIndex = 5;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblSaldo);
            this.gpbInfo.Controls.Add(this.label14);
            this.gpbInfo.Controls.Add(this.gpbFechamento);
            this.gpbInfo.Controls.Add(this.groupBox1);
            this.gpbInfo.Controls.Add(this.gpbAbertura);
            this.gpbInfo.Controls.Add(this.lblMovimento);
            this.gpbInfo.Controls.Add(this.label4);
            this.gpbInfo.Location = new System.Drawing.Point(433, 13);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(157, 434);
            this.gpbInfo.TabIndex = 6;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informações";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSaldo.Location = new System.Drawing.Point(30, 397);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 24);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "R$0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 24);
            this.label14.TabIndex = 13;
            this.label14.Text = "Saldo";
            // 
            // gpbFechamento
            // 
            this.gpbFechamento.Controls.Add(this.ttbValorFechamento);
            this.gpbFechamento.Controls.Add(this.lblFaltaCaixa);
            this.gpbFechamento.Controls.Add(this.label12);
            this.gpbFechamento.Controls.Add(this.lblSobraCaixa);
            this.gpbFechamento.Controls.Add(this.label11);
            this.gpbFechamento.Controls.Add(this.lblQuemRealizouFechamento);
            this.gpbFechamento.Controls.Add(this.label10);
            this.gpbFechamento.Controls.Add(this.label9);
            this.gpbFechamento.Controls.Add(this.lblHoraFechamento);
            this.gpbFechamento.Controls.Add(this.label8);
            this.gpbFechamento.Location = new System.Drawing.Point(5, 178);
            this.gpbFechamento.Name = "gpbFechamento";
            this.gpbFechamento.Size = new System.Drawing.Size(146, 144);
            this.gpbFechamento.TabIndex = 12;
            this.gpbFechamento.TabStop = false;
            this.gpbFechamento.Text = "Fechamento";
            // 
            // ttbValorFechamento
            // 
            this.ttbValorFechamento.Location = new System.Drawing.Point(39, 106);
            this.ttbValorFechamento.MaxLength = 10;
            this.ttbValorFechamento.Name = "ttbValorFechamento";
            this.ttbValorFechamento.Size = new System.Drawing.Size(74, 20);
            this.ttbValorFechamento.TabIndex = 21;
            this.ttbValorFechamento.Click += new System.EventHandler(this.ttbValorFechamento_Click);
            this.ttbValorFechamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValorFechamento_KeyPress);
            // 
            // lblFaltaCaixa
            // 
            this.lblFaltaCaixa.AutoSize = true;
            this.lblFaltaCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltaCaixa.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaCaixa.Location = new System.Drawing.Point(77, 81);
            this.lblFaltaCaixa.Name = "lblFaltaCaixa";
            this.lblFaltaCaixa.Size = new System.Drawing.Size(19, 13);
            this.lblFaltaCaixa.TabIndex = 9;
            this.lblFaltaCaixa.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Falta no caixa:";
            // 
            // lblSobraCaixa
            // 
            this.lblSobraCaixa.AutoSize = true;
            this.lblSobraCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobraCaixa.ForeColor = System.Drawing.Color.Blue;
            this.lblSobraCaixa.Location = new System.Drawing.Point(78, 59);
            this.lblSobraCaixa.Name = "lblSobraCaixa";
            this.lblSobraCaixa.Size = new System.Drawing.Size(19, 13);
            this.lblSobraCaixa.TabIndex = 7;
            this.lblSobraCaixa.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Sobra de caixa:";
            // 
            // lblQuemRealizouFechamento
            // 
            this.lblQuemRealizouFechamento.AutoSize = true;
            this.lblQuemRealizouFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemRealizouFechamento.Location = new System.Drawing.Point(77, 36);
            this.lblQuemRealizouFechamento.Name = "lblQuemRealizouFechamento";
            this.lblQuemRealizouFechamento.Size = new System.Drawing.Size(19, 13);
            this.lblQuemRealizouFechamento.TabIndex = 5;
            this.lblQuemRealizouFechamento.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Realizado por:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Valor:";
            // 
            // lblHoraFechamento
            // 
            this.lblHoraFechamento.AutoSize = true;
            this.lblHoraFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFechamento.Location = new System.Drawing.Point(77, 17);
            this.lblHoraFechamento.Name = "lblHoraFechamento";
            this.lblHoraFechamento.Size = new System.Drawing.Size(19, 13);
            this.lblHoraFechamento.TabIndex = 1;
            this.lblHoraFechamento.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Horário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblEntradas);
            this.groupBox1.Controls.Add(this.lblSaídas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(5, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo Movimentações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entradas:";
            // 
            // lblEntradas
            // 
            this.lblEntradas.AutoSize = true;
            this.lblEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradas.ForeColor = System.Drawing.Color.Blue;
            this.lblEntradas.Location = new System.Drawing.Point(56, 16);
            this.lblEntradas.Name = "lblEntradas";
            this.lblEntradas.Size = new System.Drawing.Size(19, 13);
            this.lblEntradas.TabIndex = 5;
            this.lblEntradas.Text = "---";
            // 
            // lblSaídas
            // 
            this.lblSaídas.AutoSize = true;
            this.lblSaídas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaídas.ForeColor = System.Drawing.Color.Red;
            this.lblSaídas.Location = new System.Drawing.Point(56, 32);
            this.lblSaídas.Name = "lblSaídas";
            this.lblSaídas.Size = new System.Drawing.Size(19, 13);
            this.lblSaídas.TabIndex = 7;
            this.lblSaídas.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Saídas:";
            // 
            // gpbAbertura
            // 
            this.gpbAbertura.Controls.Add(this.lblQuemRealizouAbertura);
            this.gpbAbertura.Controls.Add(this.label7);
            this.gpbAbertura.Controls.Add(this.label2);
            this.gpbAbertura.Controls.Add(this.lblAbertura);
            this.gpbAbertura.Controls.Add(this.label3);
            this.gpbAbertura.Controls.Add(this.lblValorAbertura);
            this.gpbAbertura.Location = new System.Drawing.Point(6, 19);
            this.gpbAbertura.Name = "gpbAbertura";
            this.gpbAbertura.Size = new System.Drawing.Size(145, 80);
            this.gpbAbertura.TabIndex = 10;
            this.gpbAbertura.TabStop = false;
            this.gpbAbertura.Text = "Abertura";
            // 
            // lblQuemRealizouAbertura
            // 
            this.lblQuemRealizouAbertura.AutoSize = true;
            this.lblQuemRealizouAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemRealizouAbertura.Location = new System.Drawing.Point(77, 53);
            this.lblQuemRealizouAbertura.Name = "lblQuemRealizouAbertura";
            this.lblQuemRealizouAbertura.Size = new System.Drawing.Size(19, 13);
            this.lblQuemRealizouAbertura.TabIndex = 5;
            this.lblQuemRealizouAbertura.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Realizada por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horário:";
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbertura.Location = new System.Drawing.Point(76, 17);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(19, 13);
            this.lblAbertura.TabIndex = 1;
            this.lblAbertura.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // lblValorAbertura
            // 
            this.lblValorAbertura.AutoSize = true;
            this.lblValorAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAbertura.Location = new System.Drawing.Point(77, 35);
            this.lblValorAbertura.Name = "lblValorAbertura";
            this.lblValorAbertura.Size = new System.Drawing.Size(19, 13);
            this.lblValorAbertura.TabIndex = 3;
            this.lblValorAbertura.Text = "---";
            // 
            // lblMovimento
            // 
            this.lblMovimento.AutoSize = true;
            this.lblMovimento.BackColor = System.Drawing.SystemColors.Control;
            this.lblMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMovimento.Location = new System.Drawing.Point(28, 349);
            this.lblMovimento.Name = "lblMovimento";
            this.lblMovimento.Size = new System.Drawing.Size(43, 24);
            this.lblMovimento.TabIndex = 9;
            this.lblMovimento.Text = "R$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Movimento";
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Image = global::infoGym.Properties.Resources._lock;
            this.btnFecharCaixa.Location = new System.Drawing.Point(433, 453);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(157, 70);
            this.btnFecharCaixa.TabIndex = 12;
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            this.btnFecharCaixa.Click += new System.EventHandler(this.btnFecharCaixa_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::infoGym.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(226, 453);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(79, 70);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::infoGym.Properties.Resources.edit_remove;
            this.btnExcluir.Location = new System.Drawing.Point(336, 453);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 70);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.Image = global::infoGym.Properties.Resources.up;
            this.btnSaida.Location = new System.Drawing.Point(119, 453);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(79, 70);
            this.btnSaida.TabIndex = 8;
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Image = global::infoGym.Properties.Resources.down;
            this.btnEntrada.Location = new System.Drawing.Point(12, 453);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(79, 70);
            this.btnEntrada.TabIndex = 7;
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "up.png");
            this.imageList1.Images.SetKeyName(1, "down.png");
            // 
            // frmCaixaControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 527);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSaida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbFiltros);
            this.Controls.Add(this.dtgvCaixa);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 565);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 565);
            this.Name = "frmCaixaControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlar Caixa";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCaixa)).EndInit();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbFechamento.ResumeLayout(false);
            this.gpbFechamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbAbertura.ResumeLayout(false);
            this.gpbAbertura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.RadioButton rbAmbas;
        private System.Windows.Forms.RadioButton rbSaida;
        private System.Windows.Forms.RadioButton rbEntrada;
        private System.Windows.Forms.DataGridView dtgvCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorAbertura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaídas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntradas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMovimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox gpbAbertura;
        private System.Windows.Forms.Label lblQuemRealizouAbertura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbFechamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQuemRealizouFechamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHoraFechamento;
        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.Label lblFaltaCaixa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSobraCaixa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbValorFechamento;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn movTipo;
        private System.Windows.Forms.DataGridViewImageColumn img;
    }
}