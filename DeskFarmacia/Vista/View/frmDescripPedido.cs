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
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Entidades;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Vista.View;

namespace Vista.View
{
    public partial class frmDescripPedido : KryptonForm
    {
        NegoItemPedido _itemPedido = new NegoItemPedido();

        private KryptonDataGridViewTextBoxColumn colitems;
        private KryptonDataGridViewTextBoxColumn colMedicamento;
        private KryptonDataGridViewTextBoxColumn colCantidad;
        private KryptonDataGridViewTextBoxColumn colPrecio;
        public frmDescripPedido(string valor)
        {
            InitializeComponent();

            int id = Convert.ToInt32(valor);
            lblTitulo.Text = "Pedido Nº"+valor;

            gwItemPedido.AutoGenerateColumns = false;

            colitems = new KryptonDataGridViewTextBoxColumn();
            colitems.HeaderText = "ID";
            colitems.DataPropertyName = "items";
            colitems.ReadOnly = true;

            colMedicamento = new KryptonDataGridViewTextBoxColumn();
            colMedicamento.HeaderText = "Medicamento";
            colMedicamento.DataPropertyName = "medicamento";
            colMedicamento.ReadOnly = true;

            colCantidad = new KryptonDataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.DataPropertyName = "cantidad";
            colCantidad.ReadOnly = true;

            colPrecio = new KryptonDataGridViewTextBoxColumn();
            colPrecio.HeaderText = "Precio";
            colPrecio.DataPropertyName = "precio";
            colPrecio.ReadOnly = true;

            gwItemPedido.Columns.Add(colitems);
            gwItemPedido.Columns.Add(colMedicamento);
            gwItemPedido.Columns.Add(colCantidad);
            gwItemPedido.Columns.Add(colPrecio);

            GridConfig grid = new GridConfig();
            grid.grid(gwItemPedido);

            LabelConfig _lbl = new LabelConfig();
            _lbl.LblTitle(lblTitulo);
            _lbl.LblCommon(lblTotal);

            cargarGwItemPedido(id); 
            lblTotal.Text = $"Total: ${_itemPedido.calcularTotal(id)}";
        }
        public void cargarGwItemPedido(int id)
        {
            gwItemPedido.DataSource = _itemPedido.GetAllPedido(id);
        }
    }
}
