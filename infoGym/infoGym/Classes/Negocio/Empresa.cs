using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;

namespace infoGym.Classes.Negocio
{
    class Empresa
    {
        String rua, bairro, numero, cep, cidCod, fone;
        String cnpj, nome, razaoSocial, proprietario, site, email;
        EmpresaBD empBD;
 

        public Empresa()
        {
            empBD = new EmpresaBD();
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Site
        {
            get { return site; }
            set { site = value; }
        }

        public String Proprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }

        public String RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
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

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }

        public bool nova()
        {
            return empBD.nova(this);
        }

        public Empresa getEmp()
        {
            return empBD.getEmp();
        }

        public bool atualiza()
        {
            return empBD.atualiza(this);
        }


        public String getFoneDDD()
        {
            return fone.Remove(2, fone.Length - 2);
        }

        public String getFone()
        {
            return fone.Remove(0, 2);
        }
    }
}
