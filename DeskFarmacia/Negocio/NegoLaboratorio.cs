using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegoLaboratorio
    {
        DaoLaboratorio _lab = new DaoLaboratorio();

        public void loadNewLab(Laboratorio lab)
        {
            _lab.loadLab(lab);
        }
        public bool validarMail(string mail)
        {
            string emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(mail, emailFormato))
            {
                if (Regex.Replace(mail, emailFormato, String.Empty).Length == 0)
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
