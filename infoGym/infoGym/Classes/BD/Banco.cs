using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using Npgsql;

namespace infoGym
{
    class Banco
    {
        String strcon = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=316472;Database=infoGym;";
        NpgsqlConnection con = null;
        NpgsqlTransaction trans = null;
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

        public void beginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void commitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void rollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }
    }
}
