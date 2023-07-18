using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.DMN;
using DeskFarmacia.DAL;
using System.Data;
using System.Reflection.Metadata;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.CMN;

namespace DeskFarmacia.BLL
{
    public class PedidoApp
    {
        DatosPedido pedidoDAL = new DatosPedido();

        public List<string> LoadComboLab()
        {
            return Querys.GetCbNamesLab();
        }

        public List<TablaPedido> GetTablaPedido(string nombreLab)
        {
           List<TablaPedido> tablaPedido = pedidoDAL.GetTablaPedidos(nombreLab);
            return tablaPedido;
        }

        public void NewPedido(Pedido pedido)
        {
            pedidoDAL.SetNewPedido(pedido);
        }

        public int SerchMaxPedido()
        {
           return pedidoDAL.getMaxPedido();
        }

        public void AddItemPedido(ItemPedido itemPedido)
        {
            pedidoDAL.AddItemsNewPedido(itemPedido);
        }

        public List<Medicamento> LoadGwProductos()
        {
            return pedidoDAL.getLoadGwProductos();
        }

        public List<PedidosConfirmar> LoadGwPedidosConfir()
        {
            return pedidoDAL.getLoadGwProductosConfir();
        }

        public int CalcularTotal(int id)
        {
            return pedidoDAL.getCalcularTotalPedido(id);
        }

        public List<ItemsPedidosConfirmar> AllItemPedido(int id)
        {
            return pedidoDAL.GetAllItemPedido(id);
        }

        public void ConfirmarPedido(int idPedido)
        {
            pedidoDAL.SetConfirmPedido(idPedido);
        }

        public List<int> AllIdPedido()
        {
            return pedidoDAL.getLoadGwProductosConfir().Select(x => x.ID_PEDIDO).ToList();
        }
    }
}
