using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoPedido
    {
        string conexion = new GetConnection().getConnection();
        public List<Stock> LoadGwProducto()
        {
            List<Stock> stock = new List<Stock>();

            string query = "select NOMBRE_MED,STOCK_MED,DESCRIP_FAM,NOMBRE_LAB,TEL_LAB,MAIL_LAB,PRECIO_LABXMED from MEDICAMENTOS JOIN MEDXFAMILIA ON CODMED_MEDXFAM = CODIGO_MED JOIN FAMILIAS ON CODFAM_MEDXFAM = CODIGO_FAM join LABXMED on CODIGO_MED = CODMED_LABXMED JOIN LABORATORIOS ON NOMBRE_LAB = NOMLAB_LABXMED";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Stock _stock = new Stock();

                        _stock.producto = reader.GetString(0);
                        _stock.stock = reader.GetInt32(1);
                        _stock.familia = reader.GetString(2);
                        _stock.laboratorio = reader.GetString(3);
                        _stock.telefono = reader.GetInt64(4);
                        _stock.mail = reader.GetString(5);
                        _stock.precio = reader.GetDecimal(6);

                        stock.Add(_stock);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }

            return stock;
        }

        public List<TablaPedido> getTablaPedido(string nombre)
        {
            List<TablaPedido> listaPedido = new List<TablaPedido>();

            string query = "select CODIGO_MED,NOMBRE_MED,DESCRIP_FAM,PRECIO_LABXMED from MEDICAMENTOS join MEDXFAMILIA on CODIGO_MED = CODMED_MEDXFAM join FAMILIAS on CODFAM_MEDXFAM = CODIGO_FAM join LABXMED on CODIGO_MED = CODMED_LABXMED join LABORATORIOS on NOMLAB_LABXMED = NOMBRE_LAB where NOMBRE_LAB = '" + nombre +"'";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        TablaPedido pedido = new TablaPedido();

                        pedido.idMedicamento= reader.GetInt32(0);
                        pedido.medicamento = reader.GetString(1);
                        pedido.familia = reader.GetString(2);
                        pedido.precio = reader.GetDecimal(3);

                        listaPedido.Add(pedido);
                    }
                    reader.Close();
                    connection.Close();

                    return listaPedido; 
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }

        public void cargarPedido(string lab)
        {

            string query = "insert into PEDIDOS(NOMLAB_PEDIDO,FECALT_PEDIDO,REC_PEDIDO,FECREC_PEDIDO) select @lab,GETDATE(),0,null";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@lab", lab);

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

        public int serchMaxIdPedido()
        {

            string query = "select MAX(ID_PEDIDO) from PEDIDOS";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                int max = 0;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        max = reader.GetInt32(0);
                    }
                    reader.Close();
                    connection.Close();

                    return max;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }

        public void addItems(Carrito pedido)
        {
            string query = "insert into ITEMPEDIDOS(IDPEDIDO_ITEMPED,IDITEMPED_ITEMPED,CODMED_ITEMPED,CANTID_ITEMPED,PRECIO_ITEMPED) select @idPed,@idItem,@codMed,@cant,@precio";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idPed", pedido.idPedido);
                command.Parameters.AddWithValue("@idItem", pedido.idItemPedido);
                command.Parameters.AddWithValue("@codMed", pedido.idMedicamento);
                command.Parameters.AddWithValue("@cant", pedido.cantidad);
                command.Parameters.AddWithValue("@precio", pedido.total);

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

        public List<Pedido> cargarCarrito()
        {
            string query = "select * from PEDIDOS";

            List<Pedido> ListItemPedido = new List<Pedido>(); 

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Pedido item = new Pedido();
                        item.IdPedido = reader.GetInt32(0);
                        item.nombreLab = reader.GetString(1);
                        item.fechaAlt = reader.GetDateTime(2);
                        item.recPedido = reader.GetBoolean(3);
                        
                        ListItemPedido.Add(item);
                    }
                    reader.Close();
                    connection.Close();

                    return ListItemPedido;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }

        public void confirmacionPedido(int id)
        {
            List<ItemPedido> listItem = new List<ItemPedido>();
            DaoMedicamento med = new DaoMedicamento();

            DaoItemPedido items = new DaoItemPedido();
            listItem = items.getPedido(id);

            foreach(ItemPedido item in listItem)
            {
                med.insertStock(item.idMedicamento,item.cantidad);
            }

            string query = "update PEDIDOS set REC_PEDIDO = 1, FECREC_PEDIDO = GETDATE() where ID_PEDIDO =" + id;

            using (SqlConnection connection = new SqlConnection(conexion))
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
    }
}
