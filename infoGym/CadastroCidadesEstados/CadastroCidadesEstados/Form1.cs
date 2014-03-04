using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CadastroCidadesEstados
{
    public partial class Form1 : Form
    {
        String IpServer, Porta, Login, Password, DataBase;
        List<String> estadosComCidades;
        List<String> estados;
        public Form1()
        {
            InitializeComponent();
            estados = new List<String>();
            estadosComCidades = new List<String>();
            estadosComCidades.Add("SP");
            estadosComCidades.Add("MG");
            estadosComCidades.Add("MS");
            estadosComCidades.Add("MT");
            estadosComCidades.Add("RJ");
            
            ttbScript.Text += "CREATE TABLE estado ( \n" +
                "est_cod serial NOT NULL, " +
                "\nest_sigla character varying(2) NOT NULL, " +
                "\nPRIMARY KEY (est_cod)" + "\n)\n";
            ttbScript.Text += "CREATE TABLE cidade ( \n"+
                "cid_cod serial NOT NULL, " +
                "\nest_cod integer NULL, " +
                "\ncid_nome character varying(100) NOT NULL, " +
                "\nPRIMARY KEY (cid_cod), " +
                "\nFOREIGN KEY (est_cod) REFERENCES estado" +
                "\n);";
        }


        private void ttbBase_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            String sql = "";
            DataTable dt = null;
            bool result = true;
            if (ttbDataBase.Text == "")
                ttbDataBase.BackColor = Color.Red;
            if (ttbIp.Text == "")
                ttbIp.BackColor = Color.Red;
            if (ttbLogin.Text == "")
                ttbLogin.BackColor = Color.Red;
            if (ttbPass.Text == "")
                ttbPass.BackColor = Color.Red;
            if (ttbPorta.Text == "")
                ttbPorta.BackColor = Color.Red;
            if (ttbDataBase.Text != "" && ttbIp.Text != "" && ttbLogin.Text != "" && ttbPass.Text != "" && ttbPorta.Text != "")
            {
                this.Cursor = Cursors.WaitCursor;
                Banco bco = new Banco(ttbIp.Text, ttbPorta.Text, ttbLogin.Text, ttbPass.Text, ttbDataBase.Text);
                if (bco.conecta())
                {
                    sql = "SELECT COUNT(est_cod) as cont FROM estado";
                    bco.executeQuery(sql, out dt);
                    if (Convert.ToInt32(dt.Rows[0]["cont"]) >= 27)
                        MessageBox.Show("Estados já cadastrados!", "Operação não realizada!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        StreamReader rd;
                        rd = new StreamReader("estados.txt");
                        while (!rd.EndOfStream)
                        {
                            String linha = rd.ReadLine();
                            estados.Add(linha);
                            sql = "INSERT INTO estado (est_sigla) VALUES('@1')";
                            sql = sql.Replace("@1", linha);
                            result = bco.executeNonQuery(sql);
                        }
                        rd.Close();

                        foreach (String s in estados)
                        {
                            rd = new StreamReader(s + ".txt");
                            sql = "SELECT est_cod FROM estado WHERE est_sigla = '@1'";
                            sql = sql.Replace("@1", s);
                            result = bco.executeQuery(sql, out dt);
                            String estCod = "";
                            if (dt != null)
                                estCod = "" + dt.Rows[0]["est_cod"];
                            while (!rd.EndOfStream)
                            {
                                String linha = rd.ReadLine();
                                sql = "INSERT INTO cidade (est_cod, cid_nome) VALUES(@1, '@2')";
                                sql = sql.Replace("@1", estCod);
                                sql = sql.Replace("@2", linha);
                                result = bco.executeNonQuery(sql);
                            }
                            rd.Close();
                        }

                        bco.desconecta();
                        this.Cursor = Cursors.Default;
                        if (result)
                            MessageBox.Show("Operação realizada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bco.desconecta();
                    this.Cursor = Cursors.Default;
                }
                else
                    MessageBox.Show("Sem conexão com o banco, verifique os dados e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
