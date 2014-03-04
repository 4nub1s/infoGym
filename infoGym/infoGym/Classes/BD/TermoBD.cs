using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class TermoBD
    {
        String sql;
        Banco bco;
        DataTable dt;
        bool result;
        public TermoBD()
        {
            bco = new Banco();
            sql = "";
            dt = null;
            result = false;
        }

        public bool novo(Termo ter)
        {
            sql = "INSERT INTO termo(ter_quemcadastrou) "
            +"VALUES (@1)";
            sql = sql.Replace("@1", ter.TerQuemCadastrou);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            if (result)
            {
                Aluno alu = new Aluno();
                alu.Id = Convert.ToInt32(ter.AluId);
                alu.TerId = ter.getUltimoId();
                result = alu.addTermo();
            }
            return result;
        }

        public bool atualiza(Termo ter)
        {
            sql = "UPDATE termo SET ter_quemcadastrou='@1' "+
                "WHERE ter_id = @2";
            sql = sql.Replace("@1", ter.TerQuemCadastrou);
            sql = sql.Replace("@2", ter.TerId);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool excluir(Termo ter)
        {
            sql = "UPDATE aluno SET ter_id = null WHERE ter_id = @1";
            sql = sql.Replace("@1", ter.TerId);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            if (result)
            {
                sql = "DELETE FROM termo WHERE ter_id = @1";
                sql = sql.Replace("@1", ter.TerId);
                bco.conecta();
                result = bco.executeNonQuery(sql);
                bco.desconecta();
            }
            return result;
        }

        public Termo getTermoById(String id)
        {
            Termo ter = null;
            sql = "SELECT * FROM termo WHERE ter_id = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                ter = new Termo();
                ter.TerId = id;
                ter.TerQuemCadastrou = dt.Rows[0]["ter_quemcadastrou"].ToString();
            }
            return ter;
        }

        public String getUltimoId()
        {
            String id = "";
            sql = "SELECT MAX(ter_id) as maxTer FROM termo";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                id = dt.Rows[0]["maxTer"].ToString();
            }
            return id;
        }

        public DataTable getTermos(String aluNome)
        {
            sql = "SELECT alu_nome, ter_id FROM aluno WHERE alu_nome ILIKE '@1%' AND ter_id notnull";
            sql = sql.Replace("@1", aluNome);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }
    }
}
