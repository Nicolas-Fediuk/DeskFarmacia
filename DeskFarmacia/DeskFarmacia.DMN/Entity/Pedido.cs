using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.DMN.Entity
{
    public class Pedido
    {
        public int ID_PEDIDO { get; set; }
        public string? NOMLAB_PEDIDO { get; set; }
        public DateTime FECALT_PEDIDO { get; set; }
        public bool REC_PEDIDO { get; set; }
        public DateTime? FECREC_PEDIDO { get; set; }
        public string DNIUSU_PEDIDO { get; set; }
        public string USUARIO_PEDIDO { get; set; }
        public string MAQUINAUSU_PEDIDO { get; set; }

    }

    public class ItemPedido
    {
        public int IDPEDIDO_ITEMPED { get; set; }
        public int IDITEMPED_ITEMPED { get; set; }
        public int CODMED_ITEMPED { get; set; }
        public int CANTID_ITEMPED { get; set; }
        public decimal PRECIO_ITEMPED { get; set; }
    }
}
