using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.DAL;
using DeskFarmacia.DMN.Entity;

namespace DeskFarmacia.BLL
{
    public class LoginApp
    {
        DatosLogin loginDal = new DatosLogin();
        public bool VerificarLogin(Login login) 
        {
            List<Login> logins = loginDal.VerificarLogin(login);

            return (logins.Count > 0) ? true :  false;  
        }
    }
}
