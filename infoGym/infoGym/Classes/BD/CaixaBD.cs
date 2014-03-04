using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using infoGym.Classes.Negocio;

namespace infoGym.Classes.BD
{
    class CaixaBD
    {
        Banco bco;
        String sql;
        DataTable dt = null;
        bool result;

        public CaixaBD()
        {
            bco = new Banco();
            sql = "";
            dt = null;
            result = false;
        }

        public bool novo(Caixa cai)
        {
            sql = "INSERT INTO caixa(cai_data, cai_horaabertura, cai_valorini, " +
            "cai_userabriu) VALUES ('@1', '@2', '@3', '@4');";
            DateTime horaAbertura = new DateTime();
            horaAbertura = DateTime.Now;
            String data = horaAbertura.ToShortDateString();
            sql = sql.Replace("@1", data);
            sql = sql.Replace("@2", ""+horaAbertura);
            sql = sql.Replace("@3", cai.CaiValorIni);
            sql = sql.Replace("@4", cai.UserAbriu);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public bool atualiza(Caixa cai)
        {
            sql = "UPDATE caixa SET cai_horafechamento='@2', " +
            "cai_valorfin='@3' WHERE cai_data = '@1'";
            sql = sql.Replace("@1", cai.CaiData);
            sql = sql.Replace("@2", cai.CaiFech);
            sql = sql.Replace("@3", cai.CaiValorFin);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public DataTable getCaixaByData(String data)
        {
            sql = "SELECT * FROM caixa WHERE cai_data = '@1'";
            sql = sql.Replace("@1", data);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            return dt;
        }

        public bool isFechado(String data)
        {
            sql = "SELECT cai_horafechamento FROM caixa WHERE cai_data = '@1'";
            sql = sql.Replace("@1", data);
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            result = false;
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["cai_horafechamento"].ToString() != "")
                    result = true;
            }
            return result;
        }

        public String getUltimoCaixa()
        {
            String retorno = "";
            sql = "SELECT MAX(cai_data) as maxcaixa FROM caixa";
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                retorno = dt.Rows[0]["maxcaixa"].ToString();
            }
            return retorno;
        }

        public bool isAntFechado()
        {
            result = true;
            Caixa cai = new Caixa();
            cai.CaiData = getUltimoCaixa();
            cai = cai.getCaixaByData(); //pega dia anterior
            if (cai.CaiAbert != "") //verifica se foi aberto
                if (cai.CaiFech == "") //verifica se não foi fechado
                {
                    result = false;
                }
            return result;
        }

        public bool fechar(Caixa cai)
        {
            sql = "UPDATE caixa SET cai_horafechamento = '@1', cai_valorfin = '@2', cai_userfechou = '@3' " +
                "WHERE cai_data = '@A'";
            sql = sql.Replace("@1", cai.CaiFech);
            sql = sql.Replace("@2", cai.CaiValorFin);
            sql = sql.Replace("@3", cai.UserFechou);
            sql = sql.Replace("@A", cai.CaiData);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
    }
}
