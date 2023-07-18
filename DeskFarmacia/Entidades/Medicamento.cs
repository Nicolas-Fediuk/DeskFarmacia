using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Medicamento
    {
        public int idMedicamento { get; set; }  
        public string medicamento { get; set; }
        public string descripcion { get; set;}
        public int stock { get; set; }  
        public bool receta { get; set; }    
    }
}
