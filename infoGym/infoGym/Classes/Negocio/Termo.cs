using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Termo
    {
        String terId, terQuemCadastrou, aluId;
        TermoBD terBD;
        public Termo()
        {
            terId = terQuemCadastrou = "";
            terBD = new TermoBD();
            aluId = "";
        }

        public String TerQuemCadastrou
        {
            get { return terQuemCadastrou; }
            set { terQuemCadastrou = value; }
        }

        public String TerId
        {
            get { return terId; }
            set { terId = value; }
        }

        public String AluId
        {
            get { return aluId; }
            set { aluId = value; }
        }

        public bool novo()
        {
            return terBD.novo(this);
        }

        public bool atualiza()
        {
            return terBD.atualiza(this);
        }

        public bool excluir()
        {
            return terBD.excluir(this);
        }

        public String getUltimoId()
        {
            return terBD.getUltimoId();
        }

        public DataTable getTermos(String aluNome)
        {
            return terBD.getTermos(aluNome);
        }

        public Termo getTermoById()
        {
            return terBD.getTermoById(TerId);
        }
    }
}
