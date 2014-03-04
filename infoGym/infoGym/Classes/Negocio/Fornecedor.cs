using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Fornecedor
    {
        String razaoS, cnpj, inscEst, bairro, rua, num, cep, email, site, fone, cel, representante, cidCod, id;
        FornecedorBD fornBD;
        public Fornecedor()
        {
            fornBD = new FornecedorBD();
            razaoS = "";
            cnpj = "";
            inscEst = "";
            bairro = "";
            rua = "";
            num = "";
            cep = "";
            email = "";
            site = "";
            fone = "";
            cel = "";
            representante = "";
            cidCod = "";
            id = "";
        }
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String CidCod
        {
            get { return cidCod; }
            set { cidCod = value; }
        }

        public String Representante
        {
            get { return representante; }
            set { representante = value; }
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

        public String Site
        {
            get { return site; }
            set { site = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Num
        {
            get { return num; }
            set { num = value; }
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

        public String InscEst
        {
            get { return inscEst; }
            set { inscEst = value; }
        }

        public String Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public String RazaoS
        {
            get { return razaoS; }
            set { razaoS = value; }
        }

        public bool novo()
        {
            return fornBD.novo(this);
        }

        public String getTotal()
        {
            return fornBD.getTotal();
        }

        public DataTable getFornecedores()
        {
            return fornBD.getFornecedores(this.razaoS);
        }

        public bool excluir()
        {
            return fornBD.excluir(this);
        }

        public Fornecedor getById()
        {
            return fornBD.getById(id);
        }

        public bool altera()
        {
            return fornBD.altera(this);
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
