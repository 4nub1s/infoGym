namespace infoGym
{
    partial class frmVendaControlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvVendas = new System.Windows.Forms.DataGridView();
            this.ven_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ven_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alu_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblProdMaisVendido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVendasRealizadas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserLogado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendas)).BeginInit();
            this.gpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvVendas
            // 
            this.dtgvVendas.AllowUserToAddRows = false;
            this.dtgvVendas.AllowUserToDeleteRows = false;
            this.dtgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ven_cod,
            this.ven_data,
            this.alu_nome,
            this.prod_nome});
            this.dtgvVendas.Location = new System.Drawing.Point(15, 95);
            this.dtgvVendas.Name = "dtgvVendas";
            this.dtgvVendas.ReadOnly = true;
            this.dtgvVendas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvVendas.Size = new System.Drawing.Size(424, 441);
            this.dtgvVendas.TabIndex = 1;
            this.dtgvVendas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvVendas_RowsAdded);
            this.dtgvVendas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvVendas_RowsRemoved);
            this.dtgvVendas.SelectionChanged += new System.EventHandler(this.dtgvVendas_SelectionChanged);
            // 
            // ven_cod
            // 
            this.ven_cod.DataPropertyName = "ven_cod";
            this.ven_cod.HeaderText = "Código";
            this.ven_cod.Name = "ven_cod";
            this.ven_cod.ReadOnly = true;
            this.ven_cod.Width = 50;
            // 
            // ven_data
            // 
            this.ven_data.DataPropertyName = "ven_data";
            dataGridViewCellStyle1.NullValue = null;
            this.ven_data.DefaultCellStyle = dataGridViewCellStyle1;
            this.ven_data.HeaderText = "Data";
            this.ven_data.Name = "ven_data";
            this.ven_data.ReadOnly = true;
            this.ven_data.Width = 80;
            // 
            // alu_nome
            // 
            this.alu_nome.DataPropertyName = "ven_comp";
            dataGridViewCellStyle2.NullValue = "Não aluno";
            this.alu_nome.DefaultCellStyle = dataGridViewCellStyle2;
            this.alu_nome.HeaderText = "Comprador";
            this.alu_nome.Name = "alu_nome";
            this.alu_nome.ReadOnly = true;
            // 
            // prod_nome
            // 
            this.prod_nome.DataPropertyName = "ven_resumo";
            this.prod_nome.HeaderText = "Resumo";
            this.prod_nome.Name = "prod_nome";
            this.prod_nome.ReadOnly = true;
            this.prod_nome.Width = 180;
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblProdMaisVendido);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Controls.Add(this.lblVendasRealizadas);
            this.gpbInfo.Controls.Add(this.label1);
            this.gpbInfo.Location = new System.Drawing.Point(451, 2);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(218, 99);
            this.gpbInfo.TabIndex = 4;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informações";
            // 
            // lblProdMaisVendido
            // 
            this.lblProdMaisVendido.AutoSize = true;
            this.lblProdMaisVendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMaisVendido.Location = new System.Drawing.Point(115, 51);
            this.lblProdMaisVendido.Name = "lblProdMaisVendido";
            this.lblProdMaisVendido.Size = new System.Drawing.Size(19, 13);
            this.lblProdMaisVendido.TabIndex = 3;
            this.lblProdMaisVendido.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Produto mais vendido:";
            // 
            // lblVendasRealizadas
            // 
            this.lblVendasRealizadas.AutoSize = true;
            this.lblVendasRealizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendasRealizadas.Location = new System.Drawing.Point(115, 27);
            this.lblVendasRealizadas.Name = "lblVendasRealizadas";
            this.lblVendasRealizadas.Size = new System.Drawing.Size(19, 13);
            this.lblVendasRealizadas.TabIndex = 1;
            this.lblVendasRealizadas.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendas realizadas:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::infoGym.Properties.Resources.Índice;
            this.pictureBox1.Location = new System.Drawing.Point(445, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 225);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(568, 458);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 78);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Image = global::infoGym.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(445, 458);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(95, 78);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUserLogado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 20);
            this.panel1.TabIndex = 6;
            // 
            // lblUserLogado
            // 
            this.lblUserLogado.AutoSize = true;
            this.lblUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogado.Location = new System.Drawing.Point(82, 4);
            this.lblUserLogado.Name = "lblUserLogado";
            this.lblUserLogado.Size = new System.Drawing.Size(19, 13);
            this.lblUserLogado.TabIndex = 1;
            this.lblUserLogado.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Logado como:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(88, 25);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(95, 20);
            this.dtpInicio.TabIndex = 8;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Entre";
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Controls.Add(this.dtpFim);
            this.gpbFiltros.Controls.Add(this.label4);
            this.gpbFiltros.Controls.Add(this.label2);
            this.gpbFiltros.Controls.Add(this.dtpInicio);
            this.gpbFiltros.Location = new System.Drawing.Point(15, 2);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(430, 87);
            this.gpbFiltros.TabIndex = 10;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Busca por datas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(335, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 36);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(212, 25);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(95, 20);
            this.dtpFim.TabIndex = 11;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "e";
            // 
            // frmVendaControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 564);
            this.Controls.Add(this.gpbFiltros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dtgvVendas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(691, 602);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(691, 602);
            this.Name = "frmVendaControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlar Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVendas)).EndInit();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVendas;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblProdMaisVendido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVendasRealizadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLogado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn alu_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod_nome;
    }
}