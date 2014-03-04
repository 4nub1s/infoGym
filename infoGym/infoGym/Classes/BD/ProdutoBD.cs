using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class ProdutoBD
    {
        Banco bco;
        DataTable dt;
        String sql = "";
        bool result;
        public ProdutoBD()
        {
            bco = new Banco();
        }

        public bool novo(Produto prod)
        {
            sql = "INSERT INTO produto("+ 
            "forn_id, prod_desc, prod_valor, prod_estatual, prod_estmin)"+
            " VALUES ('@1', '@2', '@3', '@4', '@5')";
            sql = sql.Replace("@1", prod.FornId);
            sql = sql.Replace("@2", prod.Desc);
            sql = sql.Replace("@3", prod.Valor);
            sql = sql.Replace("@4", prod.EstoqueA);
            sql = sql.Replace("@5", prod.EstoqueMin);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getTotal()
        {
            String result = "";
            sql = "SELECT prod_id FROM produto";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = "" + dt.Rows.Count;
            return result;
        }

        public DataTable getProdutos(String nome)
        {
            sql = "SELECT * FROM produto WHERE prod_desc ILIKE '@1%'";
            sql = sql.Replace("@1", nome);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool excluir(Produto prod)
        {
            sql = "DELETE FROM produto WHERE prod_id = @1";
            sql = sql.Replace("@1", prod.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool atualiza(Produto prod)
        {
            sql = "UPDATE produto SET forn_id='@2', prod_desc='@3', prod_valor='@4', prod_estatual='@5', " +
            "prod_estmin='@6' WHERE prod_id = '@1'";
            sql = sql.Replace("@1", prod.Id);
            sql = sql.Replace("@2", prod.FornId);
            sql = sql.Replace("@3", prod.Desc);
            sql = sql.Replace("@4", prod.Valor);
            sql = sql.Replace("@5", prod.EstoqueA);
            sql = sql.Replace("@6", prod.EstoqueMin);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Produto getById(String id)
        {
            Produto prod = new Produto();
            sql = "SELECT * FROM produto WHERE prod_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            prod.Id = id;
            prod.Desc = dt.Rows[0]["prod_desc"].ToString();
            prod.EstoqueA = dt.Rows[0]["prod_estatual"].ToString();
            prod.EstoqueMin = dt.Rows[0]["prod_estmin"].ToString();
            prod.FornId = dt.Rows[0]["forn_id"].ToString();
            prod.Valor = dt.Rows[0]["prod_valor"].ToString();
            return prod;
        }

        public int getEstoqueAtual(String id)
        {
            int result = 0;
            sql = "SELECT prod_estatual FROM produto WHERE prod_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = Convert.ToInt32(dt.Rows[0]["prod_estatual"]);
            return result;
        }
    }
}
