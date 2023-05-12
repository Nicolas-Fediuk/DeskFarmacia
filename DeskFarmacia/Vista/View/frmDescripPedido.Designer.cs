namespace Vista.View
{
    partial class frmDescripPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescripPedido));
            this.gwItemPedido = new Krypton.Toolkit.KryptonDataGridView();
            this.lblTitulo = new Krypton.Toolkit.KryptonLabel();
            this.lblTotal = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gwItemPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gwItemPedido
            // 
            this.gwItemPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwItemPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gwItemPedido.ColumnHeadersHeight = 36;
            this.gwItemPedido.Location = new System.Drawing.Point(12, 66);
            this.gwItemPedido.Name = "gwItemPedido";
            this.gwItemPedido.RowHeadersWidth = 51;
            this.gwItemPedido.RowTemplate.Height = 29;
            this.gwItemPedido.Size = new System.Drawing.Size(549, 215);
            this.gwItemPedido.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(194, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Values.Text = "Pedido";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(211, 287);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 24);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Values.Text = "kryptonLabel2";
            // 
            // frmDescripPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 325);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gwItemPedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDescripPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)(this.gwItemPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView gwItemPedido;
        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel lblTotal;
    }
}