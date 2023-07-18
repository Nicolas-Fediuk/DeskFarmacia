using DeskFarmacia.DMN;
using Krypton.Toolkit;
using DeskFarmacia.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeskFarmacia.UI.ConfigControl;
using DeskFarmacia.UI.MessengerBox;
using System.Net.Mail;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.UI.View.Laboratorio;

namespace Vista.View
{
    public partial class frmLaboratorio : KryptonForm
    {
        Laboratorio laboratorio = new Laboratorio();
        LaboratorioApp laboratorioBLL = new LaboratorioApp();


        TxtConfig _txt = new TxtConfig();
        LabelConfig _lbl = new LabelConfig();
        BtnConfig _btn = new BtnConfig();
        GridConfig gridConfig = new GridConfig();

        private KryptonDataGridViewTextBoxColumn colIdMed;
        private KryptonDataGridViewTextBoxColumn colNombreMed;
        private KryptonDataGridViewTextBoxColumn colPrecioMed;


        private KryptonDataGridViewTextBoxColumn colIdMedxPrecio;
        private KryptonDataGridViewTextBoxColumn colNomMedxPrecio;
        private KryptonDataGridViewTextBoxColumn colNomLabxPrecio;
        private KryptonDataGridViewTextBoxColumn colPrecioMedxPrecio;

        public frmLaboratorio()
        {
            InitializeComponent();

            _lbl.LblTitleWhite(kryptonLabel1);
            _lbl.LblTitleWhite(kryptonLabel6);
            _lbl.LblTitleWhite(kryptonLabel10);
            _lbl.LblTitleWhite(kryptonLabel16);

            _lbl.LblCommon(kryptonLabel2);
            _lbl.LblCommon(kryptonLabel3);
            _lbl.LblCommon(kryptonLabel4);
            _lbl.LblCommon(kryptonLabel5);
            _lbl.LblCommon(kryptonLabel7);
            _lbl.LblCommon(kryptonLabel9);

            _lbl.LblCommon(kryptonLabel11);
            _lbl.LblCommon(kryptonLabel12);
            _lbl.LblCommon(kryptonLabel13);
            _lbl.LblCommon(kryptonLabel14);
            _lbl.LblCommon(kryptonLabel15);

            _lbl.LblCommon(kryptonLabel17);
            _lbl.LblCommon(kryptonLabel18);

            _btn.btn(btnAgregar);
            _btn.btn(btnAgregarMedXlab);
            _btn.btn(btnEditar);
            _btn.btn(btnModPrecio);

            _txt.TxtLogin(txtNombre);
            _txt.TxtLogin(txtTelefono);
            _txt.TxtLogin(txtMail);
            _txt.TxtLogin(txtDireccion);
            _txt.TxtLogin(txtBuscarMed);

            _txt.TxtLogin(txtNombreEdit);
            _txt.TxtLogin(txtTelefonoEdit);
            _txt.TxtLogin(txtMailEdit);
            _txt.TxtLogin(txtDireccionEdit);

            _txt.TxtLogin(txtSerchLabPrecio);
            _txt.TxtLogin(txtSerchMedPrecio);

            LoadControllers();
        }
        private void LoadControllers()
        {
            MakeGwLabxMed();
            MakeGwPrecioxLab();
            LoadGwLabxMed();
            //LoadGwPrecioxLab();
            LoadCbLaboratorio();
            LoadCbEditLaboratorio();
        }

        private void MakeGwPrecioxLab()
        {
            gwLabxMed.AutoGenerateColumns = false;

            colIdMedxPrecio = new KryptonDataGridViewTextBoxColumn();
            colIdMedxPrecio.HeaderText = "ID medicamento";
            colIdMedxPrecio.DataPropertyName = "CODIGO_MED";
            colIdMedxPrecio.ReadOnly = true;

            colNomMedxPrecio = new KryptonDataGridViewTextBoxColumn();
            colNomMedxPrecio.HeaderText = "Medicamento";
            colNomMedxPrecio.DataPropertyName = "NOMBRE_MED";
            colNomMedxPrecio.ReadOnly = true;

            colNomLabxPrecio = new KryptonDataGridViewTextBoxColumn();
            colNomLabxPrecio.HeaderText = "Laboratorio";
            colNomLabxPrecio.DataPropertyName = "NOMLAB_LABXMED";
            colNomLabxPrecio.ReadOnly = true;

            colPrecioMedxPrecio = new KryptonDataGridViewTextBoxColumn();
            colPrecioMedxPrecio.HeaderText = "Precio";
            colPrecioMedxPrecio.DataPropertyName = "PRECIO_LABXMED";
            colPrecioMedxPrecio.ReadOnly = false;

            gwPrecioxLab.Columns.Add(colIdMedxPrecio);
            gwPrecioxLab.Columns.Add(colNomMedxPrecio);
            gwPrecioxLab.Columns.Add(colNomLabxPrecio);
            gwPrecioxLab.Columns.Add(colPrecioMedxPrecio);

            gridConfig.grid(gwPrecioxLab);
        }

        //private void LoadGwPrecioxLab()
        //{
        //    gwPrecioxLab.DataSource = laboratorioBLL.GetGwPrecioxLab();
        //}

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    txtNombre.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtNombre.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un nombre");
                    return;
                }

                if (!string.IsNullOrEmpty(txtTelefono.Text) && txtTelefono.Text.Length >= 10)
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un telefono valido");
                    return;
                }

                if (laboratorioBLL.ValidarMail(txtMail.Text))
                {
                    txtMail.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtMail.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un Mail valido");
                    return;
                }

                if (!string.IsNullOrEmpty(txtDireccion.Text))
                {
                    txtDireccion.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtDireccion.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese una direccion");
                    return;
                }

                laboratorio.NOMBRE_LAB = txtNombre.Text;
                laboratorio.TEL_LAB = txtTelefono.Text;
                laboratorio.MAIL_LAB = txtMail.Text;
                laboratorio.DIRECCION_LAB = txtDireccion.Text;

                laboratorioBLL.LoadNewLab(laboratorio);
                LoadControllers();
                cleanCampos();

                RJMessengerBox.Ok("Laboratorio agregado");
            }
            catch(Exception ex)
            {
                RJMessengerBox.Error(ex.Message);   
            } 
        }

        private void cleanCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtDireccion.Clear();

            txtNombreEdit.Clear();
            txtTelefonoEdit.Clear();
            txtMailEdit.Clear();
            txtDireccionEdit.Clear();
        }

        
        private void MakeGwLabxMed()
        {
            gwLabxMed.AutoGenerateColumns = false;

            colIdMed = new KryptonDataGridViewTextBoxColumn();
            colIdMed.HeaderText = "ID";
            colIdMed.DataPropertyName = "CODIGO_MED";
            colIdMed.ReadOnly = true;

            colNombreMed = new KryptonDataGridViewTextBoxColumn();
            colNombreMed.HeaderText = "Nombre";
            colNombreMed.DataPropertyName = "NOMBRE_MED";
            colNombreMed.ReadOnly = true;

            colPrecioMed = new KryptonDataGridViewTextBoxColumn();
            colPrecioMed.HeaderText = "Precio";
            colPrecioMed.DataPropertyName = "precio";
            colPrecioMed.ReadOnly = false;

            gwLabxMed.Columns.Add(colIdMed);
            gwLabxMed.Columns.Add(colNombreMed);
            gwLabxMed.Columns.Add(colPrecioMed);

            gridConfig.grid(gwLabxMed);
        }

        private void LoadGwLabxMed()
        {
            gwLabxMed.DataSource = laboratorioBLL.LoadGwMedxLab();
        }

        private void txtBuscarMed_TextChanged(object sender, EventArgs e)
        {
            string search = txtBuscarMed.Text;

            gwLabxMed.DataSource = laboratorioBLL.LoadGwMedxLab(search);
        }

        private void LoadCbLaboratorio()
        {
            cbLaboratorio.DataSource = laboratorioBLL.LoadComboLab();
        }

        private void LoadCbEditLaboratorio()
        {
            cbLaboratorioEdit.DataSource = laboratorioBLL.LoadComboLab();
        }

        private void btnAgregarMedXlab_Click(object sender, EventArgs e)
        {
            if(cbLaboratorio.SelectedIndex != 0)
            {
                for(int i= 0; i<gwLabxMed.Rows.Count; i++)
                {
                    DataGridViewRow fila = gwLabxMed.Rows[i];

                    if (Convert.ToInt32(fila.Cells[2].Value) > 0)
                    {
                        LabxMed lm = new LabxMed();
                        lm.CodMedicamento = (int)fila.Cells[0].Value;
                        lm.nombreLab = cbLaboratorio.SelectedValue.ToString();
                        lm.precio = Convert.ToDecimal(fila.Cells[2].Value);

                        laboratorioBLL.InsertLabxMed(lm);
                    }
                }

                CleanCantGwLabxMed();
                RJMessengerBox.Ok("Medicamento y precio cargado");

            }
            else
            {
                RJMessengerBox.Error("Seleccione un laboratorio");
            }
        }
        private void CleanCantGwLabxMed()
        {
            for (int i = 0; i < gwLabxMed.Rows.Count; i++)
            {
                DataGridViewRow fila = gwLabxMed.Rows[i]; 
                fila.Cells[2].Value = "0";
            }
        }


        private void gwLabxMed_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == colPrecioMed.Index)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out _) && e.FormattedValue.ToString() != "")
                {
                    RJMessengerBox.Error("Ingrese solo numeros");
                } 
            }
        }

        private void frmLaboratorio_Load(object sender, EventArgs e)
        {
            kryptonPanel2.Left = (this.ClientSize.Width - kryptonPanel2.Width) / 2;
            kryptonPanel4.Left = (this.ClientSize.Width - kryptonPanel4.Width) / 2;   
        }

        private void cbLaboratorioEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLaboratorioEdit.SelectedIndex != 0) 
            {
                laboratorio = laboratorioBLL.DataLaboratorio(cbLaboratorioEdit.SelectedValue.ToString());

                txtNombreEdit.Text = laboratorio.NOMBRE_LAB;
                txtTelefonoEdit.Text = laboratorio.TEL_LAB.ToString();
                txtMailEdit.Text = laboratorio.MAIL_LAB;
                txtDireccionEdit.Text = laboratorio.DIRECCION_LAB;
            }
            else
            {
                cleanCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(cbLaboratorioEdit.SelectedIndex != 0)
            {

                if (!string.IsNullOrEmpty(txtTelefonoEdit.Text) && txtTelefonoEdit.Text.Length >= 10)
                {
                    txtTelefonoEdit.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtTelefonoEdit.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un telefono valido");
                    return;
                }

                if (laboratorioBLL.ValidarMail(txtMailEdit.Text))
                {
                    txtMailEdit.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtMailEdit.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un Mail valido");
                    return;
                }

                if (!string.IsNullOrEmpty(txtDireccionEdit.Text))
                {
                    txtDireccionEdit.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtDireccionEdit.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese una direccion");
                    return;
                }

                laboratorio.NOMBRE_LAB = txtNombreEdit.Text;
                laboratorio.TEL_LAB = txtTelefonoEdit.Text;
                laboratorio.MAIL_LAB = txtMailEdit.Text;
                laboratorio.DIRECCION_LAB = txtDireccionEdit.Text;

                bool ok = laboratorioBLL.EditLaboratorio(laboratorio);
                    
                if(ok){

                    RJMessengerBox.Ok("Laboratorio modificado");
                    cleanCampos();
                }
                else
                {
                    RJMessengerBox.Error("Vefique que el mail no se repitan");
                }
            }
            else
            {
                RJMessengerBox.Error("Seleccione un laboratorio a editar");
            }
        }

        private void txtSerchLabPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtSerchMedPrecio.Text.Length != 0 && txtSerchLabPrecio.Text.Length != 0)
            {
                gwPrecioxLab.DataSource = laboratorioBLL.GetGwPrecioxLabWithFilter(txtSerchLabPrecio.Text, txtSerchMedPrecio.Text);
            }

            if(txtSerchMedPrecio.Text.Length == 0 && txtSerchLabPrecio.Text.Length != 0)
            {
                gwPrecioxLab.DataSource = laboratorioBLL.GetGwPrecioxLabWithFilterLab(txtSerchLabPrecio.Text);
            }
            
        }

        private void txtSerchMedPrecio_TextChanged(object sender, EventArgs e)
        {
            if(txtSerchMedPrecio.Text.Length != 0 && txtSerchLabPrecio.Text.Length != 0)
            {
                gwPrecioxLab.DataSource = laboratorioBLL.GetGwPrecioxLabWithFilter(txtSerchLabPrecio.Text, txtSerchMedPrecio.Text);
            }
            
            if (txtSerchMedPrecio.Text.Length != 0 && txtSerchLabPrecio.Text.Length == 0)
            {
                gwPrecioxLab.DataSource = laboratorioBLL.GetGwPrecioxLabWithFilterMed(txtSerchMedPrecio.Text);
            }

        }

        private void btnModPrecio_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gwPrecioxLab.Rows.Count; i++)
            {
                DataGridViewRow fila = gwPrecioxLab.Rows[i];

                if (Convert.ToDecimal(fila.Cells[3].Value) > 0)
                {
                    TablaPrecioxLab precioMedxLab = new TablaPrecioxLab();  

                    precioMedxLab.CODIGO_MED = (int)fila.Cells[0].Value;
                    precioMedxLab.NOMBRE_MED = (string)fila.Cells[1].Value;
                    precioMedxLab.NOMLAB_LABXMED = (string)fila.Cells[2].Value;
                    precioMedxLab.PRECIO_LABXMED = (decimal)fila.Cells[3].Value;    

                    laboratorioBLL.UpdatePrecioMedxLab(precioMedxLab);
                }
            }

            RJMessengerBox.Ok("Precios modificados");
        }

        private void eliminarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteLaboratorio frmDelete = new frmDeleteLaboratorio();
            frmDelete.Show();
        }
    }
}
