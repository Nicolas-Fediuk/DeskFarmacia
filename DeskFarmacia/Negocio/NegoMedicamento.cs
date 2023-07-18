using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegoMedicamento
    {
        DaoMedicamento daoMedicamento= new DaoMedicamento();
        public List<Medicamento> loadGwMedxLab()
        {
            return daoMedicamento.getLoadGwLabxMed();
        }

        public List<Medicamento> loadGwMedxLab(string search)
        {
            return daoMedicamento.getLoadGwLabxMed().Where(x => x.medicamento.Contains(search)).ToList();
        }
    }
}
