using Krypton.Toolkit;
using System.Windows.Forms;

namespace Vista.View
{
    partial class frmControlStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlStock));
            this.gwProductos = new Krypton.Toolkit.KryptonDataGridView();
            this.lblPrincipal = new Krypton.Toolkit.KryptonLabel();
            this.gwCarrito = new Krypton.Toolkit.KryptonDataGridView();
            this.lblConfirmarPedido = new Krypton.Toolkit.KryptonLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.cbAllPedidos = new Krypton.Toolkit.KryptonCheckBox();
            this.btnAllPedidos = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gwProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCarrito)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gwProductos
            // 
            this.gwProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gwProductos.ColumnHeadersHeight = 36;
            this.gwProductos.Location = new System.Drawing.Point(80, 83);
            this.gwProductos.Name = "gwProductos";
            this.gwProductos.RowHeadersWidth = 51;
            this.gwProductos.RowTemplate.Height = 29;
            this.gwProductos.Size = new System.Drawing.Size(1112, 225);
            this.gwProductos.TabIndex = 0;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Location = new System.Drawing.Point(538, 28);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(114, 24);
            this.lblPrincipal.TabIndex = 1;
            this.lblPrincipal.Values.Text = "Control - Stock";
            // 
            // gwCarrito
            // 
            this.gwCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwCarrito.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gwCarrito.ColumnHeadersHeight = 36;
            this.gwCarrito.Location = new System.Drawing.Point(88, 85);
            this.gwCarrito.Name = "gwCarrito";
            this.gwCarrito.RowHeadersWidth = 51;
            this.gwCarrito.RowTemplate.Height = 29;
            this.gwCarrito.Size = new System.Drawing.Size(802, 279);
            this.gwCarrito.TabIndex = 7;
            this.gwCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gwCarrito_CellContentClick);
            // 
            // lblConfirmarPedido
            // 
            this.lblConfirmarPedido.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmarPedido.Location = new System.Drawing.Point(384, 23);
            this.lblConfirmarPedido.Name = "lblConfirmarPedido";
            this.lblConfirmarPedido.Size = new System.Drawing.Size(260, 42);
            this.lblConfirmarPedido.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblConfirmarPedido.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.lblConfirmarPedido.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmarPedido.TabIndex = 8;
            this.lblConfirmarPedido.Values.Text = "Pedidos a confirmar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1564, 31);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.SlateBlue;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(519, 79);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(373, 24);
            this.kryptonLabel1.TabIndex = 10;
            this.kryptonLabel1.Values.Text = "¿Desea confirmar la recepcion de todos los pedidos?:";
            // 
            // cbAllPedidos
            // 
            this.cbAllPedidos.AutoSize = false;
            this.cbAllPedidos.Location = new System.Drawing.Point(898, 79);
            this.cbAllPedidos.Name = "cbAllPedidos";
            this.cbAllPedidos.Size = new System.Drawing.Size(37, 28);
            this.cbAllPedidos.TabIndex = 11;
            this.cbAllPedidos.Values.Text = "";
            // 
            // btnAllPedidos
            // 
            this.btnAllPedidos.AutoSize = true;
            this.btnAllPedidos.CornerRoundingRadius = -1F;
            this.btnAllPedidos.Location = new System.Drawing.Point(994, 68);
            this.btnAllPedidos.Name = "btnAllPedidos";
            this.btnAllPedidos.Size = new System.Drawing.Size(216, 39);
            this.btnAllPedidos.TabIndex = 12;
            this.btnAllPedidos.Values.Text = "Confirmar todos los pedidos";
            this.btnAllPedidos.Click += new System.EventHandler(this.btnAllPedidos_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel1.AutoSize = true;
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.btnAllPedidos);
            this.kryptonPanel1.Controls.Add(this.cbAllPedidos);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 835);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1564, 220);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.TabIndex = 13;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.AutoSize = true;
            this.kryptonPanel2.Controls.Add(this.gwProductos);
            this.kryptonPanel2.Controls.Add(this.lblPrincipal);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 31);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1564, 311);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel2.TabIndex = 14;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.AutoSize = true;
            this.kryptonPanel3.Controls.Add(this.lblConfirmarPedido);
            this.kryptonPanel3.Controls.Add(this.gwCarrito);
            this.kryptonPanel3.Location = new System.Drawing.Point(108, 380);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1365, 400);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Crimson;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.Red;
            this.kryptonPanel3.TabIndex = 15;
            // 
            // frmControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1564, 1055);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmControlStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Border.Color1 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Border.Color2 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.SlateBlue;
            this.StateCommon.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.LongText.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Content.LongText.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(15, 10, -1, 1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Farmacia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmControlStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gwProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwCarrito)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonCheckSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView gwProductos;
        private Krypton.Toolkit.KryptonLabel lblPrincipal;
        private Krypton.Toolkit.KryptonDataGridView gwCarrito;
        private Krypton.Toolkit.KryptonLabel lblConfirmarPedido;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private KryptonCheckSet kryptonCheckSet1;
        private KryptonLabel kryptonLabel1;
        private KryptonCheckBox cbAllPedidos;
        private KryptonButton btnAllPedidos;
        private KryptonPanel kryptonPanel1;
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kryptonPanel3;
    }
}