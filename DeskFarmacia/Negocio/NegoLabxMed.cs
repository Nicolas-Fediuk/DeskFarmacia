using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegoLabxMed
    {
        DaoLabxMed DaoLXM = new DaoLabxMed();
        public void insertDato(LabxMed lm)
        {
            DaoLXM.setDatos(lm);
        }
    }
}
