using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.DMN
{
    public class PedidosConfirmar
    {
        public int ID_PEDIDO { get; set; }    
        public string NOMLAB_PEDIDO { get; set; }   
        public DateTime FECALT_PEDIDO { get; set; }
        public string NOMBREUSUARIO { get; set; }   
        public string USUARIO_PEDIDO { get; set; }    
    }
}
