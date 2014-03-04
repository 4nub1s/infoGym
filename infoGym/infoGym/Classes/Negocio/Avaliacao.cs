using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Avaliacao
    {
        String id, aluId, funcId, dtAgen, dtRealizada, anaId, perId, compId, neuroId;
        AvaliacaoBD avaBD;

        public Avaliacao()
        {
            id = aluId = funcId = dtAgen = dtRealizada = anaId = perId = "";
            avaBD = new AvaliacaoBD();
        }

        public String NeuroId
        {
            get { return neuroId; }
            set { neuroId = value; }
        }

        public String CompId
        {
            get { return compId; }
            set { compId = value; }
        }

        public String PerId
        {
            get { return perId; }
            set { perId = value; }
        }

        public String AnaId
        {
            get { return anaId; }
            set { anaId = value; }
        }

        public String DtRealizada
        {
            get { return dtRealizada; }
            set { dtRealizada = value; }
        }

        public String DtAgen
        {
            get { return dtAgen; }
            set { dtAgen = value; }
        }

        public String FuncId
        {
            get { return funcId; }
            set { funcId = value; }
        }

        public String AluId
        {
            get { return aluId; }
            set { aluId = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool novoAgendamento()
        {
            return avaBD.novoAgendamento(this);
        }

        public bool getRestricaoHorario()
        {
            return avaBD.getRestricaoHorario(this.dtAgen);
        }

        public String getTotal()
        {
            return avaBD.getTotal();
        }

        public String getNaoRealizadas()
        {
            return avaBD.getNaoRealizadas();
        }

        public String getEmAtraso()
        {
            return avaBD.getEmAtraso();
        }

        public DataTable getAgendaAvaliacoes(String status, String dtIni, String dtFim, bool ligaData, bool msmDia)
        {
            return avaBD.getAgendaAvaliacoes(this, status, dtIni, dtFim, ligaData, msmDia);
        }

        public bool jaRealizada()
        {
            return avaBD.jaRealizada(id);
        }

        public bool excluirAgendamento()
        {
            return avaBD.excluirAgendamento(id);
        }

        public bool vinculaAnamnese()
        {
            return avaBD.vinculaAnamnese(anaId, id);
        }

        public Avaliacao getById()
        {
            return avaBD.getById(id);
        }

    }
}
