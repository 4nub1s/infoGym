using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Despesa
    {
        String id, desc, valor, dtPgmto, dtVcmto, valorPg;
        DespesaBD despBD;
        public Despesa()
        {
            id = desc = valor = dtPgmto = dtVcmto = valorPg = "";
            despBD = new DespesaBD();
        }

        public String ValorPg
        {
            get { return valorPg; }
            set { valorPg = value; }
        }

        public String DtVcmto
        {
            get { return dtVcmto; }
            set { dtVcmto = value; }
        }

        public String DtPgmto
        {
            get { return dtPgmto; }
            set { dtPgmto = value; }
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

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool nova()
        {
            return despBD.nova(this);
        }

        public DataTable consulta(String dtInicio, String dtFim, String situacao, String desc, bool ignoraPeriodo)
        {
            return despBD.consulta(dtInicio, dtFim, situacao, desc, ignoraPeriodo);
        }

        public Despesa getById()
        {
            Despesa desp = new Despesa();
            DataTable aux = despBD.getById(id);
            if (aux.Rows.Count > 0)
            {
                desp.Id = aux.Rows[0]["desp_id"].ToString();
                desp.Desc = aux.Rows[0]["desp_desc"].ToString();
                desp.DtPgmto = aux.Rows[0]["desp_dtpg"].ToString();
                desp.DtVcmto = aux.Rows[0]["desp_dtvenc"].ToString();
                desp.Valor = aux.Rows[0]["desp_valor"].ToString();
                desp.ValorPg = aux.Rows[0]["desp_valorpg"].ToString();
            }

            return desp;
        }

        public bool atualizar()
        {
            return despBD.atualizar(this);
        }

        public bool excluir()
        {
            return despBD.excluir(id);
        }

        public String getTotalPago(String dtInicio, String dtFim)
        {
            return despBD.getTotalPago(dtInicio, dtFim);
        }

        public String getTotalPagar(String dtInicio, String dtFim)
        {
            return despBD.getTotalPagar(dtInicio, dtFim);
        }

        public String getTotalGeral(String dtInicio, String dtFim)
        {
            return despBD.getTotalGeral(dtInicio, dtFim);
        }

    }
}
