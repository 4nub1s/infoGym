using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Npgsql;

namespace CadastroCidadesEstados
{
    class Banco
    {
        String strcon = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=postgres123;Database=infoGym;";
        String DataBase;
        String Login;
        String Password;
        String IpServer;
        String Porta;
        NpgsqlConnection con;
        public Banco(String IpServer, String Porta, String Login, String Password, String DataBase)
        {
            this.IpServer = IpServer;
            this.Porta = Porta;
            this.Login = Login;
            this.Password = Password;
            this.DataBase = DataBase;
            strcon = "Server=" + IpServer + ";" + "Port=" + Porta + ";" + "User Id=" + Login + ";" + "Password=" + Password + ";" + "Database=" + DataBase + ";";
        }
        public bool conecta()
        {
            bool resultado = false;
            try
            {
                con = new NpgsqlConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception Caught.", ex);
            }
            return resultado;
        }

        public void desconecta() //con!=null existe uma conexao 
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
            }
        }

        public bool executeNonQuery(String sql, params Object[] parametros)//metodo com comando sql
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.Add(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery(); //não retorna dados so retorna se deu certo ou nao
                return true;
            }
            catch
            {
                return false;
            }
        }
		
		public bool executeQuery(String sql, out DataTable dt, params Object[] parametros) //metodo que retorna v ou f joga pro adaptador e carrega no dataTable
        {
            dt = new DataTable();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.Add(parametros[i].ToString(), parametros[i + 1]);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
