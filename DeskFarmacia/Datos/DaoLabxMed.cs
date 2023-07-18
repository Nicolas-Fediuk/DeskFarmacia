using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoLabxMed
    {
        string conexion = new GetConnection().getConnection();
        public void setDatos(LabxMed lm)
        {
            string query = "insert into LABXMED(NOMLAB_LABXMED,CODMED_LABXMED,PRECIO_LABXMED) select @nombre,@codMed,@precio";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", lm.nombreLab);
                command.Parameters.AddWithValue("@codMed", lm.codMed);
                command.Parameters.AddWithValue("@precio", lm.precio);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la base de datos: " + ex.Message);
                }
            }
        }
    }
}
