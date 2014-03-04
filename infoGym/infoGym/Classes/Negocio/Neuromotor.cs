using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;

namespace infoGym.Classes.Negocio
{
    class Neuromotor
    {
        /*
         *  neuro_id serial NOT NULL,
              neuro_flexao numeric,
              neuro_abdominal numeric,
              neuro_banco_wells numeric,
         * */
        String id, flexao, abdominal, wells, flexaoLegenda, abdominalLegenda, wellsLegenda;
        NeuromotorBD neuroBD;

        public Neuromotor()
        {
            neuroBD = new NeuromotorBD();
        }

        public String WellsLegenda
        {
            get { return wellsLegenda; }
            set { wellsLegenda = value; }
        }

        public String AbdominalLegenda
        {
            get { return abdominalLegenda; }
            set { abdominalLegenda = value; }
        }

        public String FlexaoLegenda
        {
            get { return flexaoLegenda; }
            set { flexaoLegenda = value; }
        }

        public String Wells
        {
            get { return wells; }
            set { wells = value; }
        }

        public String Abdominal
        {
            get { return abdominal; }
            set { abdominal = value; }
        }

        public String Flexao
        {
            get { return flexao; }
            set { flexao = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public Neuromotor getById()
        {
            return neuroBD.getById(id);
        }

        public bool novo(String avaId)
        {
            return neuroBD.novo(avaId);
        }

        public bool atualiza()
        {
            return neuroBD.atualiza(this);
        }

        public String getAbdominalFaixa(Decimal repe, char sexo)
        {
            String result = "";
            try
            {
                if (sexo == 'm')
                {
                    if (repe <= 32)
                        result = "Ruim";
                    else
                        if (repe > 32 && repe <= 37)
                            result = "Abaixo da média";
                        else
                            if (repe > 37 && repe <= 41)
                                result = "Média";
                            else
                                if (repe > 41 && repe <= 47)
                                    result = "Acima da média";
                                else // >= 39
                                    result = "Excelente";
                }
                else
                {
                    if (repe <= 14)
                        result = "Ruim";
                    else
                        if (repe > 14 && repe <= 19)
                            result = "Abaixo da média";
                        else
                            if (repe > 19 && repe <= 23)
                                result = "Média";
                            else
                                if (repe > 23 && repe <= 28)
                                    result = "Acima da média";
                                else // >= 27
                                    result = "Excelente";
                }
            }
            catch { }
            return result;
        }

        public String getWellsFaixa(String cm, char sexo)
        {
            String result = "";
            try
            {
                cm = cm.Replace(",", ".");
                Double repe = Convert.ToDouble(cm);
                if (sexo == 'm')
                {
                    if (repe <= 23)
                        result = "Ruim";
                    else
                        if (repe > 23 && repe <= 28)
                            result = "Abaixo da média";
                        else
                            if (repe > 28 && repe <= 33)
                                result = "Média";
                            else
                                if (repe > 33 && repe <= 38)
                                    result = "Acima da média";
                                else // >= 39
                                    result = "Excelente";
                }
                else
                {
                    if (repe <= 26)
                        result = "Ruim";
                    else
                        if (repe > 26 && repe <= 31)
                            result = "Abaixo da média";
                        else
                            if (repe > 31 && repe <= 35)
                                result = "Média";
                            else
                                if (repe > 35 && repe <= 40)
                                    result = "Acima da média";
                                else // >= 41
                                    result = "Excelente";
                }
            }
            catch { }
            return result;
        }

        public String getFlexaoFaixa(Decimal repe, char sexo)
        {
            String result = "";
            try
            {
                if (sexo == 'm')
                {
                    if (repe <= 17)
                        result = "Ruim";
                    else
                        if (repe > 17 && repe <= 22)
                            result = "Abaixo da média";
                        else
                            if (repe > 22 && repe <= 28)
                                result = "Média";
                            else
                                if (repe > 28 && repe <= 38)
                                    result = "Acima da média";
                                else // >= 39
                                    result = "Excelente";
                }
                else
                {
                    if (repe <= 7)
                        result = "Ruim";
                    else
                        if (repe > 7 && repe <= 12)
                            result = "Abaixo da média";
                        else
                            if (repe > 12 && repe <= 19)
                                result = "Média";
                            else
                                if (repe > 19 && repe <= 26)
                                    result = "Acima da média";
                                else // >= 27
                                    result = "Excelente";
                }
            }
            catch { }
            return result;
        }
    }
}
