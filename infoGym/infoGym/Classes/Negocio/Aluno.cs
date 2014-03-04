using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace infoGym
{
    class Aluno
    {
        char sexo;
        String dtNasc;
        String nome, rg, cpf, bairro, rua, numero, cep, cel, fone, email, cidade, terId;

       
        AlunoBD alunoBD;
        int id;

        public Aluno()
        {
            alunoBD = new AlunoBD();
            sexo = 'm';
            nome = rg = cpf = bairro = rua = numero = cep = cel = fone = email = cidade = terId = "";
        }

        public Aluno(String nome, String rg, String cpf, String bairro,
            String rua, String numero, String cep, String cel, String fone, 
            String email, String cidade, String dtNasc, char sexo)
        {
            alunoBD = new AlunoBD();
            this.nome = nome;
            this.rg = rg; this.cpf = cpf; this.bairro = bairro; this.rua = rua;
            this.numero = numero; this.cep = cep; this.cel = cel; this.fone = fone;
            this.email = email; this.cidade = cidade; this.dtNasc = dtNasc;
            this.sexo = sexo;
        }

        public Aluno getAlunoById()
        {
            return alunoBD.getAlunoById(this.id);
        }

        public String TerId
        {
            get { return terId; }
            set { terId = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public String DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }


        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public String Cel
        {
            get { return cel; }
            set { cel = value; }
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

        public String Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public String Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DataTable getAlunos(String filtro)
        {
            return alunoBD.getAlunos(this, filtro);
        }

        public bool cadastrar()
        {
            return alunoBD.cadastrar(this);
        }

        public bool excluir()
        {
            return alunoBD.excluir(this);
        }

        public DataTable getAluno()
        {
            return alunoBD.getAluno(this);
        }

        public bool atualizar()
        {
            return alunoBD.atualizar(this);
        }

        public int getUltimoId()
        {
            return alunoBD.getUltimoId();
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

        public bool addTermo()
        {
            return alunoBD.addTermo(this);
        }

        public String getAlunoByTermo()
        {
            return alunoBD.getAlunoByTermo(this.terId);
        }
       
    }
}
