using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TablaPedido
    {
        public int idMedicamento { get; set; }
        public string medicamento { get; set; }
        public string familia { get; set; }
        public decimal precio { get; set; }
        public int Cantidad { get; set; }   
    }
}
