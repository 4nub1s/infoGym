using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Funcionario
    {
        FuncionarioBD funcBD;
        
        
        String nome, categoria, rg, cpf, dtNasc, bairro, rua, numero, cep;
        String fone, cel, email, dtAdm, dtDem;
        String id, cidCod, usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
       
        public String DtDem
        {
            get { return dtDem; }
            set { dtDem = value; }
        }

        public String DtAdm
        {
            get { return dtAdm; }
            set { dtAdm = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Cel
        {
            get { return cel; }
            set { cel = value; }
        }

        public String Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public String CidCod
        {
            get { return cidCod; }
            set { cidCod = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Funcionario()
        {
            funcBD = new FuncionarioBD();
        }

        public Funcionario getFuncByUser(int userId)
        {
            return funcBD.getFuncByUser(userId);
        }

        public DataTable getFunc(String filtro1, String filtro2)
        {
            return funcBD.getFunc(filtro1, filtro2, nome);
        }

        public bool cadastrar()
        {
            return funcBD.cadastrar(this);
        }

        public int getUltimoId()
        {
            return funcBD.getUltimoId();
        }

        public void getDadosFunc()
        {
            Funcionario aux = funcBD.getDadosFunc(Id);
            this.Id = aux.Id;
            this.Bairro = aux.Bairro;
            this.Cel = aux.Cel;
            this.Cep = aux.Cep;
            this.Cpf = aux.Cpf;
            this.DtAdm = aux.DtAdm;
            this.DtDem = aux.DtDem;
            this.DtNasc = aux.DtNasc;
            this.Email = aux.Email;
            this.Fone = aux.Fone;
            this.Nome = aux.Nome;
            this.Numero = aux.Numero;
            this.Rg = aux.Rg;
            this.Rua = aux.Rua;
            this.Usuario = aux.Usuario;
            this.Categoria = aux.Categoria;
            this.CidCod = aux.CidCod;
        }

        public bool possuiUsuario()
        {
            return funcBD.possuiUsuario(id);
        }

        public bool atualizar()
        {
            return funcBD.atualizar(this);
        }

        public bool excluir()
        {
            return funcBD.excluir(this);
        }


        public String getFoneDDD()
        {
            return fone.Remove(2, fone.Length - 2);
        }

        public String getFone()
        {
            return fone.Remove(0, 2);
        }

        public String getCelDDD()
        {
            return cel.Remove(2, cel.Length - 2);
        }

        public String getCel()
        {
            return cel.Remove(0, 2);
        }

    }
}
