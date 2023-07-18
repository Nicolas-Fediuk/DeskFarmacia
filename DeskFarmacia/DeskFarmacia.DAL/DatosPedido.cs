using DeskFarmacia.CMN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.CMN;
using DeskFarmacia.DMN;
using System.Data;
using System.Data.SqlClient;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.CMN.DataSession;

namespace DeskFarmacia.DAL
{
    public class DatosPedido
    {
        private static string conecction = GetConnection.getConnection();

        public List<TablaPedido> GetTablaPedidos(string nombreLab)
        {
            string query = "SELECT CODIGO_MED, NOMBRE_MED, DESCRIP_FAM, PRECIO_LABXMED FROM MEDICAMENTOS JOIN MEDXFAMILIA ON CODIGO_MED = CODMED_MEDXFAM JOIN FAMILIAS ON CODFAM_MEDXFAM = CODIGO_FAM JOIN LABXMED ON CODIGO_MED = CODMED_LABXMED JOIN LABORATORIOS ON NOMLAB_LABXMED = NOMBRE_LAB WHERE NOMBRE_LAB = '" + nombreLab+"'";

            List<TablaPedido> tablaLista =  Repository.ExecuteQuery<TablaPedido>(query);

            return tablaLista;
        }

        public void SetNewPedido(Pedido pedido)
        {
            string query = "insert into PEDIDOS(NOMLAB_PEDIDO,FECALT_PEDIDO,REC_PEDIDO,FECREC_PEDIDO,DNIUSU_PEDIDO,USUARIO_PEDIDO,MAQINAUSU_PEDIDO) select @NOMLAB_PEDIDO,GETDATE(),0,null,@DNIUSU_PEDIDO,@USUARIO_PEDIDO,@MAQUINAUSU_PEDIDO";

            using (SqlConnection connection = new SqlConnection(conecction))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NOMLAB_PEDIDO", pedido.NOMLAB_PEDIDO);
                command.Parameters.AddWithValue("@DNIUSU_PEDIDO", pedido.DNIUSU_PEDIDO);
                command.Parameters.AddWithValue("@USUARIO_PEDIDO", pedido.USUARIO_PEDIDO);
                command.Parameters.AddWithValue("@MAQUINAUSU_PEDIDO", pedido.MAQUINAUSU_PEDIDO);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }

        public int getMaxPedido()
        {
            string query = "select max(ID_PEDIDO) from PEDIDOS";

            int idMax = Repository.ExecuteOneDataQuery<int>(query); 

            return idMax;   
        }

        public void AddItemsNewPedido(ItemPedido itemPedido)
        {
            string query = "insert into ITEMPEDIDOS(IDPEDIDO_ITEMPED,IDITEMPED_ITEMPED,CODMED_ITEMPED,CANTID_ITEMPED,PRECIO_ITEMPED) select @idPedido, @idItemPedido, @codMed, @cantidad, @precio";

            using (SqlConnection connection = new SqlConnection(conecction))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPedido", itemPedido.IDPEDIDO_ITEMPED);
                command.Parameters.AddWithValue("@idItemPedido", itemPedido.IDITEMPED_ITEMPED);
                command.Parameters.AddWithValue("@codMed", itemPedido.CODMED_ITEMPED);
                command.Parameters.AddWithValue("@cantidad", itemPedido.CANTID_ITEMPED);
                command.Parameters.AddWithValue("@precio", itemPedido.PRECIO_ITEMPED);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }

        public List<Medicamento> getLoadGwProductos()
        {
            string query = "select NOMBRE_MED,sum(STOCK_MED) as STOCK_MED from MEDICAMENTOS group by NOMBRE_MED,STOCK_MED";

            List<Medicamento> tablaLista = Repository.ExecuteQuery<Medicamento>(query);

            return tablaLista;
        }

        public List<PedidosConfirmar> getLoadGwProductosConfir()
        {
            string query = "select ID_PEDIDO, NOMLAB_PEDIDO, FECALT_PEDIDO, NOMBRE_USU + ' ' + APELLIDO_USU as NOMBREUSUARIO, USUARIO_PEDIDO from PEDIDOS join USUARIOS on DNIUSU_PEDIDO = DNI_USU where REC_PEDIDO = 0";

            List<PedidosConfirmar> tablaGwPedido = Repository.ExecuteQuery<PedidosConfirmar>(query);    

            return tablaGwPedido;
        }

        public int getCalcularTotalPedido(int id)
        {
            string query = "select sum(PRECIO_ITEMPED) from ITEMPEDIDOS where IDPEDIDO_ITEMPED = " + id;

            int total = Repository.ExecuteOneDataQuery<int>(query); 

            return total;
        }

        public List<ItemsPedidosConfirmar> GetAllItemPedido(int id)
        {
            string query = "select IDITEMPED_ITEMPED,CODMED_ITEMPED, CODIGO_MED, NOMBRE_MED,CANTID_ITEMPED,PRECIO_ITEMPED from ITEMPEDIDOS join MEDICAMENTOS on CODMED_ITEMPED = CODIGO_MED where IDPEDIDO_ITEMPED = " + id;

            List<ItemsPedidosConfirmar> tablaGwItemsPedidos = Repository.ExecuteQuery<ItemsPedidosConfirmar>(query);

            return tablaGwItemsPedidos; 
        }

        public void SetConfirmPedido(int idPedido)
        {
            List<ItemsPedidosConfirmar> ListItem = new List<ItemsPedidosConfirmar>();

            ListItem = GetAllItemPedido(idPedido);

            foreach(ItemsPedidosConfirmar item in ListItem)
            {
                InsertStock(item.CODIGO_MED, item.CANTID_ITEMPED);
            }

            string query = "update PEDIDOS set REC_PEDIDO = 1, FECREC_PEDIDO = GETDATE(), DNIUSRPEDREC_PEDIDO = '"+Session.dniUser+"' where ID_PEDIDO =" + idPedido;

            using (SqlConnection connection = new SqlConnection(conecction))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        private void InsertStock(int CODIGO_MED, int CANTID_ITEMPED)
        {
            int cantBefore = GetCantidad(CODIGO_MED);
            int totalCant = cantBefore + CANTID_ITEMPED;

            string query = "update MEDICAMENTOS set STOCK_MED = @CANT where CODIGO_MED = " + CODIGO_MED;

            using (SqlConnection connection = new SqlConnection(conecction))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CANT", totalCant);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("hay un error en la BD: " + ex.Message);
                }
            }
        }

        private int GetCantidad(int CODIGO_MED)
        {
            string query = "select STOCK_MED from MEDICAMENTOS where CODIGO_MED = " + CODIGO_MED;

            int cantidad = Repository.ExecuteOneDataQuery<int>(query);

            return cantidad;
        }
    }
}
