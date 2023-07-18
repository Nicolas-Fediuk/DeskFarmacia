using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeskFarmacia.DAL;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.CMN;
using System.Text.RegularExpressions;
using DeskFarmacia.DMN;

namespace DeskFarmacia.BLL
{
    public class LaboratorioApp
    {
        DatosLaboratorio laboratorioDAL = new DatosLaboratorio();
       
        public List<Medicamento> LoadGwMedxLab()
        {
            return laboratorioDAL.GetGwMedxLab();
        }

        public List<string> LoadComboLab()
        {
            return Querys.GetCbNamesLab();
        }

        public bool ValidarMail(string mail)
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

        public void LoadNewLab(Laboratorio laboratorio)
        {
            laboratorioDAL.NewLab(laboratorio);
        }

        public List<Medicamento> LoadGwMedxLab(string search)
        {
            return laboratorioDAL.GetGwMedxLab().Where(x => x.NOMBRE_MED.Contains(search)).ToList();
        }

        public void InsertLabxMed(LabxMed lm)
        {
            laboratorioDAL.SetLabxMed(lm);
        }

        public Laboratorio DataLaboratorio(string nameLab)
        {
            return laboratorioDAL.GetDataLab(nameLab);
        }

        public bool EditLaboratorio(Laboratorio laboratorio)
        {
           return laboratorioDAL.UpdateDateLab(laboratorio);
        }

        //public List<TablaPrecioxLab> GetGwPrecioxLab()
        //{
        //    return laboratorioDAL.GetPrecioxLab();
        //}

        public List<TablaPrecioxLab> GetGwPrecioxLabWithFilterLab(string serchLab)
        {
            return laboratorioDAL.GetPrecioxLab().Where(x => x.NOMLAB_LABXMED.Contains(serchLab)).ToList();
        }

        public List<TablaPrecioxLab> GetGwPrecioxLabWithFilterMed(string serchMed)
        {
            return laboratorioDAL.GetPrecioxLab().Where(x => x.NOMBRE_MED.Contains(serchMed)).ToList();
        }

        public List<TablaPrecioxLab> GetGwPrecioxLabWithFilter(string serchLab, string serchMed)
        {
            return laboratorioDAL.GetPrecioxLab().Where(x => x.NOMBRE_MED.Contains(serchMed) && x.NOMLAB_LABXMED.Contains(serchLab)).ToList();
        }

        public void UpdatePrecioMedxLab(TablaPrecioxLab precioMedxLab)
        {
            laboratorioDAL.UpdatePrecioMed(precioMedxLab);
        }

        public List<Laboratorio> GetAllLab()
        {
            return laboratorioDAL.GetLabs();
        }

        public void DeleteLab(string nameLab)
        {
            laboratorioDAL.DeleteLab(nameLab);
        }
    }
}
