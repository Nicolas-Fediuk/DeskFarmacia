using Krypton.Toolkit;

namespace Vista.View
{
    partial class frmLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaboratorio));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            this.txtMail = new Krypton.Toolkit.KryptonTextBox();
            this.txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.cbLaboratorio = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.txtBuscarMed = new Krypton.Toolkit.KryptonTextBox();
            this.btnAgregarMedXlab = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLaboratorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(135, 50);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(192, 24);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Agregar nuevo laboratorio";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnAgregar);
            this.kryptonPanel1.Controls.Add(this.txtDireccion);
            this.kryptonPanel1.Controls.Add(this.txtMail);
            this.kryptonPanel1.Controls.Add(this.txtTelefono);
            this.kryptonPanel1.Controls.Add(this.txtNombre);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Location = new System.Drawing.Point(42, 104);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(565, 358);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.CornerRoundingRadius = -1F;
            this.btnAgregar.Location = new System.Drawing.Point(220, 290);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 31);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Values.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(301, 203);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(301, 148);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(125, 27);
            this.txtMail.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(301, 91);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(125, 27);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(301, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 4;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(113, 206);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(79, 24);
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "Direccion:";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(148, 148);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(44, 24);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Mail:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(117, 91);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 24);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Telefono:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(121, 36);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(71, 24);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Nombre:";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.kryptonPanel1);
            this.kryptonPanel2.Location = new System.Drawing.Point(53, 49);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1333, 698);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(896, 50);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(299, 24);
            this.kryptonLabel6.TabIndex = 2;
            this.kryptonLabel6.Values.Text = "Agregar un medicamento a un laboratorio";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnAgregarMedXlab);
            this.kryptonPanel3.Controls.Add(this.txtBuscarMed);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel9);
            this.kryptonPanel3.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel3.Controls.Add(this.cbLaboratorio);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel3.Location = new System.Drawing.Point(685, 104);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(618, 567);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel3.TabIndex = 3;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(54, 39);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(188, 24);
            this.kryptonLabel7.TabIndex = 0;
            this.kryptonLabel7.Values.Text = "Seleccione un laboratorio:";
            // 
            // cbLaboratorio
            // 
            this.cbLaboratorio.CornerRoundingRadius = -1F;
            this.cbLaboratorio.DropDownWidth = 151;
            this.cbLaboratorio.IntegralHeight = false;
            this.cbLaboratorio.Location = new System.Drawing.Point(272, 39);
            this.cbLaboratorio.Name = "cbLaboratorio";
            this.cbLaboratorio.Size = new System.Drawing.Size(151, 25);
            this.cbLaboratorio.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbLaboratorio.TabIndex = 1;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(162, 110);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(203, 24);
            this.kryptonLabel8.TabIndex = 2;
            this.kryptonLabel8.Values.Text = "Seleccione un medicamento";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeight = 36;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(43, 231);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 29;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(536, 259);
            this.kryptonDataGridView1.TabIndex = 3;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(66, 168);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(179, 24);
            this.kryptonLabel9.TabIndex = 4;
            this.kryptonLabel9.Values.Text = "Busque el medicamento:";
            // 
            // txtBuscarMed
            // 
            this.txtBuscarMed.Location = new System.Drawing.Point(272, 168);
            this.txtBuscarMed.Name = "txtBuscarMed";
            this.txtBuscarMed.Size = new System.Drawing.Size(125, 27);
            this.txtBuscarMed.TabIndex = 5;
            // 
            // btnAgregarMedXlab
            // 
            this.btnAgregarMedXlab.CornerRoundingRadius = -1F;
            this.btnAgregarMedXlab.Location = new System.Drawing.Point(253, 511);
            this.btnAgregarMedXlab.Name = "btnAgregarMedXlab";
            this.btnAgregarMedXlab.Size = new System.Drawing.Size(112, 31);
            this.btnAgregarMedXlab.TabIndex = 6;
            this.btnAgregarMedXlab.Values.Text = "kryptonButton1";
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1398, 1055);
            this.Controls.Add(this.kryptonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLaboratorio";
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
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Farmacia";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbLaboratorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private Krypton.Toolkit.KryptonTextBox txtDireccion;
        private Krypton.Toolkit.KryptonTextBox txtMail;
        private Krypton.Toolkit.KryptonTextBox txtTelefono;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private KryptonPanel kryptonPanel2;
        private KryptonPanel kryptonPanel3;
        private KryptonLabel kryptonLabel6;
        private KryptonButton btnAgregarMedXlab;
        private KryptonTextBox txtBuscarMed;
        private KryptonLabel kryptonLabel9;
        private KryptonDataGridView kryptonDataGridView1;
        private KryptonLabel kryptonLabel8;
        private KryptonComboBox cbLaboratorio;
        private KryptonLabel kryptonLabel7;
    }
}