using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.CMN.DataSession
{
    public static class Session
    {
        public static string dniUser { get; set; }
        public static string user { get; set;}
        public static string machine { get; set;}

        public static void ResetSession()
        {
            dniUser = string.Empty;
            user = string.Empty;    
            machine = string.Empty; 
        }


    }
}
