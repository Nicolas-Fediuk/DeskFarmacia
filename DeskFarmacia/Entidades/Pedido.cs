using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int? IdPedido { get; set; }
        public string? nombreLab { get; set; }
        public DateTime fechaAlt { get; set; }
        public bool recPedido { get; set; }
        public string? FecRec { get; set; }
        public decimal total { get; set; } 
    }
}
