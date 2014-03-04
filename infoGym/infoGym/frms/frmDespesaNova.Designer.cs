namespace infoGym
{
    partial class frmDespesaNova
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
            this.label1 = new System.Windows.Forms.Label();
            this.ttbDesc = new System.Windows.Forms.RichTextBox();
            this.gpbSituacao = new System.Windows.Forms.GroupBox();
            this.rbPaga = new System.Windows.Forms.RadioButton();
            this.rbApagar = new System.Windows.Forms.RadioButton();
            this.gpbPagamento = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbValorPgmto = new System.Windows.Forms.TextBox();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVcmto = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbValor = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpbSituacao.SuspendLayout();
            this.gpbPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // ttbDesc
            // 
            this.ttbDesc.Location = new System.Drawing.Point(15, 35);
            this.ttbDesc.MaxLength = 100;
            this.ttbDesc.Name = "ttbDesc";
            this.ttbDesc.Size = new System.Drawing.Size(265, 59);
            this.ttbDesc.TabIndex = 1;
            this.ttbDesc.Tag = "1";
            this.ttbDesc.Text = "";
            // 
            // gpbSituacao
            // 
            this.gpbSituacao.Controls.Add(this.rbPaga);
            this.gpbSituacao.Controls.Add(this.rbApagar);
            this.gpbSituacao.Location = new System.Drawing.Point(364, 19);
            this.gpbSituacao.Name = "gpbSituacao";
            this.gpbSituacao.Size = new System.Drawing.Size(200, 75);
            this.gpbSituacao.TabIndex = 2;
            this.gpbSituacao.TabStop = false;
            this.gpbSituacao.Text = "Situação";
            // 
            // rbPaga
            // 
            this.rbPaga.AutoSize = true;
            this.rbPaga.Location = new System.Drawing.Point(109, 19);
            this.rbPaga.Name = "rbPaga";
            this.rbPaga.Size = new System.Drawing.Size(50, 17);
            this.rbPaga.TabIndex = 1;
            this.rbPaga.TabStop = true;
            this.rbPaga.Text = "Paga";
            this.rbPaga.UseVisualStyleBackColor = true;
            this.rbPaga.CheckedChanged += new System.EventHandler(this.rbApagar_CheckedChanged);
            // 
            // rbApagar
            // 
            this.rbApagar.AutoSize = true;
            this.rbApagar.Location = new System.Drawing.Point(9, 19);
            this.rbApagar.Name = "rbApagar";
            this.rbApagar.Size = new System.Drawing.Size(62, 17);
            this.rbApagar.TabIndex = 0;
            this.rbApagar.TabStop = true;
            this.rbApagar.Text = "A pagar";
            this.rbApagar.UseVisualStyleBackColor = true;
            this.rbApagar.CheckedChanged += new System.EventHandler(this.rbApagar_CheckedChanged);
            // 
            // gpbPagamento
            // 
            this.gpbPagamento.Controls.Add(this.label3);
            this.gpbPagamento.Controls.Add(this.ttbValorPgmto);
            this.gpbPagamento.Controls.Add(this.dtpPagamento);
            this.gpbPagamento.Controls.Add(this.label2);
            this.gpbPagamento.Location = new System.Drawing.Point(15, 256);
            this.gpbPagamento.Name = "gpbPagamento";
            this.gpbPagamento.Size = new System.Drawing.Size(265, 100);
            this.gpbPagamento.TabIndex = 3;
            this.gpbPagamento.TabStop = false;
            this.gpbPagamento.Text = "Pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor Pago";
            // 
            // ttbValorPgmto
            // 
            this.ttbValorPgmto.Location = new System.Drawing.Point(92, 49);
            this.ttbValorPgmto.Name = "ttbValorPgmto";
            this.ttbValorPgmto.Size = new System.Drawing.Size(74, 20);
            this.ttbValorPgmto.TabIndex = 2;
            this.ttbValorPgmto.Tag = "2";
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagamento.Location = new System.Drawing.Point(92, 23);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(98, 20);
            this.dtpPagamento.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data pagamento";
            // 
            // dtpVcmto
            // 
            this.dtpVcmto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVcmto.Location = new System.Drawing.Point(76, 125);
            this.dtpVcmto.Name = "dtpVcmto";
            this.dtpVcmto.Size = new System.Drawing.Size(98, 20);
            this.dtpVcmto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor";
            // 
            // ttbValor
            // 
            this.ttbValor.Location = new System.Drawing.Point(76, 157);
            this.ttbValor.Name = "ttbValor";
            this.ttbValor.Size = new System.Drawing.Size(74, 20);
            this.ttbValor.TabIndex = 4;
            this.ttbValor.Tag = "1";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::infoGym.Properties.Resources.apply;
            this.btnConfirmar.Location = new System.Drawing.Point(421, 238);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(143, 118);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Tag = "";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmDespesaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 368);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.ttbValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpVcmto);
            this.Controls.Add(this.gpbPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpbSituacao);
            this.Controls.Add(this.ttbDesc);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(592, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(592, 406);
            this.Name = "frmDespesaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento Despesa";
            this.gpbSituacao.ResumeLayout(false);
            this.gpbSituacao.PerformLayout();
            this.gpbPagamento.ResumeLayout(false);
            this.gpbPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ttbDesc;
        private System.Windows.Forms.GroupBox gpbSituacao;
        private System.Windows.Forms.RadioButton rbPaga;
        private System.Windows.Forms.RadioButton rbApagar;
        private System.Windows.Forms.GroupBox gpbPagamento;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbValorPgmto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpVcmto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbValor;
        private System.Windows.Forms.Button btnConfirmar;
    }
}