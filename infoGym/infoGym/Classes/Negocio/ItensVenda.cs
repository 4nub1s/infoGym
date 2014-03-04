using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoGym.Classes.Negocio
{
    class ItensVenda
    {
        String prodId, qtde, valor;

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public String ProdId
        {
            get { return prodId; }
            set { prodId = value; }
        }

        public ItensVenda()
        {
            prodId = qtde = valor = "";
        }

        public ItensVenda(String prodId, String qtde, String valor)
        {
            this.prodId = prodId;
            this.qtde = qtde;
            this.valor = valor;
        }
    }
}
