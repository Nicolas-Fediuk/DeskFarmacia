using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Reflection.Metadata;

namespace Negocio
{
    public class NegoPedido
    {
        DaoPedido _daoStock = new DaoPedido();
        DaoLaboratorio _daoLab = new DaoLaboratorio();
        public List<Stock> loadGwProductos()
        {
            return _daoStock.LoadGwProducto();
        }

        public List<string> LoadComboLab()
        {
            return _daoLab.getNombreLaboratorios();
        }

        public List<TablaPedido> getTablaPedido(string nombreLab)
        {
            return _daoStock.getTablaPedido(nombreLab);
        }

        public void newPedido(string lab)
        {
            _daoStock.cargarPedido(lab);
        }

        public int serchMaxPedido()
        {
            return _daoStock.serchMaxIdPedido();
        }

        public void addItem(Carrito pedido)
        {
            _daoStock.addItems(pedido);
        }

        public List<Pedido> loadCarrito()
        {
            return _daoStock.cargarCarrito().Where(x => x.recPedido != true).ToList();
        }
        public List<int?> getAllIdPedido()
        {
            var idPedidos = (from id in _daoStock.cargarCarrito()
                             where id.recPedido != true
                            select id.IdPedido).ToList();   

            return idPedidos;
        }

        public void confirmarPedido(int id)
        {
            _daoStock.confirmacionPedido(id);
        }
    }
}
