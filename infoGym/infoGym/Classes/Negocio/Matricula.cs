using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Matricula
    {
        String id, modId, aluId, dtVcmto, tolerancia, tipo, qtdeDias, dtIni, dtFim, obs;
        MatriculaBD matBD;

        public String Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        public String DtFim
        {
            get { return dtFim; }
            set { dtFim = value; }
        }

        public String DtIni
        {
            get { return dtIni; }
            set { dtIni = value; }
        }

        public String QtdeDias
        {
            get { return qtdeDias; }
            set { qtdeDias = value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Tolerancia
        {
            get { return tolerancia; }
            set { tolerancia = value; }
        }

        public String DtVcmto
        {
            get { return dtVcmto; }
            set { dtVcmto = value; }
        }

        public String AluId
        {
            get { return aluId; }
            set { aluId = value; }
        }

        public String ModId
        {
            get { return modId; }
            set { modId = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public Matricula()
        {
            id = modId = aluId = dtVcmto = tolerancia = tipo = qtdeDias = dtIni = dtFim = obs = "";
            matBD = new MatriculaBD();
        }

        public String nova()
        {
            if (tipo.Equals("d"))
                return matBD.novoDiarista(this);
            else
                if (tipo.Equals("m"))
                    return matBD.novoMensalista(this);
                else
                    return "";
        }

        public bool atualiza()
        {
            if (tipo.Equals("d"))
                return matBD.atualizaDiarista(this);
            else
                if (tipo.Equals("m"))
                    return matBD.atualizaMensalista(this);
                else
                    return false;
        }

        public String getInfos(String infoDesejada)
        {
            return matBD.getInfos(infoDesejada);
        }

        public DataTable consulta(String status, String formaPgmto, String modalidade, String aluno)
        {
            return matBD.consulta(status, formaPgmto, modalidade, aluno);
        }

        public Matricula getById()
        {
            return matBD.getById(id);
        }

        public bool excluir()
        {
            return matBD.excluir(id);
        }

        public bool adicionarCreditos(String userId, Decimal valorFinal)
        {
            Movimentacao mov = new Movimentacao();
            mov.AcessId = userId;
            mov.CaiData = DateTime.Today.ToShortDateString();
            Aluno alu = new Aluno();
            alu.Id = Convert.ToInt32(aluId);
            alu = alu.getAlunoById();
            mov.Desc = "Pagamento de " + qtdeDias + " diária(s) do aluno: " + alu.Nome;
            mov.MatCod = id;
            mov.Valor = "" + valorFinal;
            return matBD.adicionarCreditos(this, mov);
        }

        public DataTable getMensalidades()
        {
            return matBD.getMensalidades(id);
        }
    }
}
