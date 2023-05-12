using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegoItemPedido
    {
        DaoItemPedido _itemPedido = new DaoItemPedido();
        public List<ItemPedido> GetAllPedido(int id)
        {
               
            return _itemPedido.getPedido(id);
        }

        public List<int> getCantidad(int id)
        {
            return _itemPedido.getPedido(id).Select(x => x.cantidad).ToList();
        }

        public decimal calcularTotal(int id)
        {
            return _itemPedido.getTotal(id);
        }
    }
}
