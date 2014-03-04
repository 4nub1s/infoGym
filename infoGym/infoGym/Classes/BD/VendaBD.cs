using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class VendaBD
    {
        Banco bco;
        bool result;
        String sql, msg;
        DataTable dt;
        public VendaBD()
        {
            bco = new Banco();
            sql = "";
            dt = null;
            msg = "";
            result = false;
        }

        public DataTable getVendasPorAluno(String alu_id)
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("ven_cod", typeof(String));
            dtResult.Columns.Add("ven_data", typeof(DateTime));
            dtResult.Columns.Add("ven_resumo", typeof(String));
            dtResult.Columns.Add("ven_comp", typeof(String));
            dtResult.Columns.Add("ven_valor", typeof(Decimal));
            sql = "SELECT v.ven_cod, v.ven_data, p.prod_desc, a.alu_nome, v.ven_valor " +
                "FROM venda as v INNER JOIN venda_produto as vp ON v.ven_cod = vp.ven_cod " +
                "INNER JOIN produto as p ON vp.prod_id = p.prod_id " +
                "LEFT OUTER JOIN aluno as a ON v.alu_id = a.alu_id " +
                "WHERE v.alu_id = @1";
            sql = sql.Replace("@1", alu_id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                String resumo = "";
                DataRow linha = dtResult.NewRow();
                linha["ven_cod"] = dt.Rows[i]["ven_cod"];
                linha["ven_data"] = dt.Rows[i]["ven_data"];
                resumo += dt.Rows[i]["prod_desc"].ToString();
                linha["ven_comp"] = dt.Rows[i]["alu_nome"].ToString();
                linha["ven_valor"] = dt.Rows[i]["ven_valor"];
                i++;
                for (; i < dt.Rows.Count; i++)
                {
                    if (!dt.Rows[i]["ven_cod"].ToString().Equals(linha["ven_cod"].ToString()))
                    {
                        linha["ven_resumo"] = resumo;
                        resumo = "";
                        if (linha["ven_comp"].ToString().Equals(""))
                            linha["ven_comp"] = "Não cadastrado";
                        dtResult.Rows.Add(linha);
                        linha = dtResult.NewRow();
                        linha["ven_cod"] = dt.Rows[i]["ven_cod"];
                        linha["ven_data"] = dt.Rows[i]["ven_data"];
                        linha["ven_valor"] = dt.Rows[i]["ven_valor"];
                        resumo += dt.Rows[i]["prod_desc"].ToString();
                        linha["ven_comp"] = dt.Rows[i]["alu_nome"].ToString();
                    }
                    else
                        resumo += ", " + dt.Rows[i]["prod_desc"].ToString();
                }
                if (linha["ven_comp"].ToString().Equals(""))
                    linha["ven_comp"] = "Não cadastrado";
                linha["ven_resumo"] = resumo;
                dtResult.Rows.Add(linha);
            }
            return dtResult;
        }

        public List<String> getVendasComEntrada(DataTable dtVendas)
        {
            List<String> vendasComEntrada = new List<String>();
            for (int i = 0; i < dtVendas.Rows.Count; i++)
            {
                sql = "SELECT ven_cod FROM entrada WHERE ven_cod = @1";
                sql = sql.Replace("@1", dtVendas.Rows[i]["ven_cod"].ToString());
                bco.conecta();
                bco.executeQuery(sql, out dt);
                bco.desconecta();
                if (dt.Rows.Count > 0)
                    vendasComEntrada.Add(dt.Rows[0]["ven_cod"].ToString());
            }
            return vendasComEntrada;
        }

        public DataTable getVendasSemEntrada(String alu_id)
        {
            DataTable dtVendasSemEntrada = new DataTable();
            dtVendasSemEntrada.Columns.Add("ven_cod", typeof(String));
            dtVendasSemEntrada.Columns.Add("ven_data", typeof(DateTime));
            dtVendasSemEntrada.Columns.Add("ven_resumo", typeof(String));
            dtVendasSemEntrada.Columns.Add("ven_comp", typeof(String));
            dtVendasSemEntrada.Columns.Add("ven_valor", typeof(Decimal));

            DataTable dtTodasVendasDoAluno = getVendasPorAluno(alu_id);
            List<String> vendasComEntrada = getVendasComEntrada(dtTodasVendasDoAluno);

            for (int i = 0; i < dtTodasVendasDoAluno.Rows.Count; i++)
            {
                if (!vendasComEntrada.Contains(dtTodasVendasDoAluno.Rows[i]["ven_cod"].ToString()))
                {
                    DataRow linha = dtVendasSemEntrada.NewRow();
                    linha["ven_cod"] = dtTodasVendasDoAluno.Rows[i]["ven_cod"];
                    linha["ven_data"] = dtTodasVendasDoAluno.Rows[i]["ven_data"];
                    linha["ven_resumo"] = dtTodasVendasDoAluno.Rows[i]["ven_resumo"];
                    linha["ven_comp"] = dtTodasVendasDoAluno.Rows[i]["ven_comp"];
                    linha["ven_valor"] = dtTodasVendasDoAluno.Rows[i]["ven_valor"];
                    dtVendasSemEntrada.Rows.Add(linha);
                }
            }
            return dtVendasSemEntrada;
        }

        public String verificaEstoque(List<ItensVenda> itens)
        {
            Produto prod = new Produto();
            int i = 0;
            int estoqueAtual, retirada;
            estoqueAtual = retirada = 0;
            while (i < itens.Count && msg.Equals(""))
            {
                prod.Id = itens[i].ProdId;
                estoqueAtual = prod.getEstoqueAtual();
                retirada = Convert.ToInt32(itens[i].Qtde);
                if (estoqueAtual - retirada < 0)
                {
                    prod = prod.getById();
                    msg = "Produto " + prod.Desc + " não possui estoque suficiente!";
                }
                i++;
            }
            return msg;
        }

        public bool gravar(Venda ven)
        {
            bco.conecta();
            bco.beginTransaction();
            result = gravaVenda(ven);
            if (result)
                ven.Cod = getLastId();
            gravaItens(ven);
            try
            {
                bco.commitTransaction();
                result = true;
            }
            catch
            {
                bco.rollbackTransaction();
                result = false;
            }
            bco.desconecta();
            return result;
        }

        private bool gravaVenda(Venda ven)
        {
            String aluPart1, aluPart2;

            if (ven.AluId == "")
            {
                aluPart1 = ",";
                aluPart2 = ",";
            }
            else
            {
                aluPart1 = ",alu_id,";
                aluPart2 = "," + ven.AluId + ",";
            }
            sql = "INSERT INTO venda(ven_data" + aluPart1 + "ven_valor, acess_id)" +
            " VALUES ('@1' " + aluPart2 + "'@3', '@4')";
            sql = sql.Replace("@1", ven.Data);
            sql = sql.Replace("@3", ven.Valor);
            sql = sql.Replace("@4", ven.AcessId);
            result = bco.executeNonQuery(sql);
            return result;
        }

        private bool gravaItens(Venda ven)
        {
            List<ItensVenda> itens = ven.getItens();
            foreach (ItensVenda p in itens)
            {
                sql = "INSERT INTO venda_produto(ven_cod, prod_id, item_valor, item_qtde)" +
                  " VALUES ('@1', '@2', '@3', '@4')";
                sql = sql.Replace("@1", ven.Cod);
                sql = sql.Replace("@2", p.ProdId);
                sql = sql.Replace("@3", p.Valor);
                sql = sql.Replace("@4", p.Qtde);
                result = bco.executeNonQuery(sql);
                //baixa estoque
                sql = "UPDATE produto SET prod_estatual = prod_estatual - '@1' WHERE prod_id = @2";
                sql = sql.Replace("@1", p.Qtde);
                sql = sql.Replace("@2", p.ProdId);
                result = bco.executeNonQuery(sql);
            }
            return result;
        }

        private String getLastId()
        {
            String id = "";
            sql = "SELECT MAX(ven_cod) as maxcod FROM venda";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
            {
                id = dt.Rows[0]["maxcod"].ToString();
            }
            return id;
        }

        private List<ItensVenda> getItensVendaById(String ven_cod)
        {
            List<ItensVenda> listaItens = new List<ItensVenda>();
            sql = "SELECT * FROM venda_produto WHERE ven_cod = @1";
            sql = sql.Replace("@1", ven_cod);
            bco.executeQuery(sql, out dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ItensVenda item = new ItensVenda();
                item.ProdId = dt.Rows[i]["prod_id"].ToString();
                item.Qtde = dt.Rows[i]["item_qtde"].ToString();
                item.Valor = dt.Rows[i]["item_valor"].ToString();
                listaItens.Add(item);
            }
            return listaItens;
        }

        public Venda getById(String cod)
        {
            Venda ven = new Venda();
            sql = "SELECT * FROM venda WHERE ven_cod = @1";
            sql = sql.Replace("@1", cod);
            bco.conecta();
            bco.beginTransaction();
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
            {
                ven.Cod = cod;
                ven.AcessId = dt.Rows[0]["acess_id"].ToString();
                ven.AluId = dt.Rows[0]["alu_id"].ToString();
                ven.Data = dt.Rows[0]["ven_data"].ToString();
                ven.Valor = dt.Rows[0]["ven_valor"].ToString();
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

            if (ven.AluId == "")
                ven.FormaPgmto = "À vista";
            else
            {
                sql = "SELECT cai_data FROM entrada WHERE ven_cod = @1";
                sql = sql.Replace("@1", cod);
                bco.conecta();
                bco.executeQuery(sql, out dt);
                bco.desconecta();
                if (dt.Rows.Count > 0)
                {
                    if (!dt.Rows[0]["cai_data"].ToString().Equals(ven.Data))
                        ven.FormaPgmto = "Na mensalidade";
                    else
                        ven.FormaPgmto = "À vista";
                }
                else
                    ven.FormaPgmto = "Na mensalidade";
            }

            sql = "SELECT * FROM venda_produto WHERE ven_cod = @1";
            sql = sql.Replace("@1", cod);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ven.addItem(dt.Rows[i]["prod_id"].ToString(), dt.Rows[i]["item_qtde"].ToString(),
                    dt.Rows[i]["item_valor"].ToString());
            }
            return ven;
        }

        public String getQtdeVendas()
        {
            String result = "";
            sql = "SELECT COUNT(ven_cod) as cont FROM venda";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                result = dt.Rows[0]["cont"].ToString();
            return result;
        }

        public String getProdMaisVendido()
        {
            String result = "";
            sql = "SELECT COUNT(item_qtde) as cont, prod_id  FROM venda_produto GROUP BY prod_id, item_qtde ORDER BY cont DESC";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                result = dt.Rows[0]["prod_id"].ToString();
            return result;
        }

        public DataTable getVendaByDia(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("ven_cod", typeof(String));
            dtResult.Columns.Add("ven_data", typeof(DateTime));
            dtResult.Columns.Add("ven_resumo", typeof(String));
            dtResult.Columns.Add("ven_comp", typeof(String));

            sql = "SELECT v.ven_cod, v.ven_data, p.prod_desc, a.alu_nome " +
                "FROM venda as v INNER JOIN venda_produto as vp ON v.ven_cod = vp.ven_cod " +
                "INNER JOIN produto as p ON vp.prod_id = p.prod_id " +
                "LEFT OUTER JOIN aluno as a ON v.alu_id = a.alu_id " +
                "WHERE v.ven_data >= '@1' AND v.ven_data <= '@2'";

            sql = sql.Replace("@1", "" + dataInicio);
            sql = sql.Replace("@2", "" + dataFim);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                String resumo = "";
                DataRow linha = dtResult.NewRow();
                linha["ven_cod"] = dt.Rows[i]["ven_cod"];
                linha["ven_data"] = dt.Rows[i]["ven_data"];
                resumo += dt.Rows[i]["prod_desc"].ToString();
                linha["ven_comp"] = dt.Rows[i]["alu_nome"].ToString();
                i++;
                for (; i < dt.Rows.Count; i++)
                {
                    if (!dt.Rows[i]["ven_cod"].ToString().Equals(linha["ven_cod"].ToString()))
                    {
                        linha["ven_resumo"] = resumo;
                        resumo = "";
                        if (linha["ven_comp"].ToString().Equals(""))
                            linha["ven_comp"] = "Não cadastrado";
                        dtResult.Rows.Add(linha);
                        linha = dtResult.NewRow();
                        linha["ven_cod"] = dt.Rows[i]["ven_cod"];
                        linha["ven_data"] = dt.Rows[i]["ven_data"];
                        resumo += dt.Rows[i]["prod_desc"].ToString();
                        linha["ven_comp"] = dt.Rows[i]["alu_nome"].ToString();
                    }
                    else
                        resumo += ", " + dt.Rows[i]["prod_desc"].ToString();
                }
                if (linha["ven_comp"].ToString().Equals(""))
                    linha["ven_comp"] = "Não cadastrado";
                linha["ven_resumo"] = resumo;
                dtResult.Rows.Add(linha);
            }
            return dtResult;
        }

        public bool excluir(Venda ven)
        {
            bco.conecta();
            bco.beginTransaction();
            entradaExcluir(ven.Cod);
            estoqueRestaurar(ven);
            itensVendaExcluir(ven.Cod);
            vendaExcluir(ven.Cod);
            try
            {
                bco.commitTransaction();
                result = true;
            }
            catch
            {
                bco.rollbackTransaction();
                result = false;
            }
            return result;
        }

        public void entradaExcluir(String venCod)
        {
            sql = "DELETE FROM entrada WHERE ven_cod = @1";
            sql = sql.Replace("@1", venCod);
            bco.executeNonQuery(sql);
        }

        public void estoqueRestaurar(Venda ven)
        {
            ven.setItensVenda(getItensVendaById(ven.Cod));
            foreach (ItensVenda p in ven.getItens())
            {
                sql = "UPDATE produto SET prod_estatual = prod_estatual + @1 WHERE prod_id = @2";
                sql = sql.Replace("@1", p.Qtde);
                sql = sql.Replace("@2", p.ProdId);
                bco.executeNonQuery(sql);
            }
        }

        public void itensVendaExcluir(String venCod)
        {
            sql = "DELETE FROM venda_produto WHERE ven_cod = @1";
            sql = sql.Replace("@1", venCod);
            bco.executeNonQuery(sql);
        }

        public void vendaExcluir(String cod)
        {
            sql = "DELETE FROM venda WHERE ven_cod = @1";
            sql = sql.Replace("@1", cod);
            bco.executeNonQuery(sql);
        }

    }
}
