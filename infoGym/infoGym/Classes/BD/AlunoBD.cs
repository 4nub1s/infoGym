using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;


namespace infoGym
{
    class AlunoBD
    {
        Banco bco;
        String sql;
        DataTable dt = null;
        public AlunoBD()
        {
            bco = new Banco();
        }
       
        public DataTable getAlunos(Aluno alu, String filtro)
        {
            char sexo = ' ';
            if (filtro.Equals("todos"))
            {
                sql = "SELECT * FROM aluno WHERE alu_nome ILIKE '@1%'";
                sql = sql.Replace("@1", alu.Nome);
            }
            else
            {
                if (filtro.Equals("mulheres"))
                    sexo = 'f';
                if (filtro.Equals("homens"))
                    sexo = 'm';
                sql = "SELECT * FROM aluno WHERE alu_nome ILIKE '@1%' AND alu_sexo = '@2'";
                sql = sql.Replace("@1", alu.Nome);
                sql = sql.Replace("@2", "" + sexo);
            }
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool addTermo(Aluno alu)
        {
            bool result = false;
            sql = "UPDATE aluno SET ter_id = @1 WHERE alu_id = @2";
            sql = sql.Replace("@1", alu.TerId);
            sql = sql.Replace("@2", alu.Id+"");
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Aluno getAlunoById(int aluCod)
        {
            Aluno alu = null;
            sql = "SELECT alu_id, alu_nome, ter_id, alu_sexo, alu_dtnasc FROM aluno WHERE alu_id = @1";
            sql = sql.Replace("@1", ""+aluCod);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                alu = new Aluno();
                alu.Id = aluCod;
                alu.Nome = dt.Rows[0]["alu_nome"].ToString();
                alu.TerId = dt.Rows[0]["ter_id"].ToString();
                alu.Sexo = Convert.ToChar(dt.Rows[0]["alu_sexo"]);
                alu.DtNasc = dt.Rows[0]["alu_dtnasc"].ToString();
            }
            return alu;
        }

        public bool cadastrar(Aluno alu)
        {
            bool result = true;
            sql = "INSERT INTO aluno (cid_cod, alu_nome, alu_rg, alu_cpf, alu_bairro, alu_rua, alu_numero, alu_cep," +
                " alu_fone, alu_cel, alu_email, alu_dtnasc, alu_sexo) " +
                "VALUES(@1, '@2', '@3', '@4', '@5', '@6', '@7', '@8', '@9', '@A', " +
                "'@B', '@C', '@E')";
            sql = sql.Replace("@1", alu.Cidade);
            sql = sql.Replace("@2", alu.Nome);
            sql = sql.Replace("@3", alu.Rg);
            sql = sql.Replace("@4", alu.Cpf);
            sql = sql.Replace("@5", alu.Bairro);
            sql = sql.Replace("@6", alu.Rua);
            sql = sql.Replace("@7", alu.Numero);
            sql = sql.Replace("@8", alu.Cep);
            sql = sql.Replace("@9", alu.Fone);
            sql = sql.Replace("@A", alu.Cel);
            sql = sql.Replace("@B", alu.Email);
            sql = sql.Replace("@C", alu.DtNasc);
            sql = sql.Replace("@E", ""+alu.Sexo);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool excluir(Aluno alu)
        {
            bool result = true;
            sql = "DELETE FROM aluno WHERE alu_id = @1";
            sql = sql.Replace("@1", ""+alu.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public DataTable getAluno(Aluno alu)
        {
            sql = "SELECT * FROM aluno WHERE alu_id = @1";
            sql = sql.Replace("@1", ""+alu.Id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool atualizar(Aluno alu)
        {
            bool result = true;
            sql = "UPDATE aluno SET cid_cod = @1, alu_nome = '@2', alu_rg = '@3', alu_cpf = '@4', alu_bairro = '@5', alu_rua = '@6', alu_numero = '@7', alu_cep = '@8'," +
                " alu_fone = '@9', alu_cel = '@A', alu_email = '@B', alu_dtnasc = '@C', alu_sexo = '@E' " +
                "WHERE alu_id = @F";
            sql = sql.Replace("@1", alu.Cidade);
            sql = sql.Replace("@2", alu.Nome);
            sql = sql.Replace("@3", alu.Rg);
            sql = sql.Replace("@4", alu.Cpf);
            sql = sql.Replace("@5", alu.Bairro);
            sql = sql.Replace("@6", alu.Rua);
            sql = sql.Replace("@7", alu.Numero);
            sql = sql.Replace("@8", alu.Cep);
            sql = sql.Replace("@9", alu.Fone);
            sql = sql.Replace("@A", alu.Cel);
            sql = sql.Replace("@B", alu.Email);
            sql = sql.Replace("@C", alu.DtNasc);
            sql = sql.Replace("@E", "" + alu.Sexo);
            sql = sql.Replace("@F", "" + alu.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public int getUltimoId()
        {
            sql = "SELECT MAX(alu_id) as pk FROM aluno";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return Convert.ToInt32(dt.Rows[0]["pk"]);
        }

        public String getAlunoByTermo(String terId)
        {
            String esta = "";
            sql = "SELECT alu_nome FROM aluno WHERE ter_id = @1";
            sql = sql.Replace("@1", terId);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                esta = dt.Rows[0]["alu_nome"].ToString();
            }
            return esta;
        }
    }
}
