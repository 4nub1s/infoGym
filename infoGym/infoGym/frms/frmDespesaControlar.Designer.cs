namespace infoGym
{
    partial class frmDespesaControlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesaControlar));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dtgvDesp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttbDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSituação = new System.Windows.Forms.ComboBox();
            this.gpbPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVcmto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPgmto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desp_valorpg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispago = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkPeriodo = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDesp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbPeriodo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::infoGym.Properties.Resources.remove_48x48;
            this.btnExcluir.Location = new System.Drawing.Point(61, 490);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 60);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::infoGym.Properties.Resources.refresh_48x48;
            this.btnAlterar.Location = new System.Drawing.Point(325, 490);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 60);
            this.btnAlterar.TabIndex = 31;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnNovo.Location = new System.Drawing.Point(581, 490);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 60);
            this.btnNovo.TabIndex = 30;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtgvDesp
            // 
            this.dtgvDesp.AllowUserToAddRows = false;
            this.dtgvDesp.AllowUserToDeleteRows = false;
            this.dtgvDesp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDesp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desc,
            this.dtVcmto,
            this.desp_valor,
            this.dtPgmto,
            this.desp_valorpg,
            this.ispago,
            this.id});
            this.dtgvDesp.Location = new System.Drawing.Point(61, 192);
            this.dtgvDesp.Name = "dtgvDesp";
            this.dtgvDesp.ReadOnly = true;
            this.dtgvDesp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvDesp.Size = new System.Drawing.Size(635, 292);
            this.dtgvDesp.TabIndex = 33;
            this.dtgvDesp.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvDesp_RowsAdded);
            this.dtgvDesp.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvDesp_RowsRemoved);
            this.dtgvDesp.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgvDesp_RowStateChanged);
            this.dtgvDesp.SelectionChanged += new System.EventHandler(this.dtgvDesp_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPeriodo);
            this.groupBox1.Controls.Add(this.ttbDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbSituação);
            this.groupBox1.Controls.Add(this.gpbPeriodo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(61, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 174);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // ttbDesc
            // 
            this.ttbDesc.Location = new System.Drawing.Point(263, 97);
            this.ttbDesc.Name = "ttbDesc";
            this.ttbDesc.Size = new System.Drawing.Size(172, 20);
            this.ttbDesc.TabIndex = 5;
            this.ttbDesc.TextChanged += new System.EventHandler(this.ttbDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Situação";
            // 
            // cbbSituação
            // 
            this.cbbSituação.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSituação.FormattingEnabled = true;
            this.cbbSituação.Items.AddRange(new object[] {
            "Todas",
            "Pagas",
            "Não pagas",
            "Pendentes"});
            this.cbbSituação.Location = new System.Drawing.Point(66, 97);
            this.cbbSituação.Name = "cbbSituação";
            this.cbbSituação.Size = new System.Drawing.Size(121, 21);
            this.cbbSituação.TabIndex = 2;
            // 
            // gpbPeriodo
            // 
            this.gpbPeriodo.Controls.Add(this.dtpFim);
            this.gpbPeriodo.Controls.Add(this.label2);
            this.gpbPeriodo.Controls.Add(this.dtpInicio);
            this.gpbPeriodo.Controls.Add(this.label1);
            this.gpbPeriodo.Location = new System.Drawing.Point(18, 19);
            this.gpbPeriodo.Name = "gpbPeriodo";
            this.gpbPeriodo.Size = new System.Drawing.Size(345, 63);
            this.gpbPeriodo.TabIndex = 1;
            this.gpbPeriodo.TabStop = false;
            this.gpbPeriodo.Text = "Período vencimento";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(176, 16);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(103, 20);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "e";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(44, 16);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpInicio.TabIndex = 1;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::infoGym.Properties.Resources.search_24x24;
            this.btnBuscar.Location = new System.Drawing.Point(363, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 42);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalPagar);
            this.groupBox2.Controls.Add(this.lblTotalGeral);
            this.groupBox2.Controls.Add(this.lblTotalPago);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(524, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 174);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações por período";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "apply.ico");
            this.imageList1.Images.SetKeyName(1, "button_ok.png");
            // 
            // desc
            // 
            this.desc.DataPropertyName = "desp_desc";
            this.desc.HeaderText = "Descrição";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // dtVcmto
            // 
            this.dtVcmto.DataPropertyName = "desp_dtvenc";
            this.dtVcmto.HeaderText = "Vencimento";
            this.dtVcmto.Name = "dtVcmto";
            this.dtVcmto.ReadOnly = true;
            // 
            // desp_valor
            // 
            this.desp_valor.DataPropertyName = "desp_valor";
            this.desp_valor.HeaderText = "Valor a pagar";
            this.desp_valor.Name = "desp_valor";
            this.desp_valor.ReadOnly = true;
            // 
            // dtPgmto
            // 
            this.dtPgmto.DataPropertyName = "desp_dtpg";
            this.dtPgmto.HeaderText = "Data pagamento";
            this.dtPgmto.Name = "dtPgmto";
            this.dtPgmto.ReadOnly = true;
            // 
            // desp_valorpg
            // 
            this.desp_valorpg.DataPropertyName = "desp_valorpg";
            this.desp_valorpg.HeaderText = "Valor pago";
            this.desp_valorpg.Name = "desp_valorpg";
            this.desp_valorpg.ReadOnly = true;
            // 
            // ispago
            // 
            this.ispago.DataPropertyName = "ispago";
            this.ispago.HeaderText = "Pago";
            this.ispago.Name = "ispago";
            this.ispago.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "desp_id";
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // chkPeriodo
            // 
            this.chkPeriodo.AutoSize = true;
            this.chkPeriodo.Location = new System.Drawing.Point(369, 19);
            this.chkPeriodo.Name = "chkPeriodo";
            this.chkPeriodo.Size = new System.Drawing.Size(64, 17);
            this.chkPeriodo.TabIndex = 6;
            this.chkPeriodo.Text = "Período";
            this.chkPeriodo.UseVisualStyleBackColor = true;
            this.chkPeriodo.CheckedChanged += new System.EventHandler(this.chkPeriodo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total a pagar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total geral:";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalPago.Location = new System.Drawing.Point(73, 23);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(16, 13);
            this.lblTotalPago.TabIndex = 3;
            this.lblTotalPago.Text = "---";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.ForeColor = System.Drawing.Color.Green;
            this.lblTotalGeral.Location = new System.Drawing.Point(75, 82);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(16, 13);
            this.lblTotalGeral.TabIndex = 4;
            this.lblTotalGeral.Text = "---";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPagar.Location = new System.Drawing.Point(74, 54);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(16, 13);
            this.lblTotalPagar.TabIndex = 5;
            this.lblTotalPagar.Text = "---";
            // 
            // frmDespesaControlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvDesp);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(748, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(748, 600);
            this.Name = "frmDespesaControlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controlar Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDesp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPeriodo.ResumeLayout(false);
            this.gpbPeriodo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dtgvDesp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpbPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSituação;
        private System.Windows.Forms.TextBox ttbDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVcmto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPgmto;
        private System.Windows.Forms.DataGridViewTextBoxColumn desp_valorpg;
        private System.Windows.Forms.DataGridViewImageColumn ispago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.CheckBox chkPeriodo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalGeral;
    }
}