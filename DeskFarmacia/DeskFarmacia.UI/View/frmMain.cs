using Krypton.Toolkit;
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
using Vista.View;

namespace DeskFarmacia.UI.View
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

        private void btnPedido_Click(object sender, EventArgs e)
        {
            frmPedido pedido= new frmPedido();
            pedido.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            frmControlStock stock = new frmControlStock();
            stock.Show();
        }

        private void btnLaboratorios_Click(object sender, EventArgs e)
        {
            frmLaboratorio laboratorio = new frmLaboratorio();
            laboratorio.Show(); 
        }
    }
}
