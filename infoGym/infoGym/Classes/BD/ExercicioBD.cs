using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class ExercicioBD
    {
        bool result;
        DataTable dt;
        String sql;
        Banco bco;
        public ExercicioBD()
        {
            bco = new Banco();
        }

        public bool novo(Exercicio exe)
        {
            sql = "INSERT INTO exercicio(exe_desc, exe_area) "+
            "VALUES ('@1', '@2')";
            sql = sql.Replace("@1", exe.Desc);
            sql = sql.Replace("@2", exe.Area);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool altera(Exercicio exe)
        {
            sql = "UPDATE exercicio SET exe_desc='@2', exe_area='@3'"+
            " WHERE exe_id = '@1'";
            sql = sql.Replace("@1", exe.Id);
            sql = sql.Replace("@2", exe.Desc);
            sql = sql.Replace("@3", exe.Area);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool exclui(String id)
        {
            sql = "DELETE FROM exercicio WHERE exe_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getTotal()
        {
            String result = "";
            sql = "SELECT exe_id FROM exercicio";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = "" + dt.Rows.Count;
            return result;
        }

        public DataTable getExercicios(String nome)
        {
            sql = "SELECT * FROM exercicio WHERE exe_desc ILIKE '@1%'";
            sql = sql.Replace("@1", nome);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public Exercicio getById(String id)
        {
            Exercicio exe = new Exercicio();
            sql = "SELECT * FROM exercicio WHERE exe_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            exe.Id = id;
            exe.Desc = dt.Rows[0]["exe_desc"].ToString();
            exe.Area = dt.Rows[0]["exe_area"].ToString();
            return exe;
        }
    }
}
