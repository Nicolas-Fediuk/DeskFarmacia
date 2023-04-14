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
using Vista.ConfigControl;

namespace Vista.View
{
    public partial class frmControlStock : KryptonForm
    {
        private KryptonDataGridViewTextBoxColumn colNombreProd;
        private KryptonDataGridViewTextBoxColumn colStock;
        private KryptonDataGridViewTextBoxColumn colDescripProd;
        private KryptonDataGridViewTextBoxColumn colfamProd;
        private KryptonDataGridViewTextBoxColumn colNameLab;
        private KryptonDataGridViewTextBoxColumn colTelLab;
        private KryptonDataGridViewTextBoxColumn colEmailLab;

        public frmControlStock()
        {
            InitializeComponent();
            frmMain frmMain = new frmMain();
            frmMain.Close();

            cargarGwProductos();

        }

        public void cargarGwProductos()
        {
            gwProductos.AutoGenerateColumns = false;

            colNombreProd = new KryptonDataGridViewTextBoxColumn();
            colNombreProd.HeaderText = "Producto";
            colNombreProd.DataPropertyName = "Producto";
            colNombreProd.ReadOnly= true;



        }
    }
}
