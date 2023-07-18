using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using DeskFarmacia.UI.ConfigControl;
using DeskFarmacia.UI.MessengerBox;
using DeskFarmacia.BLL;
using DeskFarmacia.UI.View;
using DeskFarmacia.DMN.Entity;

namespace DeskFarmacia.UI
{
    public partial class frmLogin : KryptonForm
    {
        Login login = new Login();
        LoginApp loginApp = new LoginApp(); 

        LabelConfig label = new LabelConfig();
        TxtConfig txt = new TxtConfig();

        public frmLogin()
        {
            InitializeComponent();

            label.LblTitle(kryptonLabel1);
            label.LblCommon(kryptonLabel2);
            label.LblCommon(kryptonLabel3);

            txt.TxtLogin(txtLoginName);
            txt.TxtLogin(txtLoginPass);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login.CORREO_LOG = txtLoginName.Text; 
            login.PASSWORD_LOG = txtLoginPass.Text;

            if (loginApp.VerificarLogin(login)){

                frmMain main = new frmMain();
                main.Show();
            }
            else
            {
                var result = RJMessengerBox.Show("Nombre o Contraseña erronea",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
