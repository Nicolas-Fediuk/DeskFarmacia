using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.ConfigControl;
using Vista.View;

namespace Vista
{
    public partial class frmMain : KryptonForm
    {
        BtnConfig _btn = new BtnConfig();
        LabelConfig _lbl = new LabelConfig();
        public frmMain()
        {
            InitializeComponent();
            _btn.btn(btnStok);
            _btn.btn(btnPedido);
            _btn.btn(btnLaboratorios);
            _lbl.LblTitle(lblMenu);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Close();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmControlStock fcs = new frmControlStock();
            fcs.Show();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmPedido _pedido = new frmPedido();
            _pedido.Show(); 
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            frmLaboratorio lab = new frmLaboratorio();
            lab.Show();
        }
    }
}
