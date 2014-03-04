using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class FornecedorBD
    {
        Banco bco;
        DataTable dt;
        String sql = "";
        bool result;
        public FornecedorBD()
        {
            bco = new Banco();
        }
       
        public bool novo(Fornecedor forn)
        {
            sql = "INSERT INTO fornecedor(forn_cnpj, forn_razaosocial, forn_inscestadual, forn_bairro, " +
            "forn_rua, forn_num, forn_cep, forn_email, forn_site, forn_fone, " +
            "forn_cel, forn_representante, cid_cod) " +
            "VALUES ('@1', '@2', '@3', '@4', '@5', " +
            "'@6', '@7', '@8', '@9', '@A', '@B', '@C', '@D')";
            sql = sql.Replace("@1", forn.Cnpj);
            sql = sql.Replace("@2", forn.RazaoS);
            sql = sql.Replace("@3", forn.InscEst);
            sql = sql.Replace("@4", forn.Bairro);
            sql = sql.Replace("@5", forn.Rua);
            sql = sql.Replace("@6", forn.Num);
            sql = sql.Replace("@7", forn.Cep);
            sql = sql.Replace("@8", forn.Email);
            sql = sql.Replace("@9", forn.Site);
            sql = sql.Replace("@A", forn.Fone);
            sql = sql.Replace("@B", forn.Cel);
            sql = sql.Replace("@C", forn.Representante);
            sql = sql.Replace("@D", forn.CidCod);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getTotal()
        {
            String result = "";
            sql = "SELECT forn_cnpj FROM fornecedor";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = ""+dt.Rows.Count;
            return result;
        }

        public DataTable getFornecedores(String razaoS)
        {
            sql = "SELECT forn_cnpj, forn_razaosocial, forn_id FROM fornecedor WHERE forn_razaosocial ILIKE '@1%'";
            sql = sql.Replace("@1", razaoS);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool excluir(Fornecedor forn)
        {
            sql = "DELETE FROM fornecedor WHERE forn_id = @1";
            sql = sql.Replace("@1", forn.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Fornecedor getById(String id)
        {
            Fornecedor forn = new Fornecedor();
            sql = "SELECT * FROM fornecedor WHERE forn_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            forn.Id = id;
            forn.InscEst = dt.Rows[0]["forn_inscestadual"].ToString();
            forn.Num = dt.Rows[0]["forn_num"].ToString();
            forn.RazaoS = dt.Rows[0]["forn_razaosocial"].ToString();
            forn.Representante = dt.Rows[0]["forn_representante"].ToString();
            forn.Rua = dt.Rows[0]["forn_rua"].ToString();
            forn.Site = dt.Rows[0]["forn_site"].ToString();
            forn.Bairro = dt.Rows[0]["forn_bairro"].ToString();
            forn.Cel = dt.Rows[0]["forn_cel"].ToString();
            forn.Cep = dt.Rows[0]["forn_cep"].ToString();
            forn.CidCod = dt.Rows[0]["cid_cod"].ToString();
            forn.Cnpj = dt.Rows[0]["forn_cnpj"].ToString();
            forn.Email = dt.Rows[0]["forn_email"].ToString();
            forn.Fone = dt.Rows[0]["forn_fone"].ToString();
            return forn;
        }

        public bool altera(Fornecedor forn)
        {
            sql = "UPDATE fornecedor SET forn_cnpj='@2', forn_razaosocial='@3'," +
                " forn_inscestadual='@4', forn_bairro='@5', forn_rua='@6', forn_num='@7',  "+
                "forn_cep='@8', forn_email='@9', forn_site='@A', forn_fone='@B', forn_cel='@C', forn_representante='@D', cid_cod='@E' "+
                "WHERE forn_id = @1";
            sql = sql.Replace("@2", forn.Cnpj);
            sql = sql.Replace("@3", forn.RazaoS);
            sql = sql.Replace("@4", forn.InscEst);
            sql = sql.Replace("@5", forn.Bairro);
            sql = sql.Replace("@6", forn.Rua);
            sql = sql.Replace("@7", forn.Num);
            sql = sql.Replace("@8", forn.Cep);
            sql = sql.Replace("@9", forn.Email);
            sql = sql.Replace("@A", forn.Site);
            sql = sql.Replace("@B", forn.Fone);
            sql = sql.Replace("@C", forn.Cel);
            sql = sql.Replace("@D", forn.Representante);
            sql = sql.Replace("@E", forn.CidCod);
            sql = sql.Replace("@1", forn.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
    }
}
