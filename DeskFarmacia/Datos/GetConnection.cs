using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections.Specialized;

namespace Datos
{
    public class GetConnection
    {
        public string getConnection()
        {

           if (ConfigurationManager.AppSettings.Get("ENTORNO") == "PRO")
           {
                return ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
           }
           else
           {
                return null;
           }

        }
    }
}
