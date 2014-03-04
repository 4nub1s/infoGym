using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class ComposicaoBD
    {
        Banco bco;
        String sql;
        bool result;
        DataTable dt;
        public ComposicaoBD()
        {
            bco = new Banco();
        }


        public Composicao getById(String id)
        {
            Composicao comp = new Composicao();
            sql = "SELECT * FROM composicao WHERE comp_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                comp.Id = id;
                comp.Peso = dt.Rows[0]["comp_peso"].ToString();
                comp.Altura = dt.Rows[0]["comp_altura"].ToString();
                comp.Imc = dt.Rows[0]["comp_imc"].ToString();
                comp.Subescapular = dt.Rows[0]["comp_subescapular"].ToString();
                comp.Tricipital = dt.Rows[0]["comp_tricipital"].ToString();
                comp.Axilar = dt.Rows[0]["comp_axilar"].ToString();
                comp.Supra = dt.Rows[0]["comp_supra"].ToString();
                comp.Peitoral = dt.Rows[0]["comp_peitoral"].ToString();
                comp.Abdominal = dt.Rows[0]["comp_abdominal"].ToString();
                comp.Coxa = dt.Rows[0]["comp_coxa"].ToString();
                comp.Protocolo = dt.Rows[0]["comp_protocolo"].ToString();
                comp.GorduraI = dt.Rows[0]["comp_gordura_i"].ToString();
                comp.GorduraA = dt.Rows[0]["comp_gordura_a"].ToString();
                comp.MassaM = dt.Rows[0]["comp_massa_m"].ToString();
                comp.MassaG = dt.Rows[0]["comp_massa_g"].ToString();
                comp.ImcLegenda = dt.Rows[0]["comp_imc_legenda"].ToString();
            }
            return comp;
        }

        private String getLastId()
        {
            String lastId = "";
            sql = "SELECT MAX(comp_id) as maior FROM composicao";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
                lastId = dt.Rows[0]["maior"].ToString();
            return lastId;
        }

        public bool nova(String avaId, char sexo)
        {
            String lastId = "";
            bco.conecta();
            bco.beginTransaction();
            sql = "INSERT INTO composicao(comp_peso, comp_altura, comp_imc, comp_subescapular, "+ 
                  "comp_tricipital, comp_axilar, comp_supra, comp_peitoral, "+ 
                  "comp_abdominal, comp_coxa, comp_protocolo, "+
                  "comp_gordura_i, comp_gordura_a, comp_massa_m, comp_massa_g, comp_imc_legenda) "+
                  "VALUES (null, null, null, null, null, null, null, null, null, null, '@1', "+
                  "null, null, null, null, '')";
            if (sexo == 'm')
                sql = sql.Replace("@1", "Pollock - 3 dobras");
            else
                sql = sql.Replace("@1", "Pollock - 7 dobras");
            bco.executeNonQuery(sql);
            lastId = getLastId();
            sql = "UPDATE avaliacao SET comp_id = @2 WHERE ava_id = @1";
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

        public bool update(Composicao comp)
        {
            sql = "UPDATE composicao SET comp_peso=@1, comp_altura=@2, comp_imc=@3, comp_subescapular=@4, " +
                  "comp_tricipital=@6, comp_axilar=@7, comp_supra=@8, " +
                  "comp_peitoral=@9, comp_abdominal=@A, comp_coxa=@B, " +
                  "comp_protocolo='@D', comp_gordura_i=@E, comp_gordura_a=@F, comp_massa_m=@G, " +
                  "comp_massa_g=@H, comp_imc_legenda='@I' WHERE comp_id = @Z";
            if (comp.Peso == "")
                sql = sql.Replace("@1", "null");
            else
                sql = sql.Replace("@1", comp.Peso);
            if (comp.Altura == "")
                sql = sql.Replace("@2", "null");
            else
                sql = sql.Replace("@2", comp.Altura);
            if (comp.Imc == "")
                sql = sql.Replace("@3", "null");
            else
                sql = sql.Replace("@3", comp.Imc);
            if (comp.Subescapular == "")
                sql = sql.Replace("@4", "null");
            else
                sql = sql.Replace("@4", comp.Subescapular);
            if (comp.Tricipital == "")
                sql = sql.Replace("@6", "null");
            else
                sql = sql.Replace("@6", comp.Tricipital);
            if (comp.Axilar == "")
                sql = sql.Replace("@7", "null");
            else
                sql = sql.Replace("@7", comp.Axilar);
            if (comp.Supra == "")
                sql = sql.Replace("@8", "null");
            else
                sql = sql.Replace("@8", comp.Supra);
            if (comp.Peitoral == "")
                sql = sql.Replace("@9", "null");
            else
                sql = sql.Replace("@9", comp.Peitoral);
            if (comp.Abdominal == "")
                sql = sql.Replace("@A", "null");
            else
                sql = sql.Replace("@A", comp.Abdominal);
            if (comp.Coxa == "")
                sql = sql.Replace("@B", "null");
            else
                sql = sql.Replace("@B", comp.Coxa);
            if (comp.Protocolo == "")
                sql = sql.Replace("@D", "null");
            else
                sql = sql.Replace("@D", comp.Protocolo);
            if (comp.GorduraI == "")
                sql = sql.Replace("@E", "null");
            else
                sql = sql.Replace("@E", comp.GorduraI);
            if (comp.GorduraA == "")
                sql = sql.Replace("@F", "null");
            else
                sql = sql.Replace("@F", comp.GorduraA);
            if (comp.MassaM == "")
                sql = sql.Replace("@G", "null");
            else
                sql = sql.Replace("@G", comp.MassaM);
            if (comp.MassaG == "")
                sql = sql.Replace("@H", "null");
            else
                sql = sql.Replace("@H", comp.MassaG);
            sql = sql.Replace("@I", comp.ImcLegenda);
            sql = sql.Replace("@Z", comp.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

    }
}
