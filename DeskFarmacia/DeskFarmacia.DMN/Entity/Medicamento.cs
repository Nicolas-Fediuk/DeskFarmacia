using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.DMN.Entity
{
    public class Medicamento
    {
        public int CODIGO_MED { get; set; } 
        public string NOMBRE_MED { get; set; }
        public string DESCRIP_MED { get; set; } 
        public int STOCK_MED { get; set; }  
        public bool RECETA_MED { get; set; }    
    }
}
