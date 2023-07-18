using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.CMN
{
    public static class GetConnection
    {
        public static string getConnection()
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
