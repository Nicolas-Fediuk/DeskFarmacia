using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrito
    {
        public int idPedido { get; set; }
        public int idItemPedido { get; set; }   
        public int idMedicamento { get; set; }
        public int cantidad { get; set; }   
        public decimal total { get; set; }  
    }
}
