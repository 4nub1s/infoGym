using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Movimentacao
    {
        MovimentacaoBD movBD;
        String saidaId;
        String entradaId, matCod, venCod, caiData, acessId, valor, desc;

        public Movimentacao()
        {
            movBD = new MovimentacaoBD();
            saidaId = entradaId = matCod = venCod = caiData = acessId = valor = desc = "";
        }

        public String AcessId
        {
            get { return acessId; }
            set { acessId = value; }
        }

        public String SaidaId
        {
            get { return saidaId; }
            set { saidaId = value; }
        }
        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public String CaiData
        {
            get { return caiData; }
            set { caiData = value; }
        }

        public String VenCod
        {
            get { return venCod; }
            set { venCod = value; }
        }

        public String MatCod
        {
            get { return matCod; }
            set { matCod = value; }
        }

        public String EntradaId
        {
            get { return entradaId; }
            set { entradaId = value; }
        }

        public bool novaEntrada()
        {
            return movBD.novaEntrada(this);
        }

        public bool novaSaida()
        {
            return movBD.novaSaida(this);
        }

        public Movimentacao getEntradaById()
        {
            return movBD.getEntradaById(entradaId);
        }

        public Movimentacao getSaidaById()
        {
            return movBD.getSaidaById(saidaId);
        }

        public DataTable getSaidasByDia()
        {
            return movBD.getSaidasByDia(caiData);
        }

        public DataTable getEntradasByDia()
        {
            return movBD.getEntradasByDia(caiData);
        }

        public DataTable getMovByDia(String filtro)
        {
            return movBD.getMovByDia(caiData, filtro);
        }

        public String getTotalEntradas()
        {
            return movBD.getTotalEntradas(caiData);
        }

        public String getTotalSaidas()
        {
            return movBD.getTotalSaidas(caiData);
        }

        public bool excluir()
        {
            return movBD.excluir(this);
        }

        public int getQtdeMensalidades()
        {
            return movBD.getQtdeMensalidades(matCod);
        }
    }
}
