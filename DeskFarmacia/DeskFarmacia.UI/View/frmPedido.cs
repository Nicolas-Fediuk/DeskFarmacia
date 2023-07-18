using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeskFarmacia.UI.MessengerBox;
using DeskFarmacia.UI.ConfigControl;
using DeskFarmacia.BLL;
using DeskFarmacia.DMN.Entity;
using DeskFarmacia.CMN.DataSession;
using Vista.View;

namespace DeskFarmacia.UI.View
{
    public partial class frmPedido : KryptonForm
    {
        PedidoApp pedido = new PedidoApp();

        Pedido pedidoEntity = new Pedido();

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
            cbLab.DataSource = pedido.LoadComboLab();
        }
        public void MakeGwPedido()
        {
            gwPedido.AutoGenerateColumns = false;

            colIdMedicamento = new KryptonDataGridViewTextBoxColumn();
            colIdMedicamento.HeaderText = "ID";
            colIdMedicamento.DataPropertyName = "CODIGO_MED";
            colIdMedicamento.ReadOnly = true;

            colNombreMed = new KryptonDataGridViewTextBoxColumn();
            colNombreMed.HeaderText = "Medicamento";
            colNombreMed.DataPropertyName = "NOMBRE_MED";
            colNombreMed.ReadOnly = true;

            colFamiliaMed = new KryptonDataGridViewTextBoxColumn();
            colFamiliaMed.HeaderText = "Familia";
            colFamiliaMed.DataPropertyName = "DESCRIP_FAM";
            colFamiliaMed.ReadOnly = true;

            colPrecioMed = new KryptonDataGridViewTextBoxColumn();
            colPrecioMed.HeaderText = "Precio";
            colPrecioMed.DataPropertyName = "PRECIO_LABXMED";
            colPrecioMed.ReadOnly = true;

            colCantidad = new KryptonDataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.DataPropertyName = "CANTIDAD";
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
                lblNuevoPedido.Text = "Pedido nuevo para: ";
                gwPedido.DataSource = "";
            }
        }

        public void getTablaPedidoXlab(string nombreLab)
        {
            gwPedido.DataSource = pedido.GetTablaPedido(nombreLab);
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (cbLab.SelectedIndex != 0)
            {
                pedidoEntity.NOMLAB_PEDIDO = cbLab.SelectedItem.ToString();
                pedidoEntity.DNIUSU_PEDIDO = Session.dniUser;
                pedidoEntity.USUARIO_PEDIDO = Session.user;
                pedidoEntity.MAQUINAUSU_PEDIDO = Session.machine;

                pedido.NewPedido(pedidoEntity);

                int maxPedido = pedido.SerchMaxPedido();

                int idItem = 0;

                for (int i = 0; i < gwPedido.Rows.Count; i++)
                {
                    DataGridViewRow fila = gwPedido.Rows[i];
                    if (Convert.ToInt32(fila.Cells[4].Value) > 0)
                    {
                        idItem++;
                        ItemPedido itemPedido = new ItemPedido();
                        itemPedido.IDPEDIDO_ITEMPED = maxPedido;
                        itemPedido.IDITEMPED_ITEMPED = idItem;
                        itemPedido.CODMED_ITEMPED = (int)fila.Cells[0].Value;
                        itemPedido.CANTID_ITEMPED = (int)fila.Cells[4].Value;
                        itemPedido.PRECIO_ITEMPED = Convert.ToDecimal(fila.Cells[3].Value.ToString()) * Convert.ToInt32(fila.Cells[4].Value);

                        pedido.AddItemPedido(itemPedido);
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmControlStock stock = new frmControlStock();
            stock.Show();
            this.Close();
        }
    }
}
