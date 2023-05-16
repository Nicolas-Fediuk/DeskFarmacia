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
                    throw new Exception("Hay un error en la base de datos: " + ex.Message);
                }
            }
        }

        public void loadLab(Laboratorio lab)
        {
            string query = "insert into LABORATORIOS(NOMBRE_LAB,TEL_LAB,MAIL_LAB,DIRECCION_LAB) select @nombre,@tel,@mail,@direc";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", lab.nombre);
                command.Parameters.AddWithValue("@tel", lab.telefono.ToString());
                command.Parameters.AddWithValue("@mail", lab.mail);
                command.Parameters.AddWithValue("@direc", lab.direccion);

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
