using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Produto
    {
        String id, fornId, desc, valor, estoqueA, estoqueMin;
        ProdutoBD prodBD;
        public Produto()
        {
            id = "";
            fornId = "";
            desc = "";
            valor = "";
            estoqueA = "";
            estoqueMin = "";
            prodBD = new ProdutoBD();
        }

        public String EstoqueMin
        {
            get { return estoqueMin; }
            set { estoqueMin = value; }
        }

        public String EstoqueA
        {
            get { return estoqueA; }
            set { estoqueA = value; }
        }

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public String FornId
        {
            get { return fornId; }
            set { fornId = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool novo()
        {
            return prodBD.novo(this);
        }

        public String getTotal()
        {
            return prodBD.getTotal();
        }

        public DataTable getProdutos()
        {
            return prodBD.getProdutos(this.Desc);
        }

        public bool excluir()
        {
            return prodBD.excluir(this);
        }

        public bool atualiza()
        {
            return prodBD.atualiza(this);
        }

        public Produto getById()
        {
            return prodBD.getById(id);
        }

        public int getEstoqueAtual()
        {
            return prodBD.getEstoqueAtual(id);
        }
    }
}
