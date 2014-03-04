using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Modalidade
    {
        String id, desc, valorM, valorD;
        ModalidadeBD modBD;

        public Modalidade()
        {
            modBD = new ModalidadeBD();
            id = desc = valorM = valorD = "";
        }

        public String ValorD
        {
            get { return valorD; }
            set { valorD = value; }
        }

        public String ValorM
        {
            get { return valorM; }
            set { valorM = value; }
        }

        public String Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool nova()
        {
            return modBD.nova(this);
        }

        public bool altera()
        {
            return modBD.altera(this);
        }

        public bool exclui()
        {
            return modBD.exclui(id);
        }

        public String getTotal()
        {
            return modBD.getTotal();
        }

        public DataTable getModalidades()
        {
            return modBD.getModalidades(desc);
        }

        public Modalidade getById()
        {
            return modBD.getById(id);
        }
    }
}
