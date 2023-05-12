using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Datos
{
    public class DaoLaboratorio
    {
        string conexion = new GetConnection().getConnection();
        public List<string> getNombreLaboratorios()
        {
            List<string> listLab = new List<string>();

            string query = "Select NOMBRE_LAB from Laboratorios";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        listLab.Add(reader.GetString(0));
                    }
                    reader.Close();
                    connection.Close();

                    listLab.Sort();
                    listLab.Insert(0, "--Seleccionar--");

                    return listLab;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error al cargar el GridView: " + ex.Message);
                }
            }
        }
    }
    
}
