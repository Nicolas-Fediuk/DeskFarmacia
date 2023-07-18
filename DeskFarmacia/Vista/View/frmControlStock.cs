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
using Vista.MessengerBox;
using System.Diagnostics;

namespace Vista.View
{

    public partial class frmControlStock : KryptonForm
    {
        NegoPedido _stock = new NegoPedido();
        LabelConfig _lbl = new LabelConfig();

        private KryptonDataGridViewTextBoxColumn colNombreProd;
        private KryptonDataGridViewTextBoxColumn colStock;
        private KryptonDataGridViewTextBoxColumn colfamProd;



        #region COLCARRITO
        private KryptonDataGridViewButtonColumn colDetalleCarrito;
        private KryptonDataGridViewTextBoxColumn colNumPedidoCarrito;
        private KryptonDataGridViewTextBoxColumn colNombreLabCarrito;
        private KryptonDataGridViewTextBoxColumn colFechaCarrito;
        private KryptonDataGridViewCheckBoxColumn colRecibidoCarrito;
        private KryptonDataGridViewButtonColumn colConfirmarCarrito;
        #endregion


        public frmControlStock()
        {
            InitializeComponent();
            _lbl.LblTitle(lblPrincipal);
            frmMain frmMain = new frmMain();
            frmMain.Close();

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
            colNombreProd.DataPropertyName = "Producto";
            colNombreProd.ReadOnly = true;

            colStock = new KryptonDataGridViewTextBoxColumn();
            colStock.HeaderText = "Stock";
            colStock.DataPropertyName = "Stock";
            colStock.ReadOnly = true;

            colfamProd = new KryptonDataGridViewTextBoxColumn();
            colfamProd.HeaderText = "Familia";
            colfamProd.DataPropertyName = "Familia";
            colfamProd.ReadOnly = true;


            gwProductos.Columns.Add(colNombreProd);
            gwProductos.Columns.Add(colStock);
            gwProductos.Columns.Add(colfamProd);

            GridConfig grid = new GridConfig();
            grid.grid(gwProductos);
        }

        public void LoadGwProductos()
        {
            gwProductos.DataSource = _stock.loadGwProductos();
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
            gwCarrito.DataSource = _stock.loadCarrito();
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
            colNumPedidoCarrito.DataPropertyName = "IdPedido";
            colNumPedidoCarrito.ReadOnly = true;

            colNombreLabCarrito = new KryptonDataGridViewTextBoxColumn();
            colNombreLabCarrito.HeaderText = "Laboratorio";
            colNombreLabCarrito.DataPropertyName = "nombreLab";
            colNombreLabCarrito.ReadOnly = true;

            colFechaCarrito = new KryptonDataGridViewTextBoxColumn();
            colFechaCarrito.HeaderText = "Fecha de alta";
            colFechaCarrito.DataPropertyName = "fechaAlt";
            colFechaCarrito.ReadOnly = true;

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
            gwCarrito.Columns.Add(colFechaCarrito);;
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

            if(e.ColumnIndex == gwCarrito.Columns[5].Index)
            {
                DataGridViewCell cell = gwCarrito.Rows[e.RowIndex].Cells[4];

                if(cell.Value != null && (bool)cell.Value)
                {
                    int idPedido = Convert.ToInt32(nroPedido);

                    _stock.confirmarPedido(idPedido);
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
            frmMain main = new frmMain();
            main.Close();
        }

        private void btnAllPedidos_Click(object sender, EventArgs e)
        {
            NegoItemPedido item = new NegoItemPedido();

            if (cbAllPedidos.Checked)
            {
                List<int?> listPedido = _stock.getAllIdPedido();

                foreach(int id in listPedido)
                {
                    _stock.confirmarPedido(id);
                    
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
