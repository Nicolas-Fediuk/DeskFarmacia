using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeskFarmacia.CMN
{
    public static class Repository
    {
        private static string connectionString =  GetConnection.getConnection();

        //Retorna una lista de objetos 
        public static List<T> ExecuteQuery<T>(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return ProcessResults<T>(reader);
                    }
                }
            }
        }

        //Retorno un dato en particular
        public static T ExecuteOneDataQuery<T>(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (T)Convert.ChangeType(result, typeof(T));
                    }
                    else
                    {
                        return default(T);
                    }
                }
            }
        }


        private static List<T> ProcessResults<T>(SqlDataReader reader)
        {
            List<T> results = new List<T>();

            while (reader.Read())
            {
                T entity = Activator.CreateInstance<T>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object value = reader.GetValue(i);

                    var property = typeof(T).GetProperty(columnName);
                    if (property != null && value != DBNull.Value)
                    {
                        property.SetValue(entity, value);
                    }
                }

                results.Add(entity);
            }

            return results;
        }

        //retorna una lsita de string
        public static List<string> ExecuteStringListQuery(string sqlQuery)
        {
            string columnName = GetSelectColumn(sqlQuery);

            List<string> resultList = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(reader.GetOrdinal(columnName));
                            resultList.Add(value);
                        }
                    }
                }
            }

            return resultList;
        }

        private static string GetSelectColumn(string sqlQuery)
        {
            string pattern = @"SELECT\s+(.*?)\s+FROM";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            Match match = regex.Match(sqlQuery);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }

            return string.Empty;
        }

        //Retorna de un registro de un objeto 
        public static T ExecuteObjectQuery<T>(string query, Func<SqlDataReader, T> mapToObject)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return mapToObject(reader);
                        }
                    }
                }
            }

            return default(T);
        }
        
        //retorna una lista de int
        public static List<int> ExecuteIntListQuery(string sqlQuery)
        {
            string columnName = GetSelectColumn(sqlQuery);

            List<int> resultList = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int value = reader.GetInt32(reader.GetOrdinal(columnName));
                            resultList.Add(value);
                        }
                    }
                }
            }

            return resultList;
        }
    }
}

