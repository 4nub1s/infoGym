using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infoGym.Classes
{
    class Anamnese
    {
        String anaId, probCard, probOrto, probNeuro, probGastro, probResp, probDesc, fumante, fumanteEx, diabetico, diabete_familia, gestante, alergia, tontura, vertigem,
            osteoporose, hipertenso, bebida, infartoFamilia, medicamento, cirurgia, dores, estado_geral, refeicoes, atividadeFisica, partesCorpo, objetivo;
        AnamneseBD anaBD;

        public Anamnese()
        {
            anaBD = new AnamneseBD();
        }

        public String Objetivo
        {
            get { return objetivo; }
            set { objetivo = value; }
        }

        public String PartesCorpo
        {
            get { return partesCorpo; }
            set { partesCorpo = value; }
        }

        public String AtividadeFisica
        {
            get { return atividadeFisica; }
            set { atividadeFisica = value; }
        }

        public String Refeicoes
        {
            get { return refeicoes; }
            set { refeicoes = value; }
        }

        public String Estado_geral
        {
            get { return estado_geral; }
            set { estado_geral = value; }
        }

        public String Dores
        {
            get { return dores; }
            set { dores = value; }
        }

        public String Cirurgia
        {
            get { return cirurgia; }
            set { cirurgia = value; }
        }

        public String Medicamento
        {
            get { return medicamento; }
            set { medicamento = value; }
        }

        public String InfartoFamilia
        {
            get { return infartoFamilia; }
            set { infartoFamilia = value; }
        }

        public String Bebida
        {
            get { return bebida; }
            set { bebida = value; }
        }

        public String Hipertenso
        {
            get { return hipertenso; }
            set { hipertenso = value; }
        }

        public String Osteoporose
        {
            get { return osteoporose; }
            set { osteoporose = value; }
        }

        public String Vertigem
        {
            get { return vertigem; }
            set { vertigem = value; }
        }

        public String Tontura
        {
            get { return tontura; }
            set { tontura = value; }
        }

        public String Alergia
        {
            get { return alergia; }
            set { alergia = value; }
        }

        public String Gestante
        {
            get { return gestante; }
            set { gestante = value; }
        }

        public String Diabete_familia
        {
            get { return diabete_familia; }
            set { diabete_familia = value; }
        }

        public String Diabetico
        {
            get { return diabetico; }
            set { diabetico = value; }
        }

        public String FumanteEx
        {
            get { return fumanteEx; }
            set { fumanteEx = value; }
        }

        public String Fumante
        {
            get { return fumante; }
            set { fumante = value; }
        }

        public String ProbDesc
        {
            get { return probDesc; }
            set { probDesc = value; }
        }

        public String ProbResp
        {
            get { return probResp; }
            set { probResp = value; }
        }

        public String ProbGastro
        {
            get { return probGastro; }
            set { probGastro = value; }
        }

        public String ProbNeuro
        {
            get { return probNeuro; }
            set { probNeuro = value; }
        }

        public String ProbOrto
        {
            get { return probOrto; }
            set { probOrto = value; }
        }

        public String ProbCard
        {
            get { return probCard; }
            set { probCard = value; }
        }
        
        public String AnaId
        {
            get { return anaId; }
            set { anaId = value; }
        }

        public Anamnese getById()
        {
            return anaBD.getById(anaId);
        }

        public bool nova(String avaId)
        {
            return anaBD.nova(avaId);
        }

        public bool update()
        {
            return anaBD.update(this);
        }
    }
}
