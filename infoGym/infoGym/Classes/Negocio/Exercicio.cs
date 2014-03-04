using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using infoGym.Classes.BD;
using System.Data;

namespace infoGym.Classes.Negocio
{
    class Exercicio
    {
        ExercicioBD exeBD;
        String id, desc, area;


        public Exercicio()
        {
            exeBD = new ExercicioBD();
            id = desc = area = "";
        }

        public String Area
        {
            get { return area; }
            set { area = value; }
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

        public bool novo()
        {
            return exeBD.novo(this);
        }

        public bool altera()
        {
            return exeBD.altera(this);
        }

        public bool exclui()
        {
            return exeBD.exclui(id);
        }

        public String getTotal()
        {
            return exeBD.getTotal();
        }

        public Exercicio getById()
        {
            return exeBD.getById(id);
        }

        public DataTable getExercicios()
        {
            return exeBD.getExercicios(desc);
        }

    }

}
