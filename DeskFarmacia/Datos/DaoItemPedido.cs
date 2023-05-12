using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class DaoItemPedido
    {
        string conexion = new GetConnection().getConnection();
        public List<ItemPedido> getPedido(int id)
        {
            List<ItemPedido> listItem = new List<ItemPedido>();

            string query = "select IDITEMPED_ITEMPED,CODMED_ITEMPED,NOMBRE_MED,CANTID_ITEMPED,PRECIO_ITEMPED from ITEMPEDIDOS join MEDICAMENTOS on CODMED_ITEMPED = CODIGO_MED where IDPEDIDO_ITEMPED = "+id;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ItemPedido item = new ItemPedido();
                        item.items = reader.GetInt32(0);
                        item.idMedicamento= reader.GetInt32(1);
                        item.medicamento = reader.GetString(2);
                        item.cantidad = reader.GetInt32(3);
                        item.precio = reader.GetDecimal(4);

                        listItem.Add(item); 
                    }
                    reader.Close();
                    connection.Close();

                    return listItem;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error: " + ex.Message);
                }
            }
            
        }

        public decimal getTotal(int id)
        {
            string query = "select sum(PRECIO_ITEMPED) from ITEMPEDIDOS where IDPEDIDO_ITEMPED = " + id;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return reader.GetDecimal(0);
                    }
                    reader.Close();
                    connection.Close();
                    return 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }
    }
}
