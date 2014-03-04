using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;

namespace infoGym.Classes.Negocio
{
    class Composicao
    {
        String id, peso, altura, imc, subescapular, tricipital,
            axilar, supra, peitoral, abdominal, coxa, protocolo,
            gorduraI, gorduraA, massaM, massaG, imcLegenda;
        ComposicaoBD compBD;

        public Composicao()
        {
            compBD = new ComposicaoBD();
        }

        public String ImcLegenda
        {
            get { return imcLegenda; }
            set { imcLegenda = value; }
        }

        public String MassaG
        {
            get { return massaG; }
            set { massaG = value; }
        }

        public String MassaM
        {
            get { return massaM; }
            set { massaM = value; }
        }

        public String GorduraA
        {
            get { return gorduraA; }
            set { gorduraA = value; }
        }

        public String GorduraI
        {
            get { return gorduraI; }
            set { gorduraI = value; }
        }

        public String Protocolo
        {
            get { return protocolo; }
            set { protocolo = value; }
        }

        public String Coxa
        {
            get { return coxa; }
            set { coxa = value; }
        }

        public String Abdominal
        {
            get { return abdominal; }
            set { abdominal = value; }
        }

        public String Peitoral
        {
            get { return peitoral; }
            set { peitoral = value; }
        }

        public String Supra
        {
            get { return supra; }
            set { supra = value; }
        }

        public String Axilar
        {
            get { return axilar; }
            set { axilar = value; }
        }

        public String Tricipital
        {
            get { return tricipital; }
            set { tricipital = value; }
        }

        public String Subescapular
        {
            get { return subescapular; }
            set { subescapular = value; }
        }

        public String Imc
        {
            get { return imc; }
            set { imc = value; }
        }

        public String Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public String Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String[] IMC(String altura, String peso)
        {
            String[] result = new String[2];
            Double imc;
            altura = altura.Replace(".", ",");
            peso = peso.Replace(".", ",");
            try
            {
                imc = Convert.ToDouble(peso) / (Convert.ToDouble(altura) * Convert.ToDouble(altura));
                result[0] = "" + Math.Round(imc, 2);
                if (imc < 18.5)
                    result[1] = "abaixo do peso";
                else
                    if (imc >= 18.5 && imc < 25)
                        result[1] = "peso normal";
                    else
                        if (imc >= 25 && imc < 30)
                            result[1] = "acima do peso";
                        else
                            result[1] = "obeso";
            }
            catch
            {
                result[0] = "";
                result[1] = "";
            }
            return result;
        }

        public String[] getResultados(int idade, String pesoS, params String[] medidas)
        {
            String[] resultados = new String[4];
            try
            {
                Double dc = 0;
                Double peso = Convert.ToDouble(pesoS);
                if (medidas.Length == 3)
                {
                    dc = getPollock3Dobras(medidas[0], medidas[1], medidas[2], idade);
                    resultados[3] = "" + 15;
                }
                if (medidas.Length == 7)
                {
                    dc = getPollock7Dobras(idade, medidas[0], medidas[1], medidas[2], medidas[3], medidas[4],
                        medidas[5], medidas[6]);
                    resultados[3] = "" + 25;
                }
                if (dc != 0)
                {
                    Double gorduraAtual = Math.Round(getGorduraCorporalMetodoSiri(dc), 2);
                    resultados[0] = "" + gorduraAtual;
                    Double massaGorda = Math.Round(gorduraAtual / 100 * Convert.ToDouble(peso), 2);
                    resultados[1] = "" + massaGorda;
                    Double massaMagra = Convert.ToDouble(peso) - massaGorda;
                    resultados[2] = "" + massaMagra;
                }
            }
            catch { }
            return resultados;
        }

        private Double getPollock3Dobras(String peito, String abdome, String coxa, int idade)
        {
            Double dc = 0; //densidade corporal
            try
            {
                Double somatorio = Convert.ToDouble(peito) + Convert.ToDouble(abdome) + Convert.ToDouble(coxa);
                dc = 1.1093800 - 0.0008267 * somatorio + 0.0000016 * (somatorio * somatorio) - 0.0002574 * idade;
            }
            catch { }
            return dc;
        }

        private Double getPollock7Dobras(int idade, String peito, String abdome, String coxa, String axilarM,
            String subEscapular, String supra, String tricipital)
        {
            Double dc = 0;
            try
            {
                Double somatorio1 = Convert.ToDouble(peito) + Convert.ToDouble(abdome) + Convert.ToDouble(coxa) +
                    Convert.ToDouble(axilarM) + Convert.ToDouble(subEscapular) + Convert.ToDouble(supra) + Convert.ToDouble(tricipital);
                dc = 1.0970 - 0.00046971 * somatorio1 + 0.00000056 * (somatorio1 * somatorio1) - 0.00012828 * idade;
                //DC= 1,0970 - [0,00046971 (X1) + 0,00000056 (X1)²] - [0,00012828 (X3)]
            }
            catch { }
            return dc;
        }

        private Double getGorduraCorporalMetodoSiri(Double dc)
        {
            /* Siri (1961) Avalia o percentual de gordura a partir da Densidade Corporal (DC) encontrada em outros
                protocolos. %G = [(4,95/Densidade Corporal) - 4,50] x 100 */
            return (4.95 / dc - 4.50) * 100;
        }

        public Composicao getById()
        {
            return compBD.getById(id);
        }

        public bool nova(String avaId, char sexo)
        {
            return compBD.nova(avaId, sexo);
        }

        public bool update()
        {
            return compBD.update(this);
        }
    }
}
