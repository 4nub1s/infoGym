using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.Negocio;
using System.Data;

namespace infoGym.Classes.BD
{
    class EmpresaBD
    {
        Banco bco;
        String sql;
        List<Empresa> listaEmp;

        public EmpresaBD()
        {
            bco = new Banco();
            listaEmp = new List<Empresa>();
        }

        public bool nova(Empresa emp)
        {
            bool result = true;
            sql = "INSERT INTO dados_empresa (cnpj, razaosocial, nomefantasia, proprietario, site, email, rua, bairro, " +
                "numero, cep, cid_cod, fone) VALUES('@1', '@2', '@3', '@4', '@5', '@6', '@7', '@8', '@9', '@A', '@B', '@C')";
            sql = sql.Replace("@1", emp.Cnpj);
            sql = sql.Replace("@2", emp.RazaoSocial);
            sql = sql.Replace("@3", emp.Nome);
            sql = sql.Replace("@4", emp.Proprietario);
            sql = sql.Replace("@5", emp.Site);
            sql = sql.Replace("@6", emp.Email);
            sql = sql.Replace("@7", emp.Rua);
            sql = sql.Replace("@8", emp.Bairro);
            sql = sql.Replace("@9", emp.Numero);
            sql = sql.Replace("@A", emp.Cep);
            sql = sql.Replace("@B", emp.CidCod);
            sql = sql.Replace("@C", emp.Fone);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }
        /*
        * cnpj character varying(100) NOT NULL,
             razaosocial character varying(100),
             nomefantasia character varying(50),
             proprietario character varying(60),
             site character varying(100),
             email character varying(100),
             rua character varying(100),
             bairro character varying(30),
             numero character varying(10),
             logo character varying(100),
             cep character varying(8),
             cid_cod integer,
             fone character varying(12),
        * */
        public bool atualiza(Empresa emp)
        {
            bool result = true;
            sql = "UPDATE dados_empresa SET razaosocial = '@1', nomefantasia = '@2', proprietario = '@3', site = '@4', email = '@5', rua = '@6', bairro = '@7', " +
                "numero = '@8', cep = '@9', cid_cod = '@A', fone = '@B'" + 
                " WHERE cnpj = '@cnpj'";
            sql = sql.Replace("@1", emp.RazaoSocial);
            sql = sql.Replace("@2", emp.Nome);
            sql = sql.Replace("@3", emp.Proprietario);
            sql = sql.Replace("@4", emp.Site);
            sql = sql.Replace("@5", emp.Email);
            sql = sql.Replace("@6", emp.Rua);
            sql = sql.Replace("@7", emp.Bairro);
            sql = sql.Replace("@8", emp.Numero);
            sql = sql.Replace("@9", emp.Cep);
            sql = sql.Replace("@A", emp.CidCod);
            sql = sql.Replace("@B", emp.Fone);
            sql = sql.Replace("@cnpj", emp.Cnpj);
            bco.conecta();
            result = bco.executeNonQuery(sql);
            bco.desconecta();
            return result;
        }

        public Empresa getEmp()
        {
            Empresa emp = null;
            sql = "SELECT * FROM dados_empresa";
            DataTable dt = null;
            bco.conecta();
            bco.executeQuery(sql, out dt);
            bco.desconecta();
            if (dt.Rows.Count > 0)
            {
                emp = new Empresa();
                emp.Cnpj = dt.Rows[0]["cnpj"].ToString();
                emp.RazaoSocial = dt.Rows[0]["razaosocial"].ToString();
                emp.Nome = dt.Rows[0]["nomefantasia"].ToString();
                emp.Proprietario = dt.Rows[0]["proprietario"].ToString();
                emp.Site = dt.Rows[0]["site"].ToString();
                emp.Email = dt.Rows[0]["email"].ToString();
                emp.Rua = dt.Rows[0]["rua"].ToString();
                emp.Bairro = dt.Rows[0]["bairro"].ToString();
                emp.Numero = dt.Rows[0]["numero"].ToString();
                emp.Cep = dt.Rows[0]["cep"].ToString();
                emp.CidCod = dt.Rows[0]["cid_cod"].ToString();
                emp.Fone = dt.Rows[0]["fone"].ToString();
            }
            return emp;
        }
    }
}
