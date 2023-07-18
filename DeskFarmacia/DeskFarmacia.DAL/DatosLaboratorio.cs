using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.CMN;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using DeskFarmacia.DMN;

namespace DeskFarmacia.DAL
{
    public class DatosLaboratorio
    {
        private static string connectionString = GetConnection.getConnection();
        public List<Medicamento> GetGwMedxLab()
        {
            string query = "select CODIGO_MED,NOMBRE_MED from MEDICAMENTOS";

            List<Medicamento> listMed = Repository.ExecuteQuery<Medicamento>(query);    

            return listMed; 
        }

        public void NewLab(Laboratorio lab)
        {
            string query = "insert into LABORATORIOS(NOMBRE_LAB,TEL_LAB,MAIL_LAB,DIRECCION_LAB) select @nombre,@tel,@mail,@direc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", lab.NOMBRE_LAB);
                command.Parameters.AddWithValue("@tel", lab.TEL_LAB.ToString());
                command.Parameters.AddWithValue("@mail", lab.MAIL_LAB);
                command.Parameters.AddWithValue("@direc", lab.DIRECCION_LAB);

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

        public void SetLabxMed(LabxMed lm)
        {
            string query = "insert into LABXMED(NOMLAB_LABXMED,CODMED_LABXMED,PRECIO_LABXMED) select @nombre,@codMed,@precio";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", lm.nombreLab);
                command.Parameters.AddWithValue("@codMed", lm.CodMedicamento);
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

        public Laboratorio GetDataLab(string nameLab)
        {
            string query = "select NOMBRE_LAB, TEL_LAB, MAIL_LAB, DIRECCION_LAB from LABORATORIOS where NOMBRE_LAB = '"+nameLab+"'";

            Laboratorio lab = Repository.ExecuteObjectQuery(query,reader =>
            {
                return new Laboratorio
                {
                    NOMBRE_LAB = reader["NOMBRE_LAB"].ToString(),
                    TEL_LAB = reader["TEL_LAB"].ToString(),
                    MAIL_LAB = reader["MAIL_LAB"].ToString(),
                    DIRECCION_LAB = reader["DIRECCION_LAB"].ToString()
                };
            });

            return lab;
        }

        public bool UpdateDateLab(Laboratorio laboratorio)
        {

            bool okName = CheckMail(laboratorio);

            if(okName)
            {
                string query = "update LABORATORIOS set NOMBRE_LAB = @nombre,TEL_LAB = @tel,MAIL_LAB = @mail,DIRECCION_LAB = @direc where NOMBRE_LAB = '" + laboratorio.NOMBRE_LAB + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", laboratorio.NOMBRE_LAB);
                    command.Parameters.AddWithValue("@tel", laboratorio.TEL_LAB.ToString());
                    command.Parameters.AddWithValue("@mail", laboratorio.MAIL_LAB);
                    command.Parameters.AddWithValue("@direc", laboratorio.DIRECCION_LAB);

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

                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckMail(Laboratorio laboratorio)
        {
            string query = "select count(*) from LABORATORIOS where NOMBRE_LAB <> '"+laboratorio.NOMBRE_LAB+ "' and MAIL_LAB = '"+laboratorio.MAIL_LAB+"'";

            int cant = Repository.ExecuteOneDataQuery<int>(query);

            return (cant == 0) ?  true :  false;

        }

        public List<TablaPrecioxLab> GetPrecioxLab()
        {
            string query = "select CODIGO_MED, NOMBRE_MED, NOMLAB_LABXMED, PRECIO_LABXMED from LABXMED join MEDICAMENTOS on CODMED_LABXMED = CODIGO_MED";

            List<TablaPrecioxLab> list = Repository.ExecuteQuery<TablaPrecioxLab>(query);   

            return list;    
        }

        public void UpdatePrecioMed(TablaPrecioxLab precioMedxLab)
        {
            string query = "update LABXMED set PRECIO_LABXMED = "+precioMedxLab.PRECIO_LABXMED+" where CODMED_LABXMED = '"+precioMedxLab.CODIGO_MED+"' and NOMLAB_LABXMED = '"+precioMedxLab.NOMLAB_LABXMED+"'";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                    throw new Exception("Hay un error en la base de datos: " + ex.Message);
                }
            }
        }

        public List<Laboratorio> GetLabs()
        {
            string query = "select NOMBRE_LAB, TEL_LAB, MAIL_LAB, DIRECCION_LAB from LABORATORIOS";

            List<Laboratorio> listLab = Repository.ExecuteQuery<Laboratorio>(query);

            return listLab;
        }

        public void DeleteLab(string nameLab)
        {
            DeletePedidosLab(nameLab);

            DeleteLabxMed(nameLab);

            string query = "delete LABORATORIOS where NOMBRE_LAB = '"+nameLab+"'";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                    throw new Exception("Hay un error en la base de datos: " + ex.Message);
                }
            }
        }

        private void DeletePedidosLab(string nameLab)
        {
            string query = "select ID_PEDIDO from PEDIDOS where NOMLAB_PEDIDO = '"+nameLab+"'";

            List<int> listIdPedido = Repository.ExecuteIntListQuery(query);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //Elimina los items 
                foreach (int pedido in listIdPedido)
                {
                    string queryItem = "delete ITEMPEDIDOS where IDPEDIDO_ITEMPED = " + pedido;

                    SqlCommand command = new SqlCommand(queryItem, connection);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Hay un error en la base de datos: " + ex.Message);
                    }
                }

                //Elimina los pedidos
                foreach (int pedido in listIdPedido)
                {
                    string queryPedido = "delete PEDIDOS where ID_PEDIDO = " + pedido;

                    SqlCommand command = new SqlCommand(queryPedido, connection);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Hay un error en la base de datos: " + ex.Message);
                    }
                    
                }

                connection.Close();
            }
        }

        private void DeleteLabxMed(string nameLab)
        {
            //elimina los medicamentos para este laboratorio
            string query = "delete LABXMED where NOMLAB_LABXMED = '"+nameLab+"'";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
                    throw new Exception("Hay un error en la base de datos: " + ex.Message);
                }
            }
        }
    }
}
