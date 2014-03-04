using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Caixa
    {
        CaixaBD caiBD;
        String caiData, caiAbert, caiFech, caiValorIni, caiValorFin, userAbriu, userFechou;

        public Caixa()
        {
            caiBD = new CaixaBD();
            caiData = caiAbert = caiFech = caiValorIni = caiValorFin = userAbriu = userFechou = "";
        }

        public String UserAbriu
        {
            get { return userAbriu; }
            set { userAbriu = value; }
        }

        public String UserFechou
        {
            get { return userFechou; }
            set { userFechou = value; }
        }

        public String CaiValorFin
        {
            get { return caiValorFin; }
            set { caiValorFin = value; }
        }

        public String CaiValorIni
        {
            get { return caiValorIni; }
            set { caiValorIni = value; }
        }

        public String CaiFech
        {
            get { return caiFech; }
            set { caiFech = value; }
        }

        public String CaiAbert
        {
            get { return caiAbert; }
            set { caiAbert = value; }
        }

        public String CaiData
        {
            get { return caiData; }
            set { caiData = value; }
        }

        public bool novo()
        {
            return caiBD.novo(this);
        }

        public bool atualiza()
        {
            return caiBD.atualiza(this);
        }

        public Caixa getCaixaByData()
        {
            Caixa cai = new Caixa();
            DataTable dt = caiBD.getCaixaByData(caiData);
            if (dt.Rows.Count > 0)
            {
                cai.caiData = dt.Rows[0]["cai_data"].ToString();
                cai.caiAbert = dt.Rows[0]["cai_horaabertura"].ToString();
                cai.caiFech = dt.Rows[0]["cai_horafechamento"].ToString();
                cai.caiValorIni = dt.Rows[0]["cai_valorini"].ToString();
                cai.caiValorFin = dt.Rows[0]["cai_valorfin"].ToString();
                cai.UserAbriu = dt.Rows[0]["cai_userabriu"].ToString();
                cai.UserFechou = dt.Rows[0]["cai_userfechou"].ToString();

                DateTime aux = DateTime.Parse(cai.caiAbert);
                cai.caiAbert = aux.ToShortTimeString();
                if (cai.caiFech != "")
                {
                    aux = DateTime.Parse(cai.caiFech);
                    cai.caiFech = aux.ToShortTimeString();
                }
            }
            return cai;
        }

        public bool isFechado()
        {
            return caiBD.isFechado(caiData);
        }

        public bool isAntFechado()
        {
            return caiBD.isAntFechado();
        }

        public bool fechar()
        {
            return caiBD.fechar(this);
        }

        public String getUltimoCaixa()
        {
            return caiBD.getUltimoCaixa();
        }
    }
}
