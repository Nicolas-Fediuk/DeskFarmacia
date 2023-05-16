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
        Laboratorio laboratorio = new Laboratorio();
        NegoLaboratorio Negolab = new NegoLaboratorio();
        TxtConfig _txt = new TxtConfig();
        LabelConfig _lbl = new LabelConfig();
        BtnConfig _btn = new BtnConfig();

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
                    mensaje("Ingrese un nombre", "Error");
                    return;
                }

                if (!string.IsNullOrEmpty(txtTelefono.Text) && txtTelefono.Text.Length > 10)
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtTelefono.StateCommon.Border.Color1 = Color.Red;
                    mensaje("Ingrese un telefono valido", "Error");
                    return;
                }

                if (Negolab.validarMail(txtMail.Text))
                {
                    txtMail.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtMail.StateCommon.Border.Color1 = Color.Red;
                    mensaje("Ingrese un Mail valido", "Error");
                    return;
                }

                if (!string.IsNullOrEmpty(txtDireccion.Text))
                {
                    txtDireccion.StateCommon.Border.Color1 = Color.Green;
                }
                else
                {
                    txtDireccion.StateCommon.Border.Color1 = Color.Red;
                    mensaje("Ingrese una direccion","Error");
                    return;
                }

                laboratorio.nombre = txtNombre.Text;
                laboratorio.telefono = Convert.ToInt64(txtTelefono.Text);
                laboratorio.mail = txtMail.Text;
                laboratorio.direccion = txtDireccion.Text;

                Negolab.loadNewLab(laboratorio);
                cleanCampos();

                mensaje("Laboratorio agregado", "Agregado");
                
            }
            catch(Exception ex)
            {
                mensaje(ex.Message,"Error");    
            } 
        }
        private void mensaje(string msj,string titulo)
        {
            RJMessengerBox.Show(msj,
            titulo,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
        private void cleanCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtMail.Clear();
            txtDireccion.Clear();
        }
    }
}
