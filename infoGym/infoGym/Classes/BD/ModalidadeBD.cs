using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class ModalidadeBD
    {
        Banco bco;
        String sql;
        DataTable dt = null;
        bool result;
        public ModalidadeBD()
        {
            bco = new Banco();
        }

        public bool nova(Modalidade mod)
        {
            sql = "INSERT INTO modalidade(mod_desc, mod_valorm, mod_valord) " +
            "VALUES ('@1', '@2', '@3')";
            sql = sql.Replace("@1", mod.Desc);
            sql = sql.Replace("@2", mod.ValorM);
            sql = sql.Replace("@3", mod.ValorD);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool altera(Modalidade mod)
        {
            sql = "UPDATE modalidade SET mod_desc='@1', mod_valorm='@2', mod_valord='@3' " +
            "WHERE mod_id = '@4'";
            sql = sql.Replace("@1", mod.Desc);
            sql = sql.Replace("@2", mod.ValorM);
            sql = sql.Replace("@3", mod.ValorD);
            sql = sql.Replace("@4", mod.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool exclui(String id)
        {
            sql = "DELETE FROM modalidade WHERE mod_id = '@1'";
            sql = sql.Replace("@1", id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getTotal()
        {
            String result = "";
            sql = "SELECT mod_id FROM modalidade";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = "" + dt.Rows.Count;
            return result;
        }

        public DataTable getModalidades(String nome)
        {
            sql = "SELECT * FROM modalidade WHERE mod_desc ILIKE '@1%'";
            sql = sql.Replace("@1", nome);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public Modalidade getById(String id)
        {
            Modalidade mod = new Modalidade();
            sql = "SELECT * FROM modalidade WHERE mod_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            mod.Id = id;
            mod.Desc = dt.Rows[0]["mod_desc"].ToString();
            mod.ValorM = dt.Rows[0]["mod_valorm"].ToString();
            mod.ValorD = dt.Rows[0]["mod_valord"].ToString();
            return mod;
        }
    }
}
