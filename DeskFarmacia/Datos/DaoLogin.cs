using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoLogin
    {
        string co = new GetConnection().getConnection();

        public bool verificarLogin(Login login) {

            string query = "select * from PASS where USR_SEC = '" + login.name + "'" + "and PASS_SEC = '" + login.pass + "'";
            
            try {
                using (SqlConnection connection = new SqlConnection(Convert.ToString(co)))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (login.name == reader.GetString(0) && login.pass == reader.GetString(1))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}
