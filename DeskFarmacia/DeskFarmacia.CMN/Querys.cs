using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.CMN
{
    public static class Querys
    {
        public static List<string> GetCbNamesLab()
        {
            string query = "select NOMBRE_LAB from LABORATORIOS";

            List<string> labs = Repository.ExecuteStringListQuery(query);

            labs.Sort();
            labs.Insert(0, "--Seleccionar--");

            return labs;
        }
    }
}
