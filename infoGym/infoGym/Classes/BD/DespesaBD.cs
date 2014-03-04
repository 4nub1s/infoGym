using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;
using System.Drawing;

namespace infoGym.Classes.BD
{
    class DespesaBD
    {
        Banco bco;

        String sql;
        DataTable dt;
        bool result;

        public DespesaBD()
        {
            bco = new Banco();
            dt = null;
            result = false;
            sql = "";
        }

        public bool nova(Despesa desp)
        {
            String sql2 = "";
            String paramAdd = "";
            if (desp.DtPgmto != "")
            {
                sql2 = ", desp_dtpg, desp_valorpg";
                paramAdd = ", '@4', '@5'";
            }
            sql = "INSERT INTO despesa(desp_desc, desp_valor, desp_dtvenc " + sql2 + ") " +
                "VALUES ('@1', '@2', '@3'" + paramAdd + ")";
            sql = sql.Replace("@1", desp.Desc);
            sql = sql.Replace("@2", desp.Valor);
            sql = sql.Replace("@3", desp.DtVcmto);
            sql = sql.Replace("@4", desp.DtPgmto);
            sql = sql.Replace("@5", desp.ValorPg);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public DataTable consulta(String dtInicio, String dtFim, String situacao, String desc, bool ignoraPeriodo)
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("desp_id", typeof(String));
            dtResult.Columns.Add("desp_desc", typeof(String));
            dtResult.Columns.Add("desp_valor", typeof(String));
            dtResult.Columns.Add("desp_dtpg", typeof(DateTime));
            dtResult.Columns.Add("desp_dtvenc", typeof(DateTime));
            dtResult.Columns.Add("desp_valorpg", typeof(String));
            dtResult.Columns.Add("ispago", typeof(Image));

            sql = "SELECT * FROM despesa";
            if (dtInicio != "")
            {
                sql += " WHERE";
                sql += " desp_dtvenc >= '@dtInicio' AND desp_dtvenc <= '@dtFim'";
                sql = sql.Replace("@dtInicio", dtInicio);
                sql = sql.Replace("@dtFim", dtFim);
                if (situacao.Equals("Pagas"))
                    sql += " AND desp_dtpg is not null";
                if (situacao.Equals("Não pagas"))
                    sql += " AND desp_dtpg is null";
                if (situacao.Equals("Pendentes"))
                    sql += " AND desp_dtpg is null AND desp_dtvenc < '" + DateTime.Today.ToShortDateString() + "'";
            }
            else
                if (ignoraPeriodo)
                {
                    if (situacao.Equals("Pagas"))
                        sql += " WHERE desp_dtpg is not null";
                    if (situacao.Equals("Não pagas"))
                        sql += " WHERE desp_dtpg is null";
                    if (situacao.Equals("Pendentes"))
                        sql += " WHERE desp_dtpg is null AND desp_dtvenc < '" + DateTime.Today.ToShortDateString() + "'";
                }
                else //por desc
                {
                    sql += " WHERE";
                    sql += " desp_desc ILIKE '@1%'";
                    sql = sql.Replace("@1", desc);
                }
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow linha = dtResult.NewRow();
                linha["desp_id"] = dt.Rows[i]["desp_id"];
                linha["desp_desc"] = dt.Rows[i]["desp_desc"];
                linha["desp_valor"] = dt.Rows[i]["desp_valor"];
                linha["desp_dtpg"] = dt.Rows[i]["desp_dtpg"];
                linha["desp_dtvenc"] = dt.Rows[i]["desp_dtvenc"];
                linha["desp_valorpg"] = dt.Rows[i]["desp_valorpg"];
                if (linha["desp_valorpg"].ToString() == "")
                    linha["desp_valorpg"] = "0";
                dtResult.Rows.Add(linha);
            }
            return dtResult;
        }

        public DataTable getById(String id)
        {
            sql = "SELECT * FROM despesa WHERE desp_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool atualizar(Despesa desp)
        {
            sql = "UPDATE despesa SET desp_desc='@1', desp_valor='@2', desp_dtpg=@3, desp_dtvenc='@4', " +
                "desp_valorpg=@5 WHERE desp_id = @6";
            if (desp.DtPgmto == "")
            {
                sql = sql.Replace("@3", "null");
                sql = sql.Replace("@5", "null");
            }
            else
            {
                sql = sql.Replace("@3", "'"+desp.DtPgmto+"'");
                sql = sql.Replace("@5", "'"+desp.ValorPg+"'");
            }
            sql = sql.Replace("@1", desp.Desc);
            sql = sql.Replace("@2", desp.Valor);
            sql = sql.Replace("@4", desp.DtVcmto);
            sql = sql.Replace("@6", desp.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool excluir(String id)
        {
            sql = "DELETE FROM despesa WHERE desp_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getTotalPago(String dtInicio, String dtFim)
        {
            String resultS = "---";
            sql = "SELECT SUM(desp_valorpg) as valorPago FROM despesa"+
                " WHERE desp_dtvenc >= '@dtInicio' AND desp_dtvenc <= '@dtFim'";
            sql = sql.Replace("@dtInicio", dtInicio);
            sql = sql.Replace("@dtFim", dtFim);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                resultS = dt.Rows[0]["valorPago"].ToString();
            return resultS;
        }

        public String getTotalPagar(String dtInicio, String dtFim)
        {
            String resultS = "---";
            sql = "SELECT SUM(desp_valor) as valorPagar FROM despesa" +
                " WHERE desp_dtvenc >= '@dtInicio' AND desp_dtvenc <= '@dtFim' AND desp_dtpg is null";
            sql = sql.Replace("@dtInicio", dtInicio);
            sql = sql.Replace("@dtFim", dtFim);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                resultS = dt.Rows[0]["valorPagar"].ToString();
            return resultS;
        }

        public String getTotalGeral(String dtInicio, String dtFim)
        {
            String resultS = "---";
            sql = "SELECT SUM(desp_valor) as valorPagar FROM despesa" +
                " WHERE desp_dtvenc >= '@dtInicio' AND desp_dtvenc <= '@dtFim'";
            sql = sql.Replace("@dtInicio", dtInicio);
            sql = sql.Replace("@dtFim", dtFim);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                resultS = dt.Rows[0]["valorPagar"].ToString();
            return resultS;
        }

    }
}
