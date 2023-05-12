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
using Entidades;
using Negocio;
using Vista.ConfigControl;
using Vista.MessengerBox;

namespace Vista
{
    public partial class frmLogin : KryptonForm
    {
        Login login = new Login();
        NegoLogin NegoLogin = new NegoLogin();
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
            login.name = (txtLoginName.Text).ToUpper();
            login.pass = (txtLoginPass.Text).ToUpper();

            if (NegoLogin.validarLogin(login))
            {
                frmMain fm = new frmMain();
                fm.ShowDialog();
            }
            else{
                var result = RJMessengerBox.Show("Nombre o Contraseña erronea",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
