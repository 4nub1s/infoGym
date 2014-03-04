using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Venda
    {
        List<ItensVenda> itens;
        String cod, data, aluId, valor, acessId;
        VendaBD venBD;
        String msg, formaPgmto;


        public Venda()
        {
            itens = new List<ItensVenda>();
            cod = data = aluId = valor = acessId = "";
            venBD = new VendaBD();
            msg = "";
            formaPgmto = "";
        }

        public String FormaPgmto
        {
            get { return formaPgmto; }
            set { formaPgmto = value; }
        }

        public String Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public String AcessId
        {
            get { return acessId; }
            set { acessId = value; }
        }

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String AluId
        {
            get { return aluId; }
            set { aluId = value; }
        }

        public String Data
        {
            get { return data; }
            set { data = value; }
        }

        public String Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        public void addItem(String prodId, String qtde, String valor)
        {
            itens.Add(new ItensVenda(prodId, qtde, valor));
        }

        public void setItensVenda(List<ItensVenda> listaItens)
        {
            itens = listaItens;
        }

        public void verificaEstoque() //garante que estoque realmente esteja ok, por ser um sistema em rede
        {
            msg = venBD.verificaEstoque(itens);
        }

        public bool gravar()
        {
            return venBD.gravar(this);
        }

        public List<ItensVenda> getItens()
        {
            return itens;
        }

        public Venda getById()
        {
            return venBD.getById(Cod);
        }

        public String getQtdeVendas()
        {
            return venBD.getQtdeVendas();
        }

        public String getProdMaisVendido()
        {
            return venBD.getProdMaisVendido();
        }

        public DataTable getVendaByDia(DateTime dataInicio, DateTime dataFim)
        {
            return venBD.getVendaByDia(dataInicio, dataFim);
        }

        public bool excluir()
        {
            return venBD.excluir(this);
        }

        public DataTable getVendasPorAluno(String alu_id)
        {
            return venBD.getVendasPorAluno(alu_id);
        }

        public List<String> getVendasComEntrada(DataTable dtVendas)
        {
            return venBD.getVendasComEntrada(dtVendas);
        }

        public DataTable getVendasSemEntrada(String alu_id)
        {
            return venBD.getVendasSemEntrada(alu_id);
        }
    }
}
