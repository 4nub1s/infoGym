using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.Negocio;
using System.Data;

namespace infoGym.Classes.BD
{
    class AvaliacaoBD
    {
        Banco bco;
        String sql;
        bool result;
        DataTable dt;

        public AvaliacaoBD()
        {
            bco = new Banco();
            sql = "";
            result = false;
            dt = null;
        }

        public bool novoAgendamento(Avaliacao ava)
        {
            sql = "INSERT INTO avaliacao(alu_id, func_id, ava_dtagend) "+
                "VALUES ('@1', '@2', '@3')";
            sql = sql.Replace("@1", ava.AluId);
            sql = sql.Replace("@2", ava.FuncId);
            sql = sql.Replace("@3", ava.DtAgen);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool getRestricaoHorario(String horarioPretendido)
        {
            String dataAgendamento = DateTime.Parse(horarioPretendido).Date.ToShortDateString();
            sql = "SELECT ava_id, ava_dtagend FROM avaliacao " +
                "WHERE ava_dtagend >= '@1' AND ava_dtagend < '"+DateTime.Parse(dataAgendamento).AddDays(1)+"'";
            sql = sql.Replace("@1", dataAgendamento);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            DateTime intInicial, intFinal;
            intInicial = DateTime.Parse(horarioPretendido).AddMinutes(-30);
            intFinal = DateTime.Parse(horarioPretendido).AddMinutes(30);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DateTime dtAgend = DateTime.Parse(dt.Rows[i]["ava_dtagend"].ToString());
                if (dtAgend >= intInicial && dtAgend <= intFinal)
                    return true;
            }
            return false;
        }

        public String getTotal()
        {
            String s = "---";
            sql = "SELECT COUNT(ava_id) as cont FROM avaliacao";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                s = dt.Rows[0]["cont"].ToString();
            return s;
        }

        public String getNaoRealizadas()
        {
            String s = "---";
            sql = "SELECT COUNT(ava_id) as cont FROM avaliacao WHERE ava_dtrealiz is null";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if(dt.Rows.Count > 0)
                s = dt.Rows[0]["cont"].ToString();
            return s;
        }

        public String getEmAtraso()
        {
            String s = "---";
            sql = "SELECT COUNT(ava_id) as cont FROM avaliacao WHERE ava_dtrealiz is null AND ava_dtagend < '"+DateTime.Today+"'";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                s = dt.Rows[0]["cont"].ToString();
            return s;
        }

        public DataTable getAgendaAvaliacoes(Avaliacao ava, String status, String dtIni, String dtFim, bool ligaData, bool msmDia)
        {
            String select, from;
            String where = "";
            select = "SELECT av.ava_id, av.ava_dtagend, av.ava_dtrealiz, f.func_nome, a.alu_nome";
            from = " FROM avaliacao as av INNER JOIN funcionario as f ON av.func_id = f.func_id " +
                "INNER JOIN aluno as a ON av.alu_id = a.alu_id";

            if (ava.FuncId != "")
            {
                where += " WHERE av.func_id = " + ava.FuncId;
                if (ava.AluId != "")
                {
                    where += " AND av.alu_id = " + ava.AluId;
                    if (status != "Todas")
                    {
                        if (status.Equals("Realizadas"))
                            where += " AND av.ava_dtrealiz is not null";
                        if (status.Equals("Não realizadas"))
                            where += " AND av.ava_dtrealiz is null";
                        if (status.Equals("Em atraso"))
                            where += " AND av.ava_dtrealiz is null AND av.ava_dtagend < '" + DateTime.Today + "'";
                        if (ligaData)
                            where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'"; 
                    }
                    else
                        if (ligaData)
                        {
                            if(msmDia)
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                }
                else
                {
                    if (status != "Todas")
                    {
                        if (status.Equals("Realizadas"))
                            where += " AND av.ava_dtrealiz is not null";
                        if (status.Equals("Não realizadas"))
                            where += " AND av.ava_dtrealiz is null";
                        if (status.Equals("Em atraso"))
                            where += " AND av.ava_dtrealiz is null AND av.ava_dtagend < '" + DateTime.Today + "'";
                        if (ligaData)
                        {
                            if (msmDia)
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                    }
                    else
                        if (ligaData)
                        {
                            if (msmDia)
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                }
            }
            else
            {
                if (ava.AluId != "")
                {
                    where += " WHERE av.alu_id = " + ava.AluId;
                    if (status != "Todas")
                    {
                        if (status.Equals("Realizadas"))
                            where += " AND av.ava_dtrealiz is not null";
                        if (status.Equals("Não realizadas"))
                            where += " AND av.ava_dtrealiz is null";
                        if (status.Equals("Em atraso"))
                            where += " AND av.ava_dtrealiz is null AND av.ava_dtagend < '" + DateTime.Today + "'";
                        if (ligaData)
                            where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'"; 
                    }
                    else
                        if (ligaData)
                        {
                            if (msmDia)
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                }
                else
                {
                    if (status != "Todas")
                    {
                        where += " WHERE ";
                        if (status.Equals("Realizadas"))
                            where += " av.ava_dtrealiz is not null";
                        if (status.Equals("Não realizadas"))
                            where += " av.ava_dtrealiz is null";
                        if (status.Equals("Em atraso"))
                            where += " av.ava_dtrealiz is null AND av.ava_dtagend < '" + DateTime.Today + "'";
                        if (ligaData)
                        {
                            if (msmDia)
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " AND av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                    }
                    else
                        if (ligaData)
                        {
                            where += " WHERE ";
                            if (msmDia)
                                where += " av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend < '" + DateTime.Parse(dtIni).AddDays(1) + "'";
                            else
                                where += " av.ava_dtagend >= '" + dtIni + "'" + " AND av.ava_dtagend <= '" + dtFim + "'";
                        }
                }
            }

            sql = select + from + where;
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool jaRealizada(String id)
        {
            sql = "SELECT ava_dtrealiz FROM avaliacao WHERE ava_id = "+id;
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if(dt.Rows.Count > 0)
                if (dt.Rows[0]["ava_dtrealiz"].ToString() != "")
                    return true;
            return false;
        }

        public bool excluirAgendamento(String id)
        {
            sql = "DELETE FROM avaliacao WHERE ava_id = " + id;
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool vinculaAnamnese(String anaId, String avaId)
        {
            sql = "UPDATE avaliacao SET ana_id = @1 WHERE ava_id = @2";
            sql = sql.Replace("@1", anaId);
            sql = sql.Replace("@2", avaId);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Avaliacao getById(String id)
        {
            Avaliacao ava = new Avaliacao();
            sql = "SELECT * FROM avaliacao WHERE ava_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                ava.Id = id;
                ava.AluId = dt.Rows[0]["alu_id"].ToString();
                ava.FuncId = dt.Rows[0]["func_id"].ToString();
                ava.AnaId = dt.Rows[0]["ana_id"].ToString();
                ava.DtAgen = dt.Rows[0]["ava_dtagend"].ToString();
                ava.DtRealizada = dt.Rows[0]["ava_dtrealiz"].ToString();
                ava.PerId = dt.Rows[0]["per_id"].ToString();
                ava.CompId = dt.Rows[0]["comp_id"].ToString();
                ava.NeuroId = dt.Rows[0]["neuro_id"].ToString();
            }
            return ava;
        }
    }
}
