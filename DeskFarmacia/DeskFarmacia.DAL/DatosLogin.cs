using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.CMN;
using DeskFarmacia.CMN.DataSession;
using DeskFarmacia.DMN.Entity;

namespace DeskFarmacia.DAL
{
    public class DatosLogin
    {
        public List<Login> VerificarLogin(Login login)
        {
            string query = "select * from LOGIN where CORREO_LOG = '"+login.CORREO_LOG+"' and PASSWORD_LOG = '"+login.PASSWORD_LOG+"'";

            List<Login> logins = Repository.ExecuteQuery<Login>(query);

            if(logins.Count > 0 )
            {
                string querySession = "select DNI_USU from USUARIOS join LOGIN on CORREO_USU = CORREO_LOG where CORREO_USU = '"+login.CORREO_LOG+"'";

                string dni = Repository.ExecuteOneDataQuery<string>(querySession);

                Session.dniUser = dni;
                Session.user = Environment.UserName;
                Session.machine = Environment.MachineName;  
            }

            return logins;
        }
    }
}
