using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeskFarmacia.BLL;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.UI.ConfigControl;
using DeskFarmacia.UI.MessengerBox;
using Krypton.Toolkit;

namespace DeskFarmacia.UI.View.Laboratorio
{
    public partial class frmDeleteLaboratorio : KryptonForm
    {
        GridConfig gv = new GridConfig();

        DeskFarmacia.DMN.Entity.Laboratorio laboratorio = new DMN.Entity.Laboratorio();
        LaboratorioApp laboratorioApp = new LaboratorioApp();

        private KryptonDataGridViewTextBoxColumn colNombre;
        private KryptonDataGridViewTextBoxColumn colTelefono;
        private KryptonDataGridViewTextBoxColumn colMail;
        private KryptonDataGridViewTextBoxColumn colDireccion;
        private KryptonDataGridViewButtonColumn colBtn;
        public frmDeleteLaboratorio()
        {
            InitializeComponent();

            MakeGw();
            LoadGv();
        }

        private void MakeGw()
        {
            gvDeleteLab.AutoGenerateColumns = false;

            colNombre = new KryptonDataGridViewTextBoxColumn();
            colNombre.HeaderText = "Nombre";
            colNombre.DataPropertyName = "NOMBRE_LAB";
            colNombre.ReadOnly = true;

            colTelefono= new KryptonDataGridViewTextBoxColumn();
            colTelefono.HeaderText = "Telefono";
            colTelefono.DataPropertyName = "TEL_LAB";
            colTelefono.ReadOnly = true;    

            colMail=new KryptonDataGridViewTextBoxColumn();
            colMail.HeaderText = "Mail";
            colMail.DataPropertyName = "MAIL_LAB";
            colMail.ReadOnly = true;    

            colDireccion = new KryptonDataGridViewTextBoxColumn();
            colDireccion.HeaderText = "Direcccion";
            colDireccion.DataPropertyName = "DIRECCION_LAB";
            colDireccion.ReadOnly = true;

            colBtn = new KryptonDataGridViewButtonColumn();
            colBtn.DataPropertyName = "btnEliminar";
            colBtn.HeaderText = "Eliminar";
            colBtn.Text = "Eliminar";
            colBtn.UseColumnTextForButtonValue = true;

            gvDeleteLab.Columns.Add(colNombre);
            gvDeleteLab.Columns.Add(colTelefono);
            gvDeleteLab.Columns.Add(colMail);
            gvDeleteLab.Columns.Add(colDireccion);
            gvDeleteLab.Columns.Add(colBtn);

            gv.grid(gvDeleteLab);
        }
        
        private void LoadGv()
        {
            gvDeleteLab.DataSource = laboratorioApp.GetAllLab();
        }

        private void gvDeleteLab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == gvDeleteLab.Columns[4].Index)
            {
                string ok = RJMessengerBox.Show("¿Estas seguro que quieres eliminar?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation).ToString();

                if (ok == "OK") 
                {
                    string nameLab = gvDeleteLab.Rows[e.RowIndex].Cells[0].Value.ToString();
                    laboratorioApp.DeleteLab(nameLab);
                    LoadGv();
                }
            }
        }
    }
}
