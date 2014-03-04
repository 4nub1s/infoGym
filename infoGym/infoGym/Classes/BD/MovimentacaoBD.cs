using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;
using System.Drawing;

namespace infoGym.Classes.BD
{
    class MovimentacaoBD
    {
        DataTable dt;
        String sql;
        Banco bco;
        bool result;

        public MovimentacaoBD()
        {
            bco = new Banco();
            dt = null;
            sql = "";
            result = false;
        }

        public bool novaEntrada(Movimentacao mov)
        {
            sql = "INSERT INTO entrada(mat_cod, ven_cod, cai_data, acess_id, ent_valor, ent_desc) "+
                "VALUES (@1, @2, '@3', '@4', '@5', '@6')";
            if (mov.MatCod == "")
                sql = sql.Replace("@1", "NULL");
            else
                sql = sql.Replace("@1", mov.MatCod);
            if (mov.VenCod == "")
                sql = sql.Replace("@2", "NULL");
            else
                sql = sql.Replace("@2", mov.VenCod);

            sql = sql.Replace("@3", mov.CaiData);
            sql = sql.Replace("@4", mov.AcessId);
            sql = sql.Replace("@5", mov.Valor);
            sql = sql.Replace("@6", mov.Desc);

            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool novaSaida(Movimentacao mov)
        {
            sql = "INSERT INTO saida(acess_id, cai_data, sai_valor, sai_desc) "+
                "VALUES ('@1', '@2', '@3', '@4')";
            sql = sql.Replace("@1", mov.AcessId);
            sql = sql.Replace("@2", mov.CaiData);
            sql = sql.Replace("@3", mov.Valor);
            sql = sql.Replace("@4", mov.Desc);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Movimentacao getEntradaById(String id)
        {
            Movimentacao mov = new Movimentacao();
            sql = "SELECT * FROM entrada WHERE ent_id = '@1'";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                mov.AcessId = dt.Rows[0]["acess_id"].ToString();
                mov.CaiData = dt.Rows[0]["cai_data"].ToString();
                mov.Desc = dt.Rows[0]["ent_desc"].ToString();
                mov.EntradaId = id;
                mov.MatCod = dt.Rows[0]["mat_cod"].ToString();
                mov.VenCod = dt.Rows[0]["ven_cod"].ToString();
                mov.Valor = dt.Rows[0]["ent_valor"].ToString();
            }
            return mov;
        }

        public Movimentacao getSaidaById(String id)
        {
            Movimentacao mov = new Movimentacao();
            sql = "SELECT * FROM saida WHERE sai_id = '@1'";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                mov.AcessId = dt.Rows[0]["acess_id"].ToString();
                mov.CaiData = dt.Rows[0]["cai_data"].ToString();
                mov.Valor = dt.Rows[0]["sai_valor"].ToString();
                mov.Desc = dt.Rows[0]["sai_desc"].ToString();
            }
            return mov;
        }

        public DataTable getSaidasByDia(String caiData)
        {
            sql = "SELECT * FROM saida WHERE cai_data = '@1'";
            sql = sql.Replace("@1", caiData);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public DataTable getEntradasByDia(String caiData)
        {
            sql = "SELECT * FROM entrada WHERE cai_data = '@1'";
            sql = sql.Replace("@1", caiData);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public DataTable getMovByDia(String caiData, String filtro)
        {
            DataTable entradas, saidas;
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("desc", typeof(String));
            dtResult.Columns.Add("valor", typeof(String));
            dtResult.Columns.Add("isEntrada", typeof(bool));
            dtResult.Columns.Add("id", typeof(String));
            dtResult.Columns.Add("movTipo", typeof(String));
            dtResult.Columns.Add("img", typeof(Image));
           
            if(filtro.Equals("entrada"))
            {
                entradas = getEntradasByDia(caiData);
                preencheDtt(entradas, true, ref dtResult);
            }
            if (filtro.Equals("saida"))
            {
                saidas = getSaidasByDia(caiData);
                preencheDtt(saidas, false, ref dtResult);
            }
            if (filtro.Equals("ambas"))
            {
                entradas = getEntradasByDia(caiData);
                preencheDtt(entradas, true, ref dtResult);
                saidas = getSaidasByDia(caiData);
                preencheDtt(saidas, false, ref dtResult);
            }
            return dtResult;
        }

        private void preencheDtt(DataTable dtEntrada, bool isEntrada, ref DataTable dtSaida)
        {
            String aux = "";
            if (isEntrada)
                aux = "ent";
            else
                aux = "sai";
            for (int i = 0; i < dtEntrada.Rows.Count; i++)
            {
                DataRow linha = dtSaida.NewRow();
                linha["desc"] = dtEntrada.Rows[i][aux+"_desc"];
                linha["valor"] = dtEntrada.Rows[i][aux+"_valor"];
                if (isEntrada)
                {
                    linha["isEntrada"] = true;
                    linha["movTipo"] = "Entrada";
                }
                else
                {
                    linha["isEntrada"] = false;
                    linha["movTipo"] = "Saída";
                }
                linha["id"] = dtEntrada.Rows[i][aux+"_id"];
                dtSaida.Rows.Add(linha);
            }
        }

        public String getTotalEntradas(String caiData)
        {
            Decimal totEnt = 0;
            sql = "SELECT ent_valor FROM entrada WHERE cai_data = '@1'";
            sql = sql.Replace("@1", caiData);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totEnt += Convert.ToDecimal(dt.Rows[i]["ent_valor"]);
            }
            return totEnt.ToString();
        }

        public String getTotalSaidas(String caiData)
        {
            Decimal totSai = 0;
            sql = "SELECT sai_valor FROM saida WHERE cai_data = '@1'";
            sql = sql.Replace("@1", caiData);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                totSai += Convert.ToDecimal(dt.Rows[i]["sai_valor"]);
            }
            return totSai.ToString();
        }

        public bool excluir(Movimentacao mov)
        {
            if (mov.EntradaId != "")
            {
                sql = "DELETE FROM entrada WHERE ent_id = '@1'";
                sql = sql.Replace("@1", mov.EntradaId);
            }
            else
            {
                sql = "DELETE FROM saida WHERE sai_id = '@1'";
                sql = sql.Replace("@1", mov.SaidaId);
            }
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public int getQtdeMensalidades(String matCod)
        {
            int retorno = 0;
            sql = "SELECT COUNT(ent_id) as cont FROM entrada WHERE mat_cod = @1";
            sql = sql.Replace("@1", matCod);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                retorno = Convert.ToInt32(dt.Rows[0]["cont"]);
            return retorno;
        }
    }
}
