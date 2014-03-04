namespace infoGym
{
    partial class frmUserConexoes
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
            this.lblUser = new System.Windows.Forms.Label();
            this.gpFiltro = new System.Windows.Forms.GroupBox();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.noFiltro = new System.Windows.Forms.CheckBox();
            this.dtgvConexoes = new System.Windows.Forms.DataGridView();
            this.acess_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acess_sai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConexoes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Histórico de conexões do usuário: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(421, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label2";
            // 
            // gpFiltro
            // 
            this.gpFiltro.Controls.Add(this.dtFim);
            this.gpFiltro.Controls.Add(this.label3);
            this.gpFiltro.Controls.Add(this.label2);
            this.gpFiltro.Controls.Add(this.dtInicio);
            this.gpFiltro.Location = new System.Drawing.Point(16, 44);
            this.gpFiltro.Name = "gpFiltro";
            this.gpFiltro.Size = new System.Drawing.Size(305, 66);
            this.gpFiltro.TabIndex = 2;
            this.gpFiltro.TabStop = false;
            this.gpFiltro.Text = "Filtrar conexões";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(170, 18);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(101, 20);
            this.dtFim.TabIndex = 4;
            this.dtFim.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entre";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(44, 18);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(101, 20);
            this.dtInicio.TabIndex = 0;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // noFiltro
            // 
            this.noFiltro.AutoSize = true;
            this.noFiltro.Location = new System.Drawing.Point(476, 120);
            this.noFiltro.Name = "noFiltro";
            this.noFiltro.Size = new System.Drawing.Size(84, 17);
            this.noFiltro.TabIndex = 3;
            this.noFiltro.Text = "Exibir Todas";
            this.noFiltro.UseVisualStyleBackColor = true;
            this.noFiltro.CheckedChanged += new System.EventHandler(this.noFiltro_CheckedChanged);
            // 
            // dtgvConexoes
            // 
            this.dtgvConexoes.AllowUserToAddRows = false;
            this.dtgvConexoes.AllowUserToDeleteRows = false;
            this.dtgvConexoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvConexoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acess_ent,
            this.acess_sai});
            this.dtgvConexoes.Location = new System.Drawing.Point(115, 143);
            this.dtgvConexoes.Name = "dtgvConexoes";
            this.dtgvConexoes.ReadOnly = true;
            this.dtgvConexoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvConexoes.Size = new System.Drawing.Size(445, 369);
            this.dtgvConexoes.TabIndex = 4;
            // 
            // acess_ent
            // 
            this.acess_ent.DataPropertyName = "acess_ent";
            this.acess_ent.HeaderText = "Entrada";
            this.acess_ent.MinimumWidth = 200;
            this.acess_ent.Name = "acess_ent";
            this.acess_ent.ReadOnly = true;
            this.acess_ent.Width = 200;
            // 
            // acess_sai
            // 
            this.acess_sai.DataPropertyName = "acess_sai";
            this.acess_sai.HeaderText = "Saída";
            this.acess_sai.MinimumWidth = 200;
            this.acess_sai.Name = "acess_sai";
            this.acess_sai.ReadOnly = true;
            this.acess_sai.Width = 200;
            // 
            // frmUserConexoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 562);
            this.Controls.Add(this.dtgvConexoes);
            this.Controls.Add(this.noFiltro);
            this.Controls.Add(this.gpFiltro);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(692, 600);
            this.Name = "frmUserConexoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico de Conexões";
            this.gpFiltro.ResumeLayout(false);
            this.gpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvConexoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox gpFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.CheckBox noFiltro;
        private System.Windows.Forms.DataGridView dtgvConexoes;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn acess_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn acess_sai;
    }
}