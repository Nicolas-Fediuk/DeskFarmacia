using Entidades;
using Krypton.Toolkit;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.ConfigControl;
using Vista.MessengerBox;
using System.Net.Mail;

namespace Vista.View
{
    public partial class frmLaboratorio : KryptonForm
    {
        Entidades.Laboratorio laboratorio = new Entidades.Laboratorio();

        NegoLaboratorio Negolab = new NegoLaboratorio();
        NegoMedicamento NegoMed = new NegoMedicamento();
        NegoPedido NegoPed = new NegoPedido();  
        NegoLabxMed NegoLXM = new NegoLabxMed();

        TxtConfig _txt = new TxtConfig();
        LabelConfig _lbl = new LabelConfig();
        BtnConfig _btn = new BtnConfig();

        private KryptonDataGridViewTextBoxColumn colIdMed;
        private KryptonDataGridViewTextBoxColumn colNombreMed;
        private KryptonDataGridViewTextBoxColumn colPrecioMed;

        public frmLaboratorio()
        {
            InitializeComponent();

            _lbl.LblTitle(kryptonLabel1);

            _lbl.LblCommon(kryptonLabel2);
            _lbl.LblCommon(kryptonLabel3);
            _lbl.LblCommon(kryptonLabel4);
            _lbl.LblCommon(kryptonLabel5);

            _btn.btn(btnAgregar);
            
            _txt.TxtLogin(txtNombre);
            _txt.TxtLogin(txtTelefono);
            _txt.TxtLogin(txtMail);
            _txt.TxtLogin(txtDireccion);

            MakeGwLabxMed();
            LoadGwLabxMed();
            LoadCbLaboratorio();
            LoadCbEditLaboratorio();
        }
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

                if (!string.IsNullOrEmpty(txtTelefono.Text) && txtTelefono.Text.Length > 10)
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Red;
                    RJMessengerBox.Error("Ingrese un telefono valido");
                    return;
                }

                if (Negolab.validarMail(txtMail.Text))
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

                laboratorio.nombre = txtNombre.Text;
                laboratorio.telefono = Convert.ToInt64(txtTelefono.Text);
                laboratorio.mail = txtMail.Text;
                laboratorio.direccion = txtDireccion.Text;

                Negolab.loadNewLab(laboratorio);
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
        }

        
        private void MakeGwLabxMed()
        {
            gwLabxMed.AutoGenerateColumns = false;

            colIdMed = new KryptonDataGridViewTextBoxColumn();
            colIdMed.HeaderText = "ID";
            colIdMed.DataPropertyName = "idMedicamento";
            colIdMed.ReadOnly = true;

            colNombreMed = new KryptonDataGridViewTextBoxColumn();
            colNombreMed.HeaderText = "Nombre";
            colNombreMed.DataPropertyName = "medicamento";
            colNombreMed.ReadOnly = true;

            colPrecioMed = new KryptonDataGridViewTextBoxColumn();
            colPrecioMed.HeaderText = "Precio";
            colPrecioMed.DataPropertyName = "precio";
            colPrecioMed.ReadOnly = false;

            gwLabxMed.Columns.Add(colIdMed);
            gwLabxMed.Columns.Add(colNombreMed);
            gwLabxMed.Columns.Add(colPrecioMed);

            GridConfig gridConfig = new GridConfig();
            gridConfig.grid(gwLabxMed);
        }

        private void LoadGwLabxMed()
        {
            gwLabxMed.DataSource = NegoMed.loadGwMedxLab();
        }

        private void txtBuscarMed_TextChanged(object sender, EventArgs e)
        {
            string search = txtBuscarMed.Text;

            gwLabxMed.DataSource = NegoMed.loadGwMedxLab(search);
        }

        private void LoadCbLaboratorio()
        {
            cbLaboratorio.DataSource = NegoPed.LoadComboLab();
        }
        private void LoadCbEditLaboratorio()
        {
            cbLaboratorioEdit.DataSource = NegoPed.LoadComboLab();
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
                        lm.codMed = (int)fila.Cells[0].Value;
                        lm.nombreLab = cbLaboratorio.SelectedValue.ToString();
                        lm.precio = Convert.ToDecimal(fila.Cells[2].Value);

                        NegoLXM.insertDato(lm);
                    }
                }

                CleanCantGwLabxMed();

                RJMessengerBox.Ok("Medicamento y precio cargado");

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
    }
}
