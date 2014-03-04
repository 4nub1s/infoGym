using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class MatriculaBD
    {
        Banco bco;
        String sql;
        DataTable dt;
        bool result;
        public MatriculaBD()
        {
            bco = new Banco();
            sql = "";
            dt = null;
            result = false;
        }

        public String novoDiarista(Matricula mat)
        {
            String lastId = "";
            mat.QtdeDias = "0";
            sql = "INSERT INTO matricula(mod_id, alu_id, mat_tipo, mat_qtdedias, mat_dtini, mat_obs) " +
                    "VALUES ('@1', '@2', '@3', '@4', '@5', '@7')";
            sql = sql.Replace("@1", mat.ModId);
            sql = sql.Replace("@2", mat.AluId);
            sql = sql.Replace("@3", mat.Tipo);
            sql = sql.Replace("@4", mat.QtdeDias);
            sql = sql.Replace("@5", mat.DtIni);
            sql = sql.Replace("@7", mat.Obs);
            bco.conecta();
            bco.beginTransaction();
            result = bco.executeNonQuery(sql);
            if (result)
                lastId = getLastId();
            try
            {
                bco.commitTransaction();
            }
            catch
            {
                bco.rollbackTransaction();
            }
            bco.desconecta();
            return lastId;
        }

        public String novoMensalista(Matricula mat)
        {
            String lastId = "";
            sql = "INSERT INTO matricula(mod_id, alu_id, mat_tipo, mat_dtvcmto, mat_tolerancia, mat_dtini, mat_obs) " +
                    "VALUES ('@1', '@2', '@3', '@4', '@5', '@6', '@8')";
            sql = sql.Replace("@1", mat.ModId);
            sql = sql.Replace("@2", mat.AluId);
            sql = sql.Replace("@3", mat.Tipo);
            sql = sql.Replace("@4", mat.DtVcmto);
            sql = sql.Replace("@5", mat.Tolerancia);
            sql = sql.Replace("@6", mat.DtIni);
            sql = sql.Replace("@8", mat.Obs);
            bco.conecta();
            bco.beginTransaction();
            result = bco.executeNonQuery(sql);
            if (result)
                lastId = getLastId();
            try
            {
                bco.commitTransaction();
            }
            catch
            {
                bco.rollbackTransaction();
            }
            bco.desconecta();
            return lastId;
        }

        private String getLastId()
        {
            String resultS = "";
            sql = "SELECT MAX(mat_cod) as lastId FROM matricula";
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count > 0)
                resultS = dt.Rows[0]["lastId"].ToString();
            return resultS;
        }

        public bool atualizaDiarista(Matricula mat)
        {
            sql = "UPDATE matricula SET mat_tipo = '@1', mat_qtdedias = '@2', mat_dtini = '@3', mat_obs = '@4' @5" +
                    " WHERE mat_cod = @cod";
            if (mat.DtFim != "")
                sql = sql.Replace("@5", ", mat_dtfim = '" + mat.DtFim + "'");
            else
                sql = sql.Replace("@5", "");
            sql = sql.Replace("@1", mat.Tipo);
            sql = sql.Replace("@2", mat.QtdeDias);
            sql = sql.Replace("@3", mat.DtIni);
            sql = sql.Replace("@4", mat.Obs);
            sql = sql.Replace("@cod", mat.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool atualizaMensalista(Matricula mat)
        {
            sql = "UPDATE matricula SET mat_tipo = '@1', mat_dtvcmto = '@2', mat_tolerancia = '@3', mat_dtini = '@4', mat_obs = '@5' @6" +
                     " WHERE mat_cod = @cod";
            if (mat.DtFim != "")
                sql = sql.Replace("@6", ", mat_dtfim = '" + mat.DtFim + "'");
            else
                sql = sql.Replace("@6", "");
            sql = sql.Replace("@1", mat.Tipo);
            sql = sql.Replace("@2", mat.DtVcmto);
            sql = sql.Replace("@3", mat.Tolerancia);
            sql = sql.Replace("@4", mat.DtIni);
            sql = sql.Replace("@5", mat.Obs);
            sql = sql.Replace("@6", mat.DtFim);
            sql = sql.Replace("@cod", mat.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getInfos(String infoDesejada)
        {
            String resultS = "";
            sql = "SELECT COUNT(mat_cod) as cont FROM matricula @1";
            if (infoDesejada.Equals("todas"))
                sql = sql.Replace("@1", "");
            if (infoDesejada.Equals("ativas"))
                sql = sql.Replace("@1", "WHERE mat_dtfim is null");
            if (infoDesejada.Equals("inativas"))
                sql = sql.Replace("@1", "WHERE mat_dtfim is not null");
            if (infoDesejada.Equals("diaristas"))
                sql = sql.Replace("@1", "WHERE mat_tipo = 'd'");
            if (infoDesejada.Equals("mensalistas"))
                sql = sql.Replace("@1", "WHERE mat_tipo = 'm'");
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                resultS = dt.Rows[0]["cont"].ToString();
            return resultS;
        }

        public DataTable consulta(String status, String formaPgmto, String modalidade, String aluno)
        {
            DataTable dtAzeda = new DataTable();
            dtAzeda.Columns.Add("mat_cod", typeof(String));
            dtAzeda.Columns.Add("alu_nome", typeof(String));
            dtAzeda.Columns.Add("mod_desc", typeof(String));
            dtAzeda.Columns.Add("formapgmto", typeof(String));
            dtAzeda.Columns.Add("status", typeof(String));
            String where = "";
            sql = "SELECT mat_cod, alu_nome, mod_desc, mat_tipo, mat_dtfim " +
            "FROM matricula INNER JOIN aluno ON matricula.alu_id = aluno.alu_id " +
            "INNER JOIN modalidade ON matricula.mod_id = modalidade.mod_id";
            if (status.Equals("Ambas") && formaPgmto.Equals("Ambas")
                && modalidade.Equals("") && aluno.Equals("0"))
                where = "";
            else
            {
                where = " WHERE ";
                if (status.Equals("Ativas"))
                {
                    where += "mat_dtfim is null ";
                    if (formaPgmto.Equals("Ambas"))
                    {
                        if (modalidade.Equals(""))
                        {
                            if (!aluno.Equals("0"))
                                where += "AND aluno.alu_id = @aluCod";
                        }
                        else
                            where += "AND modalidade.mod_id = @modId";
                    }
                    else
                    {
                        where += "AND mat_tipo = '@matTipo'";
                        if (modalidade.Equals(""))
                        {
                            if (!aluno.Equals("0"))
                                where += "AND aluno.alu_id = @aluCod";
                        }
                        else
                            where += "AND modalidade.mod_id = @modId";
                    }
                }
                else
                    if (status.Equals("Inativas"))
                    {
                        where += "mat_dtfim is not null ";
                        if (formaPgmto.Equals("Ambas"))
                        {
                            if (modalidade.Equals(""))
                            {
                                if (!aluno.Equals("0"))
                                    where += "AND aluno.alu_id = @aluCod";
                            }
                            else
                                where += "AND modalidade.mod_id = @modId";
                        }
                        else
                        {
                            where += "AND mat_tipo = '@matTipo'";
                            if (modalidade.Equals(""))
                            {
                                if (!aluno.Equals("0"))
                                    where += "AND aluno.alu_id = @aluCod";
                            }
                            else
                                where += "AND modalidade.mod_id = @modId";
                        }
                    }
                    else //Ativas/ Inativas
                    {
                        if (formaPgmto.Equals("Ambas"))
                        {
                            if (modalidade.Equals(""))
                            {
                                if (!aluno.Equals("0"))
                                    where += "aluno.alu_id = @aluCod";
                            }
                            else
                                where += "modalidade.mod_id = @modId";
                        }
                        else
                        {
                            where += "mat_tipo = '@matTipo'";
                            if (modalidade.Equals(""))
                            {
                                if (!aluno.Equals("0"))
                                    where += "AND aluno.alu_id = @aluCod";
                            }
                            else
                                where += "AND modalidade.mod_id = @modId";
                        }
                    }

            }
            sql += where;
            sql = sql.Replace("@aluCod", aluno);
            sql = sql.Replace("@modId", modalidade);
            sql = sql.Replace("@matTipo", ""+Char.ToLower(formaPgmto[0]));
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow linha = dtAzeda.NewRow();
                linha["mat_cod"] = dt.Rows[i]["mat_cod"];
                linha["alu_nome"] = dt.Rows[i]["alu_nome"];
                linha["mod_desc"] = dt.Rows[i]["mod_desc"];
                if (dt.Rows[i]["mat_tipo"].Equals("d"))
                    linha["formapgmto"] = "Diarista";
                else
                    linha["formapgmto"] = "Mensalista";
                if (!dt.Rows[i]["mat_dtfim"].ToString().Equals(""))
                    linha["status"] = "Inativa";
                else
                    linha["status"] = "Ativa";
                dtAzeda.Rows.Add(linha);
            }

            return dtAzeda;
        }

        public Matricula getById(String id)
        {
            Matricula mat = new Matricula();
            sql = "SELECT * FROM matricula WHERE mat_cod = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                mat.Id = id;
                mat.AluId = dt.Rows[0]["alu_id"].ToString();
                mat.DtFim = dt.Rows[0]["mat_dtfim"].ToString();
                mat.DtIni = dt.Rows[0]["mat_dtini"].ToString();
                mat.DtVcmto = dt.Rows[0]["mat_dtvcmto"].ToString();
                mat.ModId = dt.Rows[0]["mod_id"].ToString();
                mat.Obs = dt.Rows[0]["mat_obs"].ToString();
                mat.QtdeDias = dt.Rows[0]["mat_qtdedias"].ToString();
                mat.Tipo = dt.Rows[0]["mat_tipo"].ToString();
                mat.Tolerancia = dt.Rows[0]["mat_tolerancia"].ToString();
            }
            return mat;
        }

        public bool excluir(String id)
        {
            sql = "DELETE FROM matricula WHERE mat_cod = @1";
            sql = sql.Replace("@1", id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool adicionarCreditos(Matricula mat, Movimentacao mov)
        {
            bco.conecta();
            bco.beginTransaction();
            mov.novaEntrada();
            String sql = "UPDATE matricula SET mat_qtdedias = mat_qtdedias + @1 WHERE mat_cod = @2";
            sql = sql.Replace("@1", mat.QtdeDias);
            sql = sql.Replace("@2", mat.Id);
            bco.executeNonQuery(sql);
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

        public DataTable getMensalidades(String matCod)
        {
            DataTable result = new DataTable();
            result.Columns.Add("vcmto", typeof(String));
            result.Columns.Add("valor", typeof(String));
            result.Columns.Add("dtpgmto", typeof(String));
            result.Columns.Add("user", typeof(String));
            result.Columns.Add("dias", typeof(String));

            sql = "SELECT * FROM entrada WHERE mat_cod = @1";
            sql = sql.Replace("@1", matCod);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();

            Matricula mat = new Matricula();
            mat.Id = matCod;
            mat = mat.getById();
            String[] diaInicio = mat.DtIni.Split('/');
            Modalidade mod = new Modalidade();
            mod.Id = mat.ModId;
            mod = mod.getById();
            int fator = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow linha = result.NewRow();
                if (i == 0 && mat.DtVcmto != diaInicio[0])
                    fator = 1;
                if (mat.Tipo == "m")
                {
                    DateTime mensAtual = DateTime.Parse(mat.DtIni).AddMonths(i + fator);
                    DateTime mensAtual2 = new DateTime(mensAtual.Year, mensAtual.Month, Convert.ToInt32(mat.DtVcmto));
                    linha["vcmto"] = mensAtual2.ToShortDateString();
                }
                linha["valor"] = dt.Rows[i]["ent_valor"];
                linha["dtpgmto"] = DateTime.Parse(dt.Rows[i]["cai_data"].ToString()).ToShortDateString();
                Usuario user = new Usuario();
                user.Id = Convert.ToInt32(dt.Rows[i]["acess_id"]);
                user = user.getUserById();
                linha["user"] = user.Login;
                if (mat.Tipo == "d")
                {
                    linha["dias"] = Convert.ToDecimal(dt.Rows[i]["ent_valor"]) / Convert.ToDecimal(mod.ValorD);
                }

                if(mat.Tipo == "d" && dt.Rows[i]["ent_desc"].ToString().Contains("Pagamento de")
                    || mat.Tipo == "m" && dt.Rows[i]["ent_desc"].ToString().Contains("Pagamento mensalidade"))
                    result.Rows.Add(linha);
            }

            return result;
        }
    }
}
