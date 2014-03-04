using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes
{
    class AnamneseBD
    {
        Banco bco;
        String sql;
        bool result;
        DataTable dt;
        public AnamneseBD()
        {
            bco = new Banco();
        }

        public Anamnese getById(String id)
        {
            Anamnese ana = new Anamnese();
            sql = "SELECT * FROM anamnese WHERE ana_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                ana.AnaId = id;
                ana.Alergia = dt.Rows[0]["alergia"].ToString();
                ana.AtividadeFisica = dt.Rows[0]["atividade_fisica"].ToString();
                ana.Bebida = dt.Rows[0]["bebida"].ToString();
                ana.Cirurgia = dt.Rows[0]["cirurgia"].ToString();
                ana.Diabete_familia = dt.Rows[0]["diabete_familia"].ToString();
                ana.Diabetico = dt.Rows[0]["diabetico"].ToString();
                ana.Dores = dt.Rows[0]["dores"].ToString();
                ana.Estado_geral = dt.Rows[0]["estado_geral"].ToString();
                ana.Fumante = dt.Rows[0]["fumante"].ToString();
                ana.FumanteEx = dt.Rows[0]["fumante_ex"].ToString();
                ana.Gestante = dt.Rows[0]["gestante"].ToString();
                ana.Hipertenso = dt.Rows[0]["hipertenso"].ToString();
                ana.InfartoFamilia = dt.Rows[0]["infarto_familia"].ToString();
                ana.Medicamento = dt.Rows[0]["medicamento"].ToString();
                ana.Objetivo = dt.Rows[0]["objetivo"].ToString();
                ana.Osteoporose = dt.Rows[0]["osteoporose"].ToString();
                ana.PartesCorpo = dt.Rows[0]["partes_corpo"].ToString();
                ana.ProbCard = dt.Rows[0]["prob_card"].ToString();
                ana.ProbDesc = dt.Rows[0]["prob_desc"].ToString();
                ana.ProbGastro = dt.Rows[0]["prob_gastro"].ToString();
                ana.ProbNeuro = dt.Rows[0]["prob_neuro"].ToString();
                ana.ProbOrto = dt.Rows[0]["prob_orto"].ToString();
                ana.ProbResp = dt.Rows[0]["prob_resp"].ToString();
                ana.Refeicoes = dt.Rows[0]["refeicoes"].ToString();
                ana.Tontura = dt.Rows[0]["tontura"].ToString();
                ana.Vertigem = dt.Rows[0]["vertigem"].ToString();
            }
            return ana;
        }

        private String getLastId()
        {
            String lastId = "";
            sql = "SELECT MAX(ana_id) as maior FROM anamnese";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
                lastId = dt.Rows[0]["maior"].ToString();
            return lastId;
        }

        public bool nova(String avaId)
        {
            Avaliacao ava;

            String lastId = "";
            bco.conecta();
            bco.beginTransaction();
            ava = new Avaliacao();
            sql = "UPDATE avaliacao SET ava_dtrealiz = '@1' WHERE ava_id = @2";
            sql = sql.Replace("@1", DateTime.Now.ToString());
            sql = sql.Replace("@2", avaId);
            result = bco.executeNonQuery(sql);
            if (result)
            {
                sql = "INSERT INTO anamnese (prob_card, prob_orto, prob_neuro, prob_gastro, prob_resp, " +
                "prob_desc, fumante, fumante_ex, diabetico, diabete_familia, gestante, " +
                "alergia, tontura, vertigem, osteoporose, hipertenso, bebida, " +
                "infarto_familia, medicamento, cirurgia, dores, estado_geral, " +
                "refeicoes, atividade_fisica, partes_corpo, objetivo) " +
                "VALUES ('', '', '', '', '', " +
                "'', '', '', '', '', '', " +
                "'', '', '', '', '', '', " +
                "'', '', '', '', '', " +
                "'', '', '', '')";
                result = bco.executeNonQuery(sql);
            }
            if (result)
            {
                lastId = getLastId();
                sql = "UPDATE avaliacao SET ana_id = @1 WHERE ava_id = @2";
                sql = sql.Replace("@1", lastId);
                sql = sql.Replace("@2", avaId);
                result = bco.executeNonQuery(sql);
            }
            try
            {
                bco.commitTransaction();
            }
            catch
            {
                bco.rollbackTransaction();
            }
            bco.desconecta();

            return result;
        }

        public bool update(Anamnese ana)
        {
            sql = "UPDATE anamnese SET prob_card='@2', prob_orto='@3', prob_neuro='@4', prob_gastro='@5', " +
                "prob_resp='@6', prob_desc='@7', fumante='@8', fumante_ex='@9', diabetico='@A', " +
                "diabete_familia='@B', gestante='@C', alergia='@D', tontura='@E', vertigem='@F', " +
                "osteoporose='@G', hipertenso='@H', bebida='@I', infarto_familia='@J', medicamento='@K', " +
                "cirurgia='@O', dores='@P', estado_geral='@Q', refeicoes='@R', atividade_fisica='@S', " +
                "partes_corpo='@T', objetivo='@U' " +
                "WHERE ana_id = @1";
            sql = sql.Replace("@1", ana.AnaId);
            sql = sql.Replace("@2", ana.ProbCard);
            sql = sql.Replace("@3", ana.ProbOrto);
            sql = sql.Replace("@4", ana.ProbNeuro);
            sql = sql.Replace("@5", ana.ProbGastro);
            sql = sql.Replace("@6", ana.ProbResp);
            sql = sql.Replace("@7", ana.ProbDesc);
            sql = sql.Replace("@8", ana.Fumante);
            sql = sql.Replace("@9", ana.FumanteEx);
            sql = sql.Replace("@A", ana.Diabetico);
            sql = sql.Replace("@B", ana.Diabete_familia);
            sql = sql.Replace("@C", ana.Gestante);
            sql = sql.Replace("@D", ana.Alergia);
            sql = sql.Replace("@E", ana.Tontura);
            sql = sql.Replace("@F", ana.Vertigem);
            sql = sql.Replace("@G", ana.Osteoporose);
            sql = sql.Replace("@H", ana.Hipertenso);
            sql = sql.Replace("@I", ana.Bebida);
            sql = sql.Replace("@J", ana.InfartoFamilia);
            sql = sql.Replace("@K", ana.Medicamento);
            sql = sql.Replace("@O", ana.Cirurgia);
            sql = sql.Replace("@P", ana.Dores);
            sql = sql.Replace("@Q", ana.Estado_geral);
            sql = sql.Replace("@R", ana.Refeicoes);
            sql = sql.Replace("@S", ana.AtividadeFisica);
            sql = sql.Replace("@T", ana.PartesCorpo);
            sql = sql.Replace("@U", ana.Objetivo);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
    }
}
