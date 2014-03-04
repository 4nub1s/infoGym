using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace infoGym
{
    class UsuarioBD
    {
        Banco bco;

        public UsuarioBD()
        {
            bco = new Banco();
        }

        public bool logar(Usuario user)
        {
            bool result;
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM usuario WHERE usuario_login = '@1' AND usuario_pass = '@2' AND usuario_status = true";
            sql = sql.Replace("@1", user.Login);
            sql = sql.Replace("@2", user.Senha);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            if (dt.Rows.Count == 0)
            {
                result = false;
            }
            else
            {
                int user_id = Convert.ToInt32(dt.Rows[0]["usuario_id"]);
                user.Id = user_id;
                DateTime entrada = new DateTime();
                entrada = DateTime.Now;
                sql = "INSERT INTO acesso(usuario_id, acess_ent) VALUES (@1, '@2')";
                sql = sql.Replace("@1", "" + user_id);
                sql = sql.Replace("@2", "" + entrada);
                bco.executeNonQuery(sql);
                result = true;
            }
            bco.desconecta();
            return result;
        }

        public int getIdTela(String nomeTela)
        {
            int id = 0;
            DataTable dt;
            String sql = "SELECT tela_id FROM tela WHERE tela_nome = '@1'";
            sql = sql.Replace("@1", nomeTela);
            bco.conecta();
            bool result = bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (result)
                id = Convert.ToInt32(dt.Rows[0]["tela_id"]);
            return id;
        }

        public bool isBloq(Usuario user)
        {
            bool result;
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM usuario WHERE usuario_login = '@1'";
            sql = sql.Replace("@1", user.Login);
            if (bco.conecta())
            {
                bco.executeQuery(sql, out dt);
                if (dt.Rows.Count == 0)
                    result = false;
                else
                {
                    if (!Convert.ToBoolean(dt.Rows[0]["usuario_status"]))
                    {
                        result = true;
                    }
                    else
                        result = false;
                }
                bco.desconecta();
            }
            else
                result = false;
            return result;
        }

        public bool isLogado(Usuario user)
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM acesso INNER JOIN usuario ON acesso.usuario_id = usuario.usuario_id WHERE usuario_login = '@login'";
            sql = sql.Replace("@login", user.Login);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["acess_sai"].ToString() == "")
                {
                    user.UltimoAcesso = Convert.ToInt32(dt.Rows[i]["acess_id"]);
                    return true;
                }
            }
            return false;
        }

        public bool deslogar(Usuario user)
        {
            bool result;
            isLogado(user);
            String sql = "UPDATE acesso SET acess_sai = '@data' WHERE acess_id = @ultimaCon";
            sql = sql.Replace("@ultimaCon", ""+user.UltimoAcesso);
            sql = sql.Replace("@data", ""+DateTime.Now);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public String getUltimaCon(Usuario user)
        {
            DataTable dt = new DataTable();
            String sql = "SELECT acess_ent FROM acesso INNER JOIN usuario ON acesso.usuario_id = usuario.usuario_id WHERE usuario_login = '@login'";
            sql = sql.Replace("@login", user.Login);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if(dt.Rows.Count != 0)
                return dt.Rows[dt.Rows.Count-1]["acess_ent"].ToString();
            return "";
        }

        public DataTable gettela()
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM tela";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public DataTable getCampos(int tela)
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM campo INNER JOIN tela ON campo.tela_id = tela.tela_id WHERE tela.tela_id = @id";
            sql = sql.Replace("@id", "" + tela);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool criarNovo(Usuario user)
        {
            bool result = true;
            String sql = "INSERT INTO usuario (usuario_login, usuario_pass, usuario_status) VALUES ('@1', '@2', @3)";
            sql = sql.Replace("@1", user.Login);
            sql = sql.Replace("@2", user.Senha);
            sql = sql.Replace("@3", "" + user.Status);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            if (result)
            {
                DataTable dt;
                sql = "SELECT MAX(usuario_id) FROM usuario";
                bco.conecta();
                result = bco.executeQuery(sql, out dt);
                bco.desconecta();
                if (result)
                {
                    user.Id = Convert.ToInt32(dt.Rows[0][0]);
                    sql = "SELECT camp_id, tela_id FROM campo";
                    bco.conecta();
                    result = bco.executeQuery(sql, out dt);
                    bco.desconecta();                 
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sql = "INSERT INTO usuario_campo (usuario_id, camp_id, tela_id, usuariocamp_acesso) VALUES (@1, @2, @3, @4)";
                        sql = sql.Replace("@1", "" + user.Id);
                        sql = sql.Replace("@4", "" + false);
                        sql = sql.Replace("@2", "" + dt.Rows[i]["camp_id"]);
                        sql = sql.Replace("@3", "" + dt.Rows[i]["tela_id"]);
                        bco.conecta();
                        result = bco.executeNonQuery(sql);
                        bco.desconecta();
                    }
                }
            }
            return result;
        }

        public DataTable getCamposUsuario(int userId)
        {
            DataTable dt = null;
            String sql  = "SELECT uc.camp_id, uc.tela_id, uc.usuariocamp_acesso, c.camp_nome FROM usuario_campo as uc "+
                "INNER JOIN usuario as u ON uc.usuario_id = u.usuario_id INNER JOIN campo as c ON uc.camp_id = c.camp_id WHERE u.usuario_id = @1";
            sql = sql.Replace("@1", ""+userId);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool hasPermissionField(int userId, String campoNome)
        {
            DataTable dt = getCamposUsuario(userId);
            if (dt.Rows.Count > 0)
            {
                int i = 0;
                while (i < dt.Rows.Count && !dt.Rows[i]["camp_nome"].ToString().Equals(campoNome))
                    i++;
                if (i != dt.Rows.Count)
                {
                    bool possuiAcesso = Boolean.Parse(dt.Rows[i]["usuariocamp_acesso"].ToString());
                    if (possuiAcesso)
                        return true;
                    return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public bool atualizaPerm(DataTable dt, int userId)
        {
            bool result = true;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String sql = "UPDATE usuario_campo SET usuariocamp_acesso = @3 WHERE usuario_id = @4 AND camp_id = @1 AND tela_id = @2";
                sql = sql.Replace("@1", ""+dt.Rows[i]["camp_id"]);
                sql = sql.Replace("@2", "" + dt.Rows[i]["tela_id"]);
                sql = sql.Replace("@3", "" + dt.Rows[i]["usuariocamp_acesso"]);
                sql = sql.Replace("@4", "" + userId);
                bco.conecta();
                result = bco.executeNonQuery(sql);
                bco.desconecta();
            }
            return result;
        }

        public DataTable getUsuarios(Usuario user, String filtro)
        {
            DataTable dt = null;
            String sql = "";
            if(filtro.Equals("all"))
            {
                sql = "SELECT u.usuario_id, u.usuario_pass, u.usuario_login, u.usuario_status, f.func_nome "+
                    "FROM usuario as u LEFT OUTER JOIN funcionario as f ON u.usuario_id = f.usuario_id WHERE usuario_login ILIKE '@1%'";
                sql = sql.Replace("@1", user.Login);
            }
            if (filtro.Equals("bloq"))
            {
                sql = "SELECT u.usuario_id, u.usuario_pass, u.usuario_login, u.usuario_status, f.func_nome "+
                    "FROM usuario as u LEFT OUTER JOIN funcionario as f ON u.usuario_id = f.usuario_id " +
                    "WHERE usuario_login ILIKE '@1%' AND usuario_status = false";
                sql = sql.Replace("@1", user.Login);
            }
            if (filtro.Equals("desbloq"))
            {
                sql = "SELECT u.usuario_id, u.usuario_pass, u.usuario_login, u.usuario_status, f.func_nome " +
                    "FROM usuario as u LEFT OUTER JOIN funcionario as f ON u.usuario_id = f.usuario_id " +
                    "WHERE usuario_login ILIKE '@1%' AND usuario_status = true";
                sql = sql.Replace("@1", user.Login);
            }
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool atualizaStatus(Usuario user)
        {
            bool result = false;
            String sql = "UPDATE usuario SET usuario_status = @1 WHERE usuario_id = @2";
            sql = sql.Replace("@1", "" + user.Status);
            sql = sql.Replace("@2", "" + user.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public DataTable getConexoes(DateTime dtInicio, DateTime dtFim, String filtro, int userId)
        {
            DataTable dt = null;
            String sql = "";
            if (filtro == "on")
            {
                sql = "SELECT acess_ent, acess_sai FROM acesso WHERE usuario_id = @1 and " +
                    "acess_ent >= '@2' and acess_ent <= '@3'";
                sql = sql.Replace("@1", ""+userId);
                sql = sql.Replace("@2", ""+dtInicio);
                sql = sql.Replace("@3", "" + dtFim);
            }
            else
            {
                sql = "SELECT acess_ent, acess_sai FROM acesso WHERE usuario_id = @1";
                sql = sql.Replace("@1", ""+userId);
            }
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool trocaSenha(Usuario user)
        {
            bool result = true;
            String sql = "UPDATE usuario SET usuario_pass = '@1' WHERE usuario_id = @2";
            sql = sql.Replace("@1", user.Senha);
            sql = sql.Replace("@2", ""+user.Id);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public int getUltimoId()
        {
            String sql = "SELECT MAX(usuario_id) as pk FROM usuario";
            DataTable dt;
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return Convert.ToInt32(dt.Rows[0]["pk"]);
        }

        public Usuario getUserById(int id)
        {
            Usuario user = new Usuario();
            DataTable dt;
            String sql = "SELECT usuario_login FROM usuario WHERE usuario_id = @1";
            sql = sql.Replace("@1", "" + id);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
                user.Login = dt.Rows[0]["usuario_login"].ToString();
            return user;
        }
    }
}
