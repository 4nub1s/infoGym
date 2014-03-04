namespace infoGym
{
    partial class frmDiariaPgmto
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
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbValorDesc = new System.Windows.Forms.TextBox();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.lblValorDiaria = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMatDtIni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMatCod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreditosAtuais = new System.Windows.Forms.Label();
            this.gpbCreditos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSaldoCreditos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            this.gpbCreditos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.ForeColor = System.Drawing.Color.Red;
            this.lblValorFinal.Location = new System.Drawing.Point(109, 220);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(28, 24);
            this.lblValorFinal.TabIndex = 37;
            this.lblValorFinal.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Valor final:";
            // 
            // ttbValorDesc
            // 
            this.ttbValorDesc.Location = new System.Drawing.Point(123, 156);
            this.ttbValorDesc.MaxLength = 10;
            this.ttbValorDesc.Name = "ttbValorDesc";
            this.ttbValorDesc.Size = new System.Drawing.Size(74, 20);
            this.ttbValorDesc.TabIndex = 35;
            this.ttbValorDesc.Visible = false;
            this.ttbValorDesc.TextChanged += new System.EventHandler(this.ttbValorDesc_TextChanged);
            this.ttbValorDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbValorDesc_KeyPress);
            // 
            // chkDesc
            // 
            this.chkDesc.AutoSize = true;
            this.chkDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDesc.Location = new System.Drawing.Point(16, 151);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(109, 28);
            this.chkDesc.TabIndex = 34;
            this.chkDesc.Text = "Desconto";
            this.chkDesc.UseVisualStyleBackColor = true;
            this.chkDesc.CheckedChanged += new System.EventHandler(this.chkDesc_CheckedChanged);
            // 
            // lblValorDiaria
            // 
            this.lblValorDiaria.AutoSize = true;
            this.lblValorDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDiaria.Location = new System.Drawing.Point(120, 115);
            this.lblValorDiaria.Name = "lblValorDiaria";
            this.lblValorDiaria.Size = new System.Drawing.Size(28, 24);
            this.lblValorDiaria.TabIndex = 32;
            this.lblValorDiaria.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Valor diária:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMatDtIni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMatCod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 68);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrícula";
            // 
            // lblMatDtIni
            // 
            this.lblMatDtIni.AutoSize = true;
            this.lblMatDtIni.Location = new System.Drawing.Point(86, 44);
            this.lblMatDtIni.Name = "lblMatDtIni";
            this.lblMatDtIni.Size = new System.Drawing.Size(16, 13);
            this.lblMatDtIni.TabIndex = 5;
            this.lblMatDtIni.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iniciada em:";
            // 
            // lblMatCod
            // 
            this.lblMatCod.AutoSize = true;
            this.lblMatCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatCod.Location = new System.Drawing.Point(85, 16);
            this.lblMatCod.Name = "lblMatCod";
            this.lblMatCod.Size = new System.Drawing.Size(19, 13);
            this.lblMatCod.TabIndex = 1;
            this.lblMatCod.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblUserOn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 335);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 27);
            this.panel1.TabIndex = 27;
            // 
            // lblUserOn
            // 
            this.lblUserOn.AutoSize = true;
            this.lblUserOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOn.Location = new System.Drawing.Point(83, 6);
            this.lblUserOn.Name = "lblUserOn";
            this.lblUserOn.Size = new System.Drawing.Size(19, 13);
            this.lblUserOn.TabIndex = 1;
            this.lblUserOn.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logado como:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::infoGym.Properties.Resources.apply;
            this.btnConfirmar.Location = new System.Drawing.Point(299, 215);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 114);
            this.btnConfirmar.TabIndex = 38;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(86, 37);
            this.numDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(50, 20);
            this.numDias.TabIndex = 39;
            this.numDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDias.ValueChanged += new System.EventHandler(this.numDias_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Créditos atuais:";
            // 
            // lblCreditosAtuais
            // 
            this.lblCreditosAtuais.AutoSize = true;
            this.lblCreditosAtuais.Location = new System.Drawing.Point(83, 16);
            this.lblCreditosAtuais.Name = "lblCreditosAtuais";
            this.lblCreditosAtuais.Size = new System.Drawing.Size(16, 13);
            this.lblCreditosAtuais.TabIndex = 42;
            this.lblCreditosAtuais.Text = "---";
            // 
            // gpbCreditos
            // 
            this.gpbCreditos.Controls.Add(this.lblSaldoCreditos);
            this.gpbCreditos.Controls.Add(this.label7);
            this.gpbCreditos.Controls.Add(this.label2);
            this.gpbCreditos.Controls.Add(this.numDias);
            this.gpbCreditos.Controls.Add(this.lblCreditosAtuais);
            this.gpbCreditos.Controls.Add(this.label4);
            this.gpbCreditos.Location = new System.Drawing.Point(239, 100);
            this.gpbCreditos.Name = "gpbCreditos";
            this.gpbCreditos.Size = new System.Drawing.Size(200, 100);
            this.gpbCreditos.TabIndex = 43;
            this.gpbCreditos.TabStop = false;
            this.gpbCreditos.Text = "Crédito(dias)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Adicionar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Saldo";
            // 
            // lblSaldoCreditos
            // 
            this.lblSaldoCreditos.AutoSize = true;
            this.lblSaldoCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCreditos.Location = new System.Drawing.Point(83, 66);
            this.lblSaldoCreditos.Name = "lblSaldoCreditos";
            this.lblSaldoCreditos.Size = new System.Drawing.Size(19, 13);
            this.lblSaldoCreditos.TabIndex = 45;
            this.lblSaldoCreditos.Text = "---";
            // 
            // frmDiariaPgmto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 362);
            this.Controls.Add(this.gpbCreditos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ttbValorDesc);
            this.Controls.Add(this.chkDesc);
            this.Controls.Add(this.lblValorDiaria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(467, 400);
            this.Name = "frmDiariaPgmto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Créditos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            this.gpbCreditos.ResumeLayout(false);
            this.gpbCreditos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbValorDesc;
        private System.Windows.Forms.CheckBox chkDesc;
        private System.Windows.Forms.Label lblValorDiaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMatDtIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMatCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreditosAtuais;
        private System.Windows.Forms.GroupBox gpbCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldoCreditos;
        private System.Windows.Forms.Label label7;
    }
}