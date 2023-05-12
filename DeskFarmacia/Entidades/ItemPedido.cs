using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemPedido
    {
        public int items { get; set; }  
        public int idMedicamento { get; set; }  
        public string medicamento { get; set; } 
        public int cantidad { get; set; }   
        public decimal precio { get; set; } 

    }
}
