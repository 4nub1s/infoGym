using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class FuncionarioBD
    {
        Banco bco;
        String sql;
        DataTable dt = null;
        public FuncionarioBD()
        {
            bco = new Banco();
        }

        public DataTable getFunc(String filtro1, String filtro2, String nome)
        {
            String ativos = " AND func_dtdem is NULL";

            if (filtro2.Equals("ambos")) //iternos e externos
            {
                sql = "SELECT * FROM funcionario WHERE func_nome ILIKE '@2%'";
                if (filtro1.Equals("ativos")) //apenas ativos
                    sql += ativos;
            }
            else //apenas internos
            {
                sql = "SELECT * FROM funcionario WHERE func_nome ILIKE '@2%' AND categoria = '@1'";
                if (filtro1.Equals("ativos")) //apenas ativos
                    sql += ativos;
                if (filtro2.Equals("internos"))
                    sql = sql.Replace("@1", "Interno");
                else
                    sql = sql.Replace("@1", "Externo");
            }
            sql = sql.Replace("@2", nome);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();

            DataTable dtAux = new DataTable(); //usada para retornar resultado trocando coluna dtdem por inativo
            dtAux.Columns.Add("func_id", typeof(int));
            dtAux.Columns.Add("func_nome", typeof(String));
            dtAux.Columns.Add("categoria", typeof(String));
            dtAux.Columns.Add("status", typeof(String));


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow linha = dtAux.NewRow();
                linha["func_id"] = dt.Rows[i]["func_id"];
                linha["func_nome"] = dt.Rows[i]["func_nome"];
                linha["categoria"] = dt.Rows[i]["categoria"];
                if (dt.Rows[i]["func_dtdem"].ToString() != "")
                    linha["status"] = "Inativo";
                else
                    linha["status"] = "Ativo";
                dtAux.Rows.Add(linha);
            }

            return dtAux;
        }

        public bool cadastrar(Funcionario func)
        {
            bool result = true;
            sql = "INSERT INTO funcionario (cid_cod, func_nome, func_rg, func_cpf, func_bairro, func_rua, func_numero, func_cep," +
                " func_fone, func_cel, func_email, func_dtnasc, categoria, func_dtadm) " +
                "VALUES(@1, '@2', '@3', '@4', '@5', '@6', '@7', '@8', '@9', '@A', " +
                "'@B', '@C', '@E', '@F')";
            sql = sql.Replace("@1", "" + func.CidCod);
            sql = sql.Replace("@2", func.Nome);
            sql = sql.Replace("@3", func.Rg);
            sql = sql.Replace("@4", func.Cpf);
            sql = sql.Replace("@5", func.Bairro);
            sql = sql.Replace("@6", func.Rua);
            sql = sql.Replace("@7", func.Numero);
            sql = sql.Replace("@8", func.Cep);
            sql = sql.Replace("@9", func.Fone);
            sql = sql.Replace("@A", func.Cel);
            sql = sql.Replace("@B", func.Email);
            sql = sql.Replace("@C", func.DtNasc);
            sql = sql.Replace("@E", "" + func.Categoria);
            sql = sql.Replace("@F", func.DtAdm);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public int getUltimoId()
        {
            sql = "SELECT MAX(func_id) as pk FROM funcionario";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return Convert.ToInt32(dt.Rows[0]["pk"]);
        }

        public Funcionario getFuncByUser(int userId)
        {
            Funcionario func = new Funcionario();
            sql = "SELECT func_id, func_nome FROM funcionario WHERE usuario_id = @1";
            sql = sql.Replace("@1", ""+userId);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                func.Id = dt.Rows[0]["func_id"].ToString();
                func.Nome = dt.Rows[0]["func_nome"].ToString();
            }
            return func;
        }

        public Funcionario getDadosFunc(String funcId)
        {
            Funcionario func = new Funcionario();
            sql = "SELECT * FROM funcionario WHERE func_id = @1";
            sql = sql.Replace("@1", funcId);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            DataRow linha = dt.Rows[0];
            func.Id = "" + linha["func_id"];
            func.Nome = "" + linha["func_nome"];
            func.Bairro = "" + linha["func_bairro"];
            func.Categoria = "" + linha["categoria"];
            func.Cel = "" + linha["func_cel"];
            func.Cep = "" + linha["func_cep"];
            func.CidCod = "" + linha["cid_cod"];
            func.Cpf = "" + linha["func_cpf"];
            func.DtAdm = "" + linha["func_dtadm"];
            func.DtDem = "" + linha["func_dtdem"];
            func.DtNasc = "" + linha["func_dtnasc"];
            func.Email = "" + linha["func_email"];
            func.Fone = "" + linha["func_fone"];
            func.Numero = "" + linha["func_numero"];
            func.Rg = "" + linha["func_rg"];
            func.Rua = "" + linha["func_rua"];
            return func;
        }

        public bool possuiUsuario(String funcId)
        {
            sql = "SELECT func_id FROM funcionario INNER JOIN usuario ON funcionario.usuario_id = usuario.usuario_id WHERE func_id = @1";
            sql = sql.Replace("@1", funcId);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public bool atualizar(Funcionario func)
        {
            bool result = true;
            String part1 = "UPDATE funcionario SET cid_cod = @1, func_nome = '@2', func_rg = '@3', func_cpf = '@4', func_bairro = '@5', func_rua = '@6', func_numero = '@7', func_cep = '@8'," +
                " func_fone = '@9', func_cel = '@A', func_email = '@B', func_dtnasc = '@C', categoria = '@D', func_dtadm = '@E'";
            String part2 = " WHERE func_id = @F";

            if (func.Usuario != "")
            {
                part1 += ", usuario_id = @G";
                part1 = part1.Replace("@G", func.Usuario);
            }
            if (func.DtDem == "")
            {
                part1 += ", func_dtdem = null";
            }
            else
            {
                part1 += ", func_dtdem = '@H'";
                part1 = part1.Replace("@H", func.DtDem);
            }

            sql = part1 + part2;
            sql = sql.Replace("@1", "" + func.CidCod);
            sql = sql.Replace("@2", func.Nome);
            sql = sql.Replace("@3", func.Rg);
            sql = sql.Replace("@4", func.Cpf);
            sql = sql.Replace("@5", func.Bairro);
            sql = sql.Replace("@6", func.Rua);
            sql = sql.Replace("@7", func.Numero);
            sql = sql.Replace("@8", func.Cep);
            sql = sql.Replace("@9", func.Fone);
            sql = sql.Replace("@A", func.Cel);
            sql = sql.Replace("@B", func.Email);
            sql = sql.Replace("@C", func.DtNasc);
            sql = sql.Replace("@D", func.Categoria);
            sql = sql.Replace("@E", func.DtAdm);
            sql = sql.Replace("@F", func.Id);

            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool excluir(Funcionario func)
        {
            bool result = true;
            sql = "DELETE FROM funcionario WHERE func_id = @1";
            sql = sql.Replace("@1", func.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
    }
}
