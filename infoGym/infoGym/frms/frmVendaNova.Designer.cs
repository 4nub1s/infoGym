namespace infoGym
{
    partial class frmVendaNova
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.ttbQtde = new System.Windows.Forms.NumericUpDown();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.ttbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAluAdd = new System.Windows.Forms.Button();
            this.ttbAluNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgvItensVenda = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.cbbFormaPgmto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblQuemRealizou = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblQtdeItens = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subttotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.gpbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbQtde)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItensVenda)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserOn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 534);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 28);
            this.panel1.TabIndex = 0;
            // 
            // lblUserOn
            // 
            this.lblUserOn.AutoSize = true;
            this.lblUserOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOn.Location = new System.Drawing.Point(82, 6);
            this.lblUserOn.Name = "lblUserOn";
            this.lblUserOn.Size = new System.Drawing.Size(48, 13);
            this.lblUserOn.TabIndex = 1;
            this.lblUserOn.Text = "usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logado como:";
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.ttbQtde);
            this.gpbProduto.Controls.Add(this.lblEstoqueAtual);
            this.gpbProduto.Controls.Add(this.label9);
            this.gpbProduto.Controls.Add(this.btnAddProd);
            this.gpbProduto.Controls.Add(this.lblSubTotal);
            this.gpbProduto.Controls.Add(this.label5);
            this.gpbProduto.Controls.Add(this.label4);
            this.gpbProduto.Controls.Add(this.ttbValor);
            this.gpbProduto.Controls.Add(this.label3);
            this.gpbProduto.Controls.Add(this.btnBuscarProd);
            this.gpbProduto.Controls.Add(this.ttbDesc);
            this.gpbProduto.Controls.Add(this.label2);
            this.gpbProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(365, 137);
            this.gpbProduto.TabIndex = 1;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Adicionar produto";
            // 
            // ttbQtde
            // 
            this.ttbQtde.Location = new System.Drawing.Point(62, 68);
            this.ttbQtde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ttbQtde.Name = "ttbQtde";
            this.ttbQtde.Size = new System.Drawing.Size(43, 20);
            this.ttbQtde.TabIndex = 29;
            this.ttbQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ttbQtde.ValueChanged += new System.EventHandler(this.ttbQtde_TextChanged);
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueAtual.Location = new System.Drawing.Point(250, 44);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(19, 13);
            this.lblEstoqueAtual.TabIndex = 28;
            this.lblEstoqueAtual.Text = "---";
            this.lblEstoqueAtual.TextChanged += new System.EventHandler(this.lblEstoqueAtual_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Estoque atual:";
            // 
            // btnAddProd
            // 
            this.btnAddProd.Image = global::infoGym.Properties.Resources.add_24x24;
            this.btnAddProd.Location = new System.Drawing.Point(284, 96);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(75, 35);
            this.btnAddProd.TabIndex = 26;
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(239, 118);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(35, 13);
            this.lblSubTotal.TabIndex = 25;
            this.lblSubTotal.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "SubTotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantidade";
            // 
            // ttbValor
            // 
            this.ttbValor.Enabled = false;
            this.ttbValor.Location = new System.Drawing.Point(62, 41);
            this.ttbValor.MaxLength = 10;
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(74, 20);
            this.ttbValor.TabIndex = 20;
            this.ttbValor.Click += new System.EventHandler(this.ttbValor_Click);
            this.ttbValor.TextChanged += new System.EventHandler(this.ttbValor_TextChanged);
            this.ttbValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValor_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnBuscarProd.Location = new System.Drawing.Point(303, 13);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(56, 22);
            this.btnBuscarProd.TabIndex = 2;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // ttbDesc
            // 
            this.ttbDesc.Enabled = false;
            this.ttbDesc.Location = new System.Drawing.Point(62, 13);
            this.ttbDesc.MaxLength = 100;
            this.ttbDesc.Name = "ttbDesc";
            this.ttbDesc.Size = new System.Drawing.Size(235, 20);
            this.ttbDesc.TabIndex = 1;
            this.ttbDesc.TextChanged += new System.EventHandler(this.ttbValor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAluAdd);
            this.groupBox2.Controls.Add(this.ttbAluNome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(410, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 137);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados comprador";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = " é obrigatório!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(315, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Caso esteja vendendo para um aluno o preenchimento";
            // 
            // btnAluAdd
            // 
            this.btnAluAdd.Image = global::infoGym.Properties.Resources.search_16x16;
            this.btnAluAdd.Location = new System.Drawing.Point(270, 18);
            this.btnAluAdd.Name = "btnAluAdd";
            this.btnAluAdd.Size = new System.Drawing.Size(39, 20);
            this.btnAluAdd.TabIndex = 27;
            this.btnAluAdd.UseVisualStyleBackColor = true;
            this.btnAluAdd.Click += new System.EventHandler(this.btnAluAdd_Click);
            // 
            // ttbAluNome
            // 
            this.ttbAluNome.Enabled = false;
            this.ttbAluNome.Location = new System.Drawing.Point(37, 18);
            this.ttbAluNome.MaxLength = 100;
            this.ttbAluNome.Name = "ttbAluNome";
            this.ttbAluNome.Size = new System.Drawing.Size(227, 20);
            this.ttbAluNome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aluno";
            // 
            // dtgvItensVenda
            // 
            this.dtgvItensVenda.AllowUserToAddRows = false;
            this.dtgvItensVenda.AllowUserToDeleteRows = false;
            this.dtgvItensVenda.AllowUserToResizeColumns = false;
            this.dtgvItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.quantidade,
            this.preco_unit,
            this.subttotal,
            this.prod_id});
            this.dtgvItensVenda.Location = new System.Drawing.Point(9, 19);
            this.dtgvItensVenda.Name = "dtgvItensVenda";
            this.dtgvItensVenda.ReadOnly = true;
            this.dtgvItensVenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvItensVenda.Size = new System.Drawing.Size(340, 268);
            this.dtgvItensVenda.TabIndex = 3;
            this.dtgvItensVenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvItensVenda_RowsAdded);
            this.dtgvItensVenda.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvItensVenda_RowsRemoved);
            this.dtgvItensVenda.SelectionChanged += new System.EventHandler(this.dtgvItensVenda_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnRemoveItem);
            this.groupBox3.Controls.Add(this.dtgvItensVenda);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 353);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Itens da venda";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::infoGym.Properties.Resources.cancel_48;
            this.btnClear.Location = new System.Drawing.Point(9, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 54);
            this.btnClear.TabIndex = 5;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Image = global::infoGym.Properties.Resources.edit_remove;
            this.btnRemoveItem.Location = new System.Drawing.Point(274, 293);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 54);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // cbbFormaPgmto
            // 
            this.cbbFormaPgmto.FormattingEnabled = true;
            this.cbbFormaPgmto.Items.AddRange(new object[] {
            "À vista",
            "Na mensalidade"});
            this.cbbFormaPgmto.Location = new System.Drawing.Point(514, 172);
            this.cbbFormaPgmto.Name = "cbbFormaPgmto";
            this.cbbFormaPgmto.Size = new System.Drawing.Size(111, 21);
            this.cbbFormaPgmto.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(416, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Forma pagamento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDataVenda);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.lblQuemRealizou);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblValorTotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.lblQtdeItens);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(410, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 134);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações da venda";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenda.Location = new System.Drawing.Point(122, 63);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(19, 13);
            this.lblDataVenda.TabIndex = 7;
            this.lblDataVenda.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Data:";
            // 
            // lblQuemRealizou
            // 
            this.lblQuemRealizou.AutoSize = true;
            this.lblQuemRealizou.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuemRealizou.Location = new System.Drawing.Point(122, 80);
            this.lblQuemRealizou.Name = "lblQuemRealizou";
            this.lblQuemRealizou.Size = new System.Drawing.Size(19, 13);
            this.lblQuemRealizou.TabIndex = 5;
            this.lblQuemRealizou.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Quem realizou:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(121, 45);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(19, 13);
            this.lblValorTotal.TabIndex = 3;
            this.lblValorTotal.Text = "---";
            this.lblValorTotal.TextChanged += new System.EventHandler(this.lblValorTotal_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Valor total:";
            // 
            // lblQtdeItens
            // 
            this.lblQtdeItens.AutoSize = true;
            this.lblQtdeItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeItens.Location = new System.Drawing.Point(121, 26);
            this.lblQtdeItens.Name = "lblQtdeItens";
            this.lblQtdeItens.Size = new System.Drawing.Size(19, 13);
            this.lblQtdeItens.TabIndex = 1;
            this.lblQtdeItens.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Qtde de itens vendidos:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::infoGym.Properties.Resources.apply;
            this.btnConfirmar.Location = new System.Drawing.Point(613, 394);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(148, 128);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Produto";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "qtde";
            this.quantidade.HeaderText = "Qtde";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 50;
            // 
            // preco_unit
            // 
            this.preco_unit.DataPropertyName = "preco_unit";
            this.preco_unit.HeaderText = "Preço unitário";
            this.preco_unit.Name = "preco_unit";
            this.preco_unit.ReadOnly = true;
            this.preco_unit.Width = 50;
            // 
            // subttotal
            // 
            this.subttotal.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.subttotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.subttotal.HeaderText = "Valor";
            this.subttotal.Name = "subttotal";
            this.subttotal.ReadOnly = true;
            this.subttotal.Width = 50;
            // 
            // prod_id
            // 
            this.prod_id.DataPropertyName = "prod_id";
            this.prod_id.HeaderText = "id";
            this.prod_id.Name = "prod_id";
            this.prod_id.ReadOnly = true;
            this.prod_id.Visible = false;
            // 
            // frmVendaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbFormaPgmto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmVendaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttbQtde)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItensVenda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.TextBox ttbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbValor;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAluAdd;
        private System.Windows.Forms.TextBox ttbAluNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgvItensVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ttbQtde;
        private System.Windows.Forms.ComboBox cbbFormaPgmto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblQtdeItens;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblQuemRealizou;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subttotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_id;
    }
}