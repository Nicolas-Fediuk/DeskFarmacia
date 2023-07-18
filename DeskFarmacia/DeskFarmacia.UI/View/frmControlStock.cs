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
using DeskFarmacia.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DeskFarmacia.DMN;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Vista.View;
using DeskFarmacia.UI.MessengerBox;
using System.Diagnostics;
using DeskFarmacia.UI.View;

namespace Vista.View
{

    public partial class frmControlStock : KryptonForm
    {
        PedidoApp pedido = new PedidoApp();

        LabelConfig _lbl = new LabelConfig();

        private KryptonDataGridViewTextBoxColumn colNombreProd;
        private KryptonDataGridViewTextBoxColumn colStock;



        #region COLCARRITO
        private KryptonDataGridViewButtonColumn colDetalleCarrito;
        private KryptonDataGridViewTextBoxColumn colNumPedidoCarrito;
        private KryptonDataGridViewTextBoxColumn colNombreLabCarrito;
        private KryptonDataGridViewTextBoxColumn colFechaCarrito;
        private KryptonDataGridViewTextBoxColumn colNombreUsuario;
        private KryptonDataGridViewTextBoxColumn colUsuario;
        private KryptonDataGridViewCheckBoxColumn colRecibidoCarrito;
        private KryptonDataGridViewButtonColumn colConfirmarCarrito;
        #endregion


        public frmControlStock()
        {
            InitializeComponent();
            _lbl.LblTitle(lblPrincipal);


            MakeGwCarrito();
            MakeGwProductos();
            LoadGwProductos();
            LoadGwCarrito();

        }
        public void MakeGwProductos()
        {
            gwProductos.AutoGenerateColumns = false;

            colNombreProd = new KryptonDataGridViewTextBoxColumn();
            colNombreProd.HeaderText = "Producto";
            colNombreProd.DataPropertyName = "NOMBRE_MED";
            colNombreProd.ReadOnly = true;

            colStock = new KryptonDataGridViewTextBoxColumn();
            colStock.HeaderText = "Stock";
            colStock.DataPropertyName = "STOCK_MED";
            colStock.ReadOnly = true;


            gwProductos.Columns.Add(colNombreProd);
            gwProductos.Columns.Add(colStock);

            GridConfig grid = new GridConfig();
            grid.grid(gwProductos);
        }

        public void LoadGwProductos()
        {
            gwProductos.DataSource = pedido.LoadGwProductos();
        }

        private void frmControlStock_Load(object sender, EventArgs e)
        {
            gwProductos.Left = (this.kryptonPanel2.Width - gwProductos.Width) / 2;
            lblPrincipal.Left = (this.kryptonPanel2.Width - lblPrincipal.Width) / 2;

            kryptonPanel3.Left = (this.ClientSize.Width - kryptonPanel3.Width) / 2;
            gwCarrito.Left = (this.kryptonPanel3.Width - gwCarrito.Width) / 2;
            lblConfirmarPedido.Left = (this.kryptonPanel3.Width - lblConfirmarPedido.Width) / 2;

            kryptonPanel1.Width = this.ClientSize.Width;
            //kryptonPanel1.Height = this.ClientSize.Height - kryptonPanel3.Height - kryptonPanel2.Height - this.menuStrip1.Height;

        }

        public void LoadGwCarrito()
        {
            gwCarrito.DataSource = pedido.LoadGwPedidosConfir();
        }

