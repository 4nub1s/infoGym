using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;

namespace infoGym.Classes.Negocio
{
    class Perimetro
    {
        String id, pescoco, ombro, bracoRelaxE, bracoRelaxD, bracoContraE, bracoContraD,
            antebracoE, antebracoD, toraxRelax, toraxInsp, cintura, abdome, quadril, coxaE, coxaD,
            panturrilhaE, panturrilaD, rcq, rcqLegenda;
        PerimetroBD perBD;
        Utils util;

        public Perimetro()
        {
            perBD = new PerimetroBD();
            util = new Utils();
        }

        public String RcqLegenda
        {
            get { return rcqLegenda; }
            set { rcqLegenda = value; }
        }

        public String Rcq
        {
            get { return rcq; }
            set { rcq = value; }
        }

        public String PanturrilaD
        {
            get { return panturrilaD; }
            set { panturrilaD = value; }
        }

        public String PanturrilhaE
        {
            get { return panturrilhaE; }
            set { panturrilhaE = value; }
        }

        public String CoxaD
        {
            get { return coxaD; }
            set { coxaD = value; }
        }

        public String CoxaE
        {
            get { return coxaE; }
            set { coxaE = value; }
        }

        public String Quadril
        {
            get { return quadril; }
            set { quadril = value; }
        }

        public String Abdome
        {
            get { return abdome; }
            set { abdome = value; }
        }

        public String Cintura
        {
            get { return cintura; }
            set { cintura = value; }
        }

        public String ToraxInsp
        {
            get { return toraxInsp; }
            set { toraxInsp = value; }
        }

        public String ToraxRelax
        {
            get { return toraxRelax; }
            set { toraxRelax = value; }
        }

        public String AntebracoD
        {
            get { return antebracoD; }
            set { antebracoD = value; }
        }

        public String AntebracoE
        {
            get { return antebracoE; }
            set { antebracoE = value; }
        }

        public String BracoContraD
        {
            get { return bracoContraD; }
            set { bracoContraD = value; }
        }

        public String BracoContraE
        {
            get { return bracoContraE; }
            set { bracoContraE = value; }
        }

        public String BracoRelaxD
        {
            get { return bracoRelaxD; }
            set { bracoRelaxD = value; }
        }

        public String BracoRelaxE
        {
            get { return bracoRelaxE; }
            set { bracoRelaxE = value; }
        }

        public String Ombro
        {
            get { return ombro; }
            set { ombro = value; }
        }

        public String Pescoco
        {
            get { return pescoco; }
            set { pescoco = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public Perimetro getById()
        {
            return perBD.getById(id);
        }

        public bool nova(String avaId)
        {
            return perBD.nova(avaId);
        }

        public bool update()
        {
            return perBD.update(this);
        }

        public String[] RCQ(String cintura, String quadril, String dtNasc, char sexo)
        {
            String []result = new String[2];
            int idade = util.getIdade(dtNasc);
            Double rcq;
            try
            {
                cintura = cintura.Replace(".", ",");
                quadril = quadril.Replace(".", ",");
                rcq = Convert.ToDouble(cintura) / Convert.ToDouble(quadril);
                result[0] = "" + Math.Round(rcq, 2);
                if (sexo == 'm')
                {
                    if (idade <= 29)
                    {
                        if (rcq < 0.83)
                            result[1] = "risco baixo";
                        else
                            if (rcq >= 0.83 && rcq <= 0.88)
                                result[1] = "risco moderado";
                            else
                                if (rcq >= 0.89 && rcq <= 0.94)
                                    result[1] = "risco alto";
                                else
                                    result[1] = "risco muito alto";
                    }
                    else
                        if (idade >= 30 && idade <= 39)
                        {
                            if (rcq < 0.84)
                                result[1] = "risco baixo";
                            else
                                if (rcq >= 0.84 && rcq <= 0.91)
                                    result[1] = "risco moderado";
                                else
                                    if (rcq >= 0.92 && rcq <= 0.96)
                                        result[1] = "risco alto";
                                    else
                                        result[1] = "risco muito alto";
                        }
                        else
                            if (idade >= 40 && idade <= 49)
                            {
                                if (rcq < 0.88)
                                    result[1] = "risco baixo";
                                else
                                    if (rcq >= 0.88 && rcq <= 0.95)
                                        result[1] = "risco moderado";
                                    else
                                        if (rcq >= 0.96 && rcq <= 1)
                                            result[1] = "risco alto";
                                        else
                                            result[1] = "risco muito alto";
                            }
                            else
                                if (idade >= 50 && idade <= 59)
                                {
                                    if (rcq < 0.90)
                                        result[1] = "risco baixo";
                                    else
                                        if (rcq >= 0.90 && rcq <= 0.96)
                                            result[1] = "risco moderado";
                                        else
                                            if (rcq >= 0.97 && rcq <= 1.02)
                                                result[1] = "risco alto";
                                            else
                                                result[1] = "risco muito alto";
                                }
                                else //idade >= 60
                                {
                                    if (rcq < 0.91)
                                        result[1] = "risco baixo";
                                    else
                                        if (rcq >= 0.91 && rcq <= 0.98)
                                            result[1] = "risco moderado";
                                        else
                                            if (rcq >= 0.99 && rcq <= 1.03)
                                                result[1] = "risco alto";
                                            else
                                                result[1] = "risco muito alto";
                                }
                }
                else //sexo == feminino
                {
                    if (idade <= 29)
                    {
                        if (rcq < 0.71)
                            result[1] = "risco baixo";
                        else
                            if (rcq >= 0.71 && rcq <= 0.77)
                                result[1] = "risco moderado";
                            else
                                if (rcq >= 0.78 && rcq <= 0.82)
                                    result[1] = "risco alto";
                                else
                                    result[1] = "risco muito alto";
                    }
                    else
                        if (idade >= 30 && idade <= 39)
                        {
                            if (rcq < 0.72)
                                result[1] = "risco baixo";
                            else
                                if (rcq >= 0.72 && rcq <= 0.78)
                                    result[1] = "risco moderado";
                                else
                                    if (rcq >= 0.79 && rcq <= 0.84)
                                        result[1] = "risco alto";
                                    else
                                        result[1] = "risco muito alto";
                        }
                        else
                            if (idade >= 40 && idade <= 49)
                            {
                                if (rcq < 0.73)
                                    result[1] = "risco baixo";
                                else
                                    if (rcq >= 0.73 && rcq <= 0.79)
                                        result[1] = "risco moderado";
                                    else
                                        if (rcq >= 0.80 && rcq <= 0.87)
                                            result[1] = "risco alto";
                                        else
                                            result[1] = "risco muito alto";
                            }
                            else
                                if (idade >= 50 && idade <= 59)
                                {
                                    if (rcq < 0.74)
                                        result[1] = "risco baixo";
                                    else
                                        if (rcq >= 0.74 && rcq <= 0.81)
                                            result[1] = "risco moderado";
                                        else
                                            if (rcq >= 0.82 && rcq <= 0.88)
                                                result[1] = "risco alto";
                                            else
                                                result[1] = "risco muito alto";
                                }
                                else //idade >= 60
                                {
                                    if (rcq < 0.76)
                                        result[1] = "risco baixo";
                                    else
                                        if (rcq >= 0.76 && rcq <= 0.83)
                                            result[1] = "risco moderado";
                                        else
                                            if (rcq >= 0.84 && rcq <= 0.90)
                                                result[1] = "risco alto";
                                            else
                                                result[1] = "risco muito alto";
                                }
                }
            }
            catch
            {
                result[0] = "";
                result[1] = "";
            }
            return result;
        }
    }
}
