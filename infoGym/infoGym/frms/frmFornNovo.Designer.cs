namespace infoGym
{
    partial class frmFornNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornNovo));
            this.ttbSite = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ttbCEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ttbNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ttbBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttbRua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ttbCel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ttbCelDDD = new System.Windows.Forms.TextBox();
            this.ttbFone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttbFoneDDD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ttbRepresentante = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ttbEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ttbInscEst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ttbRazaoS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttbSite
            // 
            this.ttbSite.Location = new System.Drawing.Point(96, 106);
            this.ttbSite.Name = "ttbSite";
            this.ttbSite.Size = new System.Drawing.Size(258, 20);
            this.ttbSite.TabIndex = 9;
            this.ttbSite.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbCidade);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbbEstado);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ttbCEP);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ttbNum);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ttbBairro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ttbRua);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 128);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(228, 85);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(189, 21);
            this.cbbCidade.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cidade";
            // 
            // cbbEstado
            // 
            this.cbbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(114, 85);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(42, 21);
            this.cbbEstado.Sorted = true;
            this.cbbEstado.TabIndex = 9;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // ttbCEP
            // 
            this.ttbCEP.Location = new System.Drawing.Point(356, 54);
            this.ttbCEP.Mask = "00,000,000";
            this.ttbCEP.Name = "ttbCEP";
            this.ttbCEP.Size = new System.Drawing.Size(61, 20);
            this.ttbCEP.TabIndex = 7;
            this.ttbCEP.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "CEP";
            // 
            // ttbNum
            // 
            this.ttbNum.Location = new System.Drawing.Point(357, 22);
            this.ttbNum.MaxLength = 10;
            this.ttbNum.Name = "ttbNum";
            this.ttbNum.Size = new System.Drawing.Size(60, 20);
            this.ttbNum.TabIndex = 5;
            this.ttbNum.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nº";
            // 
            // ttbBairro
            // 
            this.ttbBairro.Location = new System.Drawing.Point(114, 55);
            this.ttbBairro.MaxLength = 30;
            this.ttbBairro.Name = "ttbBairro";
            this.ttbBairro.Size = new System.Drawing.Size(199, 20);
            this.ttbBairro.TabIndex = 3;
            this.ttbBairro.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bairro";
            // 
            // ttbRua
            // 
            this.ttbRua.Location = new System.Drawing.Point(114, 22);
            this.ttbRua.MaxLength = 30;
            this.ttbRua.Name = "ttbRua";
            this.ttbRua.Size = new System.Drawing.Size(199, 20);
            this.ttbRua.TabIndex = 1;
            this.ttbRua.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rua";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ttbCel);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.ttbCelDDD);
            this.groupBox4.Controls.Add(this.ttbFone);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.ttbFoneDDD);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.ttbSite);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ttbRepresentante);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.ttbEmail);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 145);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contato";
            // 
            // ttbCel
            // 
            this.ttbCel.Location = new System.Drawing.Point(290, 50);
            this.ttbCel.MaxLength = 9;
            this.ttbCel.Name = "ttbCel";
            this.ttbCel.Size = new System.Drawing.Size(64, 20);
            this.ttbCel.TabIndex = 17;
            this.ttbCel.Click += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbCel.Enter += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbFoneDDD_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(280, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "-";
            // 
            // ttbCelDDD
            // 
            this.ttbCelDDD.Location = new System.Drawing.Point(259, 50);
            this.ttbCelDDD.MaxLength = 2;
            this.ttbCelDDD.Name = "ttbCelDDD";
            this.ttbCelDDD.Size = new System.Drawing.Size(20, 20);
            this.ttbCelDDD.TabIndex = 15;
            this.ttbCelDDD.Click += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbCelDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbFoneDDD_KeyPress);
            // 
            // ttbFone
            // 
            this.ttbFone.Location = new System.Drawing.Point(127, 50);
            this.ttbFone.MaxLength = 9;
            this.ttbFone.Name = "ttbFone";
            this.ttbFone.Size = new System.Drawing.Size(64, 20);
            this.ttbFone.TabIndex = 14;
            this.ttbFone.Click += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbFone.Enter += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbFoneDDD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "-";
            // 
            // ttbFoneDDD
            // 
            this.ttbFoneDDD.Location = new System.Drawing.Point(96, 50);
            this.ttbFoneDDD.MaxLength = 2;
            this.ttbFoneDDD.Name = "ttbFoneDDD";
            this.ttbFoneDDD.Size = new System.Drawing.Size(20, 20);
            this.ttbFoneDDD.TabIndex = 12;
            this.ttbFoneDDD.Click += new System.EventHandler(this.ttbRazaoS_Click);
            this.ttbFoneDDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttbFoneDDD_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Celular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Site";
            // 
            // ttbRepresentante
            // 
            this.ttbRepresentante.Location = new System.Drawing.Point(96, 22);
            this.ttbRepresentante.MaxLength = 60;
            this.ttbRepresentante.Name = "ttbRepresentante";
            this.ttbRepresentante.Size = new System.Drawing.Size(258, 20);
            this.ttbRepresentante.TabIndex = 7;
            this.ttbRepresentante.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Representante";
            // 
            // ttbEmail
            // 
            this.ttbEmail.Location = new System.Drawing.Point(96, 76);
            this.ttbEmail.Name = "ttbEmail";
            this.ttbEmail.Size = new System.Drawing.Size(258, 20);
            this.ttbEmail.TabIndex = 5;
            this.ttbEmail.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Telefone";
            // 
            // ttbInscEst
            // 
            this.ttbInscEst.Location = new System.Drawing.Point(114, 52);
            this.ttbInscEst.MaxLength = 100;
            this.ttbInscEst.Name = "ttbInscEst";
            this.ttbInscEst.Size = new System.Drawing.Size(291, 20);
            this.ttbInscEst.TabIndex = 12;
            this.ttbInscEst.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inscrição Estadual";
            // 
            // ttbRazaoS
            // 
            this.ttbRazaoS.Location = new System.Drawing.Point(114, 25);
            this.ttbRazaoS.MaxLength = 100;
            this.ttbRazaoS.Name = "ttbRazaoS";
            this.ttbRazaoS.Size = new System.Drawing.Size(291, 20);
            this.ttbRazaoS.TabIndex = 10;
            this.ttbRazaoS.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Razão Social";
            // 
            // ttbCNPJ
            // 
            this.ttbCNPJ.Location = new System.Drawing.Point(114, 79);
            this.ttbCNPJ.Mask = "00,000,000/0000-00";
            this.ttbCNPJ.Name = "ttbCNPJ";
            this.ttbCNPJ.Size = new System.Drawing.Size(108, 20);
            this.ttbCNPJ.TabIndex = 8;
            this.ttbCNPJ.Click += new System.EventHandler(this.ttbRazaoS_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CNPJ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ttbInscEst);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ttbRazaoS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttbCNPJ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 120);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados empresa";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::infoGym.Properties.Resources.add_48x48;
            this.btnCadastrar.Location = new System.Drawing.Point(638, 295);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 134);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh_48x48.png");
            // 
            // frmFornNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 471);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 471);
            this.Name = "frmFornNovo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ttbSite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox ttbCEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ttbNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ttbBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttbRua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ttbRepresentante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttbEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ttbInscEst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttbRazaoS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox ttbCNPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox ttbFone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttbFoneDDD;
        private System.Windows.Forms.TextBox ttbCel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ttbCelDDD;
    }
}