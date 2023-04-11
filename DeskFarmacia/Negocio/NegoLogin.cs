using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NegoLogin
    {
        DaoLogin dao = new DaoLogin();
        public bool validarLogin(Login log)
        {
            if(!string.IsNullOrEmpty(log.name) && !string.IsNullOrEmpty(log.pass))
            {
                if (dao.verificarLogin(log))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
