using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace infoGym
{
    public class Usuario
    {
        String login, senha;
        bool status;
        bool logado;
        int ultimoAcesso;
        int id;
        UsuarioBD userBD;

        public Usuario()
        {
            userBD = new UsuarioBD();
        }

        public Usuario(String login, String senha)
        {
            this.login = login;
            this.senha = senha;
            this.status = true;
            this.logado = false;
            userBD = new UsuarioBD();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int UltimoAcesso
        {
            get { return ultimoAcesso; }
            set { ultimoAcesso = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public bool Logado
        {
            get { return logado; }
            set { logado = value; }
        }

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public bool logar()
        {
            bool result =  userBD.logar(this);
            return result;
        }

        public bool isBloq()
        {
            bool result = userBD.isBloq(this);
            return result;
        }

        public bool isLogado()
        {
            bool result = userBD.isLogado(this);
            return result;
        }

        public bool deslogar()
        {
            bool result = userBD.deslogar(this);
            return result;
        }

        public String getUltimaCon()
        {
            return userBD.getUltimaCon(this);
        }

        public DataTable gettela()
        {
            return userBD.gettela();
        }

        public DataTable getCampos(int tela)
        {
            return userBD.getCampos(tela);
        }

        public DataTable getCamposUsuario()
        {
            return userBD.getCamposUsuario(this.Id);
        }

        public bool criarNovo()
        {
            return userBD.criarNovo(this);
        }

        public bool atualizaPerm(DataTable dt)
        {
            return userBD.atualizaPerm(dt, id);
        }

        public DataTable getUsuarios(String filtro)
        {
            return userBD.getUsuarios(this, filtro);
        }

        public void getStatus()
        {
            status = isBloq();
        }

        public bool atualizaStatus()
        {
            return userBD.atualizaStatus(this);
        }

        public DataTable getConexoes(DateTime dtInicio, DateTime dtFim, String filtro)
        {
            return userBD.getConexoes(dtInicio, dtFim, filtro, Id);
        }

        public bool trocaSenha()
        {
            return userBD.trocaSenha(this);
        }

        public bool hasAcessoTela(String nomeTela)
        {
            DataTable dt;
            int idTela = userBD.getIdTela(nomeTela);
            dt = getCamposUsuario();
            int cont = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["tela_id"]) == idTela && Convert.ToBoolean(dt.Rows[i]["usuariocamp_acesso"]))
                    cont++;
            }
            if (cont > 0) //possui acesso a pelo menos um campo da tela
                return true;
            return false;
        }

        public int getUltimoId()
        {
            return userBD.getUltimoId();
        }

        public Usuario getUserById()
        {
            return userBD.getUserById(id);
        }

        public bool hasPermissionField(String campoNome)
        {
            return userBD.hasPermissionField(id, campoNome);
        }
    }
}
