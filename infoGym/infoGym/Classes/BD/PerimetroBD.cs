using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class PerimetroBD
    {
        Banco bco;
        String sql;
        bool result;
        DataTable dt;

        public PerimetroBD()
        {
            bco = new Banco();
        }

        public Perimetro getById(String id)
        {
            Perimetro per = new Perimetro();
            sql = "SELECT * FROM perimetro WHERE per_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                per.Id = id;
                per.Abdome = dt.Rows[0]["abdome"].ToString();
                per.AntebracoD = dt.Rows[0]["antebraco_d"].ToString();
                per.AntebracoE = dt.Rows[0]["antebraco_e"].ToString();
                per.BracoContraD = dt.Rows[0]["braco_contra_d"].ToString();
                per.BracoContraE = dt.Rows[0]["braco_contra_e"].ToString();
                per.BracoRelaxD = dt.Rows[0]["braco_relax_d"].ToString();
                per.BracoRelaxE = dt.Rows[0]["braco_relax_e"].ToString();
                per.Cintura = dt.Rows[0]["cintura"].ToString();
                per.CoxaD = dt.Rows[0]["coxa_d"].ToString();
                per.CoxaE = dt.Rows[0]["coxa_e"].ToString();
                per.Ombro = dt.Rows[0]["ombro"].ToString();
                per.PanturrilaD = dt.Rows[0]["panturrilha_d"].ToString();
                per.PanturrilhaE = dt.Rows[0]["panturrilha_e"].ToString();
                per.Pescoco = dt.Rows[0]["pescoco"].ToString();
                per.Quadril = dt.Rows[0]["quadril"].ToString();
                per.ToraxInsp = dt.Rows[0]["torax_inspirado"].ToString();
                per.ToraxRelax = dt.Rows[0]["torax_relax"].ToString();
                per.Rcq = dt.Rows[0]["per_rcq"].ToString();
                per.RcqLegenda = dt.Rows[0]["per_rcq_legenda"].ToString();
            }
            return per;
        }

        private String getLastId()
        {
            String lastId = "";
            sql = "SELECT MAX(per_id) as maior FROM perimetro";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
                lastId = dt.Rows[0]["maior"].ToString();
            return lastId;
        }

        public bool nova(String avaId)
        {
            String lastId = "";
            bco.conecta();
            bco.beginTransaction();
            sql = "INSERT INTO perimetro( " +
                "pescoco, ombro, braco_relax_e, braco_relax_d, braco_contra_e, " +
                "braco_contra_d, antebraco_e, antebraco_d, torax_relax, torax_inspirado, " +
                "cintura, abdome, quadril, coxa_e, coxa_d, panturrilha_e, panturrilha_d, per_rcq, per_rcq_legenda) " +
                "VALUES (null, null, null, null, null, null, null, null, null, null, " +
                "null, null, null, null, null, null, null, null, '')";
            bco.executeNonQuery(sql);
            lastId = getLastId();
            sql = "UPDATE avaliacao SET per_id = @2 WHERE ava_id = @1";
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

        public bool update(Perimetro per)
        {
            sql = "UPDATE perimetro " +
                  "SET pescoco=@1, ombro=@2, braco_relax_e=@3, braco_relax_d=@4, " +
                  "braco_contra_e=@5, braco_contra_d=@6, antebraco_e=@7, antebraco_d=@8, " +
                  "torax_relax=@9, torax_inspirado=@A, cintura=@B, abdome=@C, quadril=@D, " +
                  "coxa_e=@E, coxa_d=@F, panturrilha_e=@G, panturrilha_d=@H, per_rcq = @I, per_rcq_legenda = '@J'" +
                  "WHERE per_id = @Z";
            if(per.Pescoco == "")
                sql = sql.Replace("@1", "null");
            else
                sql = sql.Replace("@1", per.Pescoco);
            if (per.Ombro == "")
                sql = sql.Replace("@2", "null");
            else
                sql = sql.Replace("@2", per.Ombro);
            if (per.BracoRelaxE == "")
                sql = sql.Replace("@3", "null");
            else
                sql = sql.Replace("@3", per.BracoRelaxE);
            if (per.BracoRelaxD == "")
                sql = sql.Replace("@4", "null");
            else
                sql = sql.Replace("@4", per.BracoRelaxD);
            if (per.BracoContraE == "")
                sql = sql.Replace("@5", "null");
            else
                sql = sql.Replace("@5", per.BracoContraE);
            if (per.BracoContraD == "")
                sql = sql.Replace("@6", "null");
            else
                sql = sql.Replace("@6", per.BracoContraD);
            if (per.AntebracoE == "")
                sql = sql.Replace("@7", "null");
            else
                sql = sql.Replace("@7", per.AntebracoE);
            if (per.AntebracoD == "")
                sql = sql.Replace("@8", "null");
            else
                sql = sql.Replace("@8", per.AntebracoD);
            if (per.ToraxRelax == "")
                sql = sql.Replace("@9", "null");
            else
                sql = sql.Replace("@9", per.ToraxRelax);
            if (per.ToraxInsp == "")
                sql = sql.Replace("@A", "null");
            else
                sql = sql.Replace("@A", per.ToraxInsp);
            if (per.Cintura == "")
                sql = sql.Replace("@B", "null");
            else
                sql = sql.Replace("@B", per.Cintura);
            if (per.Abdome == "")
                sql = sql.Replace("@C", "null");
            else
                sql = sql.Replace("@C", per.Abdome);
            if (per.Quadril == "")
                sql = sql.Replace("@D", "null");
            else
                sql = sql.Replace("@D", per.Quadril);
            if (per.CoxaE == "")
                sql = sql.Replace("@E", "null");
            else
                sql = sql.Replace("@E", per.CoxaE);
            if (per.CoxaD == "")
                sql = sql.Replace("@F", "null");
            else
                sql = sql.Replace("@F", per.CoxaD);
            if (per.PanturrilhaE == "")
                sql = sql.Replace("@G", "null");
            else
                sql = sql.Replace("@G", per.PanturrilhaE);
            if (per.PanturrilaD == "")
                sql = sql.Replace("@H", "null");
            else
                sql = sql.Replace("@H", per.PanturrilaD);
            if (per.Rcq == "")
                sql = sql.Replace("@I", "null");
            else
                sql = sql.Replace("@I", per.Rcq);
            sql = sql.Replace("@J", per.RcqLegenda);
            sql = sql.Replace("@Z", per.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

    }
}
