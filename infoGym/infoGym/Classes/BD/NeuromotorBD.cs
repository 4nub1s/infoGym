using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.Negocio;
using System.Data;

namespace infoGym.Classes.BD
{
    class NeuromotorBD
    {
        Banco bco;
        String sql;
        bool result;
        DataTable dt;
        public NeuromotorBD()
        {
            bco = new Banco();
        }

        public Neuromotor getById(String id)
        {
            Neuromotor neuro = new Neuromotor();
            sql = "SELECT * FROM neuromotor WHERE neuro_id=@1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            result = bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                neuro.Id = dt.Rows[0]["neuro_id"].ToString();
                neuro.Flexao = dt.Rows[0]["neuro_flexao"].ToString();
                neuro.Abdominal = dt.Rows[0]["neuro_abdominal"].ToString();
                neuro.Wells = dt.Rows[0]["neuro_banco_wells"].ToString();
                neuro.FlexaoLegenda = dt.Rows[0]["neuro_flexao_legenda"].ToString();
                neuro.AbdominalLegenda = dt.Rows[0]["neuro_abdominal_legenda"].ToString();
                neuro.WellsLegenda = dt.Rows[0]["neuro_wells_legenda"].ToString();
            }
            return neuro;
        }

        private String getLastId()
        {
            String lastId = "";
            sql = "SELECT MAX(neuro_id) as maior FROM neuromotor";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
                lastId = dt.Rows[0]["maior"].ToString();
            return lastId;
        }

        public bool novo(String avaId)
        {
            String lastId = "";
            bco.conecta();
            bco.beginTransaction();
            sql = "INSERT INTO neuromotor(neuro_flexao, neuro_abdominal, neuro_banco_wells) "+
                  "VALUES (null, null, null)";
            bco.executeNonQuery(sql);
            lastId = getLastId();
            sql = "UPDATE avaliacao SET neuro_id = @2 WHERE ava_id = @1";
            sql = sql.Replace("@1", avaId);
            sql = sql.Replace("@2", lastId);
            bco.executeNonQuery(sql);
            try
            {
                result = true;
                bco.commitTransaction();
            }
            catch
            {
                result = false;
                bco.rollbackTransaction();
            }
            bco.desconecta();
            return result;
        }

        public bool atualiza(Neuromotor neuro)
        {
            sql = "UPDATE neuromotor SET neuro_flexao=@1, neuro_abdominal=@2, neuro_banco_wells=@3 " +
                  ", neuro_flexao_legenda='@4', neuro_abdominal_legenda='@5', neuro_wells_legenda='@6' "+
                  "WHERE neuro_id = @A";
            sql = sql.Replace("@A", neuro.Id);
            sql = sql.Replace("@1", neuro.Flexao);
            sql = sql.Replace("@2", neuro.Abdominal);
            if (neuro.Wells == "")
                sql = sql.Replace("@3", "null");
            else
                sql = sql.Replace("@3", neuro.Wells);
            sql = sql.Replace("@4", neuro.FlexaoLegenda);
            sql = sql.Replace("@5", neuro.AbdominalLegenda);
            sql = sql.Replace("@6", neuro.WellsLegenda);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
    }
}