        private void MakeGwCarrito()
        {
            gwCarrito.AutoGenerateColumns = false;

            colDetalleCarrito = new KryptonDataGridViewButtonColumn();
            colDetalleCarrito.HeaderText = "Detalle";
            colDetalleCarrito.DataPropertyName = "Detalle";
            colDetalleCarrito.Text = "+";
            colDetalleCarrito.UseColumnTextForButtonValue = true;
            colDetalleCarrito.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colDetalleCarrito.CellTemplate.Style.BackColor = Color.Honeydew;
            colDetalleCarrito.DisplayIndex = 0;

            colNumPedidoCarrito = new KryptonDataGridViewTextBoxColumn();
            colNumPedidoCarrito.HeaderText = "Numero";
            colNumPedidoCarrito.DataPropertyName = "ID_PEDIDO";
            colNumPedidoCarrito.ReadOnly = true;

            colNombreLabCarrito = new KryptonDataGridViewTextBoxColumn();
            colNombreLabCarrito.HeaderText = "Laboratorio";
            colNombreLabCarrito.DataPropertyName = "NOMLAB_PEDIDO";
            colNombreLabCarrito.ReadOnly = true;

            colFechaCarrito = new KryptonDataGridViewTextBoxColumn();
            colFechaCarrito.HeaderText = "Fecha de alta";
            colFechaCarrito.DataPropertyName = "FECALT_PEDIDO";
            colFechaCarrito.ReadOnly = true;

            colNombreUsuario = new KryptonDataGridViewTextBoxColumn();
            colNombreUsuario.HeaderText = "Comprador";
            colNombreUsuario.DataPropertyName = "NOMBREUSUARIO";
            colNombreUsuario.ReadOnly = true;

            colUsuario = new KryptonDataGridViewTextBoxColumn();
            colUsuario.HeaderText = "Usuario del comprador";
            colUsuario.DataPropertyName = "USUARIO_PEDIDO";
            colUsuario.ReadOnly = true;

            colRecibidoCarrito = new KryptonDataGridViewCheckBoxColumn();
            colRecibidoCarrito.HeaderText = "Recibido";
            colRecibidoCarrito.DataPropertyName = "Recibido";

            colConfirmarCarrito = new KryptonDataGridViewButtonColumn();
            colConfirmarCarrito.HeaderText = "Confirmar";
            colConfirmarCarrito.DataPropertyName = "confirmado";
            colConfirmarCarrito.Text = "Comprar";
            colConfirmarCarrito.UseColumnTextForButtonValue = true;
            
            gwCarrito.Columns.Add(colDetalleCarrito);
            gwCarrito.Columns.Add(colNumPedidoCarrito);
            gwCarrito.Columns.Add(colNombreLabCarrito);
            gwCarrito.Columns.Add(colFechaCarrito);
            gwCarrito.Columns.Add(colNombreUsuario);
            gwCarrito.Columns.Add(colUsuario);
            gwCarrito.Columns.Add(colRecibidoCarrito);
            gwCarrito.Columns.Add(colConfirmarCarrito);


            GridConfig grid = new GridConfig();
            grid.grid(gwCarrito);

        }

        private void gwCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = gwCarrito.SelectedCells[0].OwningRow;

            var nroPedido = selectedRow.Cells[1].Value.ToString();

            if (e.ColumnIndex == gwCarrito.Columns[0].Index)
            {
                frmDescripPedido p = new frmDescripPedido(nroPedido);  

                p.ShowDialog();
            }

            if(e.ColumnIndex == gwCarrito.Columns[7].Index)
            {
                DataGridViewCell cell = gwCarrito.Rows[e.RowIndex].Cells[6];

                if(cell.Value != null && (bool)cell.Value)
                {
                    int idPedido = Convert.ToInt32(nroPedido);

                    pedido.ConfirmarPedido(idPedido);
                    LoadGwProductos();
                    LoadGwCarrito();

                    var result = RJMessengerBox.Show("Medicamentos Agregados",
                    "Confirmado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    var result = RJMessengerBox.Show("Confirme la recepcion del pedido",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void pedidoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllPedidos_Click(object sender, EventArgs e)
        {

            if (cbAllPedidos.Checked)
            {
                List<int> listPedido = pedido.AllIdPedido();

                foreach(int id in listPedido)
                {
                    pedido.ConfirmarPedido(id);
                }
                LoadGwProductos();
                LoadGwCarrito();
                var result = RJMessengerBox.Show("Medicamentos Agregados",
                "Confirmado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                var result = RJMessengerBox.Show("Confirme el pedido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
        }     

    }
}
