using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Krypton.Toolkit;
using Negocio;
using Vista.ConfigControl;
using Vista.MessengerBox;

namespace Vista.View
{
    public partial class frmPedido : KryptonForm
    {
        NegoPedido _stock = new NegoPedido();
        LabelConfig _lbl = new LabelConfig();
        BtnConfig _btn = new BtnConfig();

        private KryptonDataGridViewTextBoxColumn colIdMedicamento;
        private KryptonDataGridViewTextBoxColumn colNombreMed;
        private KryptonDataGridViewTextBoxColumn colFamiliaMed;
        private KryptonDataGridViewTextBoxColumn colPrecioMed;
        private KryptonDataGridViewTextBoxColumn colCantidad;
        public frmPedido()
        {
            InitializeComponent();

            _lbl.LblTitle(lblNuevoPedido);
            _lbl.LblTitle(kryptonLabel1);
            _btn.btn(btnCarrito);

            MakeCombo();
            MakeGwPedido();
        }

        public void MakeCombo()
        {
            cbLab.DataSource = _stock.LoadComboLab();
        }
        public void MakeGwPedido()
        {

            colIdMedicamento = new KryptonDataGridViewTextBoxColumn();
            colIdMedicamento.HeaderText = "ID";
            colIdMedicamento.DataPropertyName = "idMedicamento";
            colIdMedicamento.ReadOnly = true;

            colNombreMed = new KryptonDataGridViewTextBoxColumn();
            colNombreMed.HeaderText = "Medicamento";
            colNombreMed.DataPropertyName = "Medicamento";
            colNombreMed.ReadOnly = true;

            colFamiliaMed = new KryptonDataGridViewTextBoxColumn();
            colFamiliaMed.HeaderText = "Familia";
            colFamiliaMed.DataPropertyName = "Familia";
            colFamiliaMed.ReadOnly = true;

            colPrecioMed = new KryptonDataGridViewTextBoxColumn();
            colPrecioMed.HeaderText = "Precio";
            colPrecioMed.DataPropertyName = "Precio";
            colPrecioMed.ReadOnly = true;

            colCantidad = new KryptonDataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.ReadOnly = false;

            gwPedido.Columns.Add(colIdMedicamento);
            gwPedido.Columns.Add(colNombreMed);
            gwPedido.Columns.Add(colFamiliaMed);
            gwPedido.Columns.Add(colPrecioMed);
            gwPedido.Columns.Add(colCantidad);

            GridConfig grid = new GridConfig();
            grid.grid(gwPedido);
        }

        private void cbLab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLab.SelectedIndex != 0)
            {
                lblNuevoPedido.Text = "Pedido nuevo para: " + cbLab.SelectedItem;
                getTablaPedidoXlab(cbLab.SelectedItem.ToString());
            }
            else
            {
                lblNuevoPedido.Text = "Pedido nuevo para: -";
                gwPedido.DataSource = "";
            }
        }

        public void getTablaPedidoXlab(string nombreLab)
        {
            gwPedido.DataSource = _stock.getTablaPedido(nombreLab);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if(cbLab.SelectedIndex != 0)
            {
                List<Carrito> carrito = new List<Carrito>();

                _stock.newPedido(cbLab.SelectedItem.ToString());
                int maxPedido = _stock.serchMaxPedido();
                int idItem = 0;

                for (int i = 0; i < gwPedido.Rows.Count; i++)
                {
                    DataGridViewRow fila = gwPedido.Rows[i];
                    if (Convert.ToInt32(fila.Cells[4].Value) > 0)
                    {
                        idItem++;
                        Carrito pedido = new Carrito();
                        pedido.idPedido = maxPedido;
                        pedido.idItemPedido = idItem;
                        pedido.idMedicamento = (int)fila.Cells[0].Value;
                        pedido.cantidad = (int)fila.Cells[4].Value;
                        pedido.total = Convert.ToDecimal(fila.Cells[3].Value.ToString()) * Convert.ToInt32(fila.Cells[4].Value);

                        _stock.addItem(pedido);

                    }
                }

                CleanCantGwPedido();

                var result = RJMessengerBox.Show("Pedido enviando",
                "OK",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                var result = RJMessengerBox.Show("Seleccione un laboratorio",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            

        }
        private void CleanCantGwPedido()
        {
            for (int i = 0; i < gwPedido.Rows.Count; i++)
            {
                DataGridViewRow fila = gwPedido.Rows[i];
                fila.Cells[4].Value = 0;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmControlStock stock = new frmControlStock();  
            stock.Show();
            this.Close();
        }
    }
}
