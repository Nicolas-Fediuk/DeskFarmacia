namespace Vista.View
{
    partial class frmPedido
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
            this.cbLab = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnCarrito = new Krypton.Toolkit.KryptonButton();
            this.txtFiltroMed = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.gwPedido = new Krypton.Toolkit.KryptonDataGridView();
            this.lblNuevoPedido = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cbLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLab
            // 
            this.cbLab.CornerRoundingRadius = -1F;
            this.cbLab.DropDownWidth = 151;
            this.cbLab.IntegralHeight = false;
            this.cbLab.Location = new System.Drawing.Point(254, 172);
            this.cbLab.Name = "cbLab";
            this.cbLab.Size = new System.Drawing.Size(151, 25);
            this.cbLab.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbLab.TabIndex = 7;
            this.cbLab.SelectedIndexChanged += new System.EventHandler(this.cbLab_SelectedIndexChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(35, 172);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(188, 24);
            this.kryptonLabel2.TabIndex = 6;
            this.kryptonLabel2.Values.Text = "Seleccione un laboratorio:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(192, 111);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(150, 24);
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "Hacer nuevo pedido";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnCarrito);
            this.kryptonPanel1.Controls.Add(this.txtFiltroMed);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.gwPedido);
            this.kryptonPanel1.Controls.Add(this.lblNuevoPedido);
            this.kryptonPanel1.Location = new System.Drawing.Point(514, 30);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(708, 394);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.TabIndex = 1;
            this.kryptonPanel1.Visible = false;
            // 
            // btnCarrito
            // 
            this.btnCarrito.CornerRoundingRadius = -1F;
            this.btnCarrito.Location = new System.Drawing.Point(305, 331);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(112, 31);
            this.btnCarrito.TabIndex = 4;
            this.btnCarrito.Values.Text = "Carrito";
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // txtFiltroMed
            // 
            this.txtFiltroMed.Location = new System.Drawing.Point(423, 74);
            this.txtFiltroMed.Name = "txtFiltroMed";
            this.txtFiltroMed.Size = new System.Drawing.Size(125, 27);
            this.txtFiltroMed.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(160, 77);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(259, 24);
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Filtrar por nombre de medicamento:";
            // 
            // gwPedido
            // 
            this.gwPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gwPedido.ColumnHeadersHeight = 36;
            this.gwPedido.Location = new System.Drawing.Point(31, 107);
            this.gwPedido.Name = "gwPedido";
            this.gwPedido.RowHeadersWidth = 51;
            this.gwPedido.RowTemplate.Height = 29;
            this.gwPedido.Size = new System.Drawing.Size(645, 189);
            this.gwPedido.TabIndex = 1;
            // 
            // lblNuevoPedido
            // 
            this.lblNuevoPedido.Location = new System.Drawing.Point(243, 25);
            this.lblNuevoPedido.Name = "lblNuevoPedido";
            this.lblNuevoPedido.Size = new System.Drawing.Size(109, 24);
            this.lblNuevoPedido.TabIndex = 0;
            this.lblNuevoPedido.Values.Text = "kryptonLabel3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.menuP;
            this.pictureBox1.Location = new System.Drawing.Point(733, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1610, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPedido
            // 
            this.ClientSize = new System.Drawing.Size(1610, 864);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.cbLab);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPedido";
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
            ((System.ComponentModel.ISupportInitialize)(this.cbLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gwPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbLab;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnCarrito;
        private Krypton.Toolkit.KryptonTextBox txtFiltroMed;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDataGridView gwPedido;
        private Krypton.Toolkit.KryptonLabel lblNuevoPedido;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}