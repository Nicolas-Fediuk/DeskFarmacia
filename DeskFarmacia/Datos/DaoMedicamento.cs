using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoMedicamento
    {
        string conexion = new GetConnection().getConnection();
        public void insertStock(int codMed,int cantidad)
        {
            int cantBefore = getCantidad(codMed);
            int totalCant = cantBefore + cantidad;

            string query = "update MEDICAMENTOS set STOCK_MED = @CANT where CODIGO_MED = " + codMed;

            using (SqlConnection connection = new SqlConnection(conexion))
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
        public int getCantidad(int codMed)
        {
            string query = "select STOCK_MED from MEDICAMENTOS where CODIGO_MED = " + codMed;

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
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
