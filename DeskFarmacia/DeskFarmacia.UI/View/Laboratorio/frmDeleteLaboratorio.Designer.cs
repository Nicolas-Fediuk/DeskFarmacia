using DeskFarmacia.UI.Properties;

namespace DeskFarmacia.UI.View.Laboratorio
{
    partial class frmDeleteLaboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteLaboratorio));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.gvDeleteLab = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtSearchName = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteLab)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.gvDeleteLab);
            this.kryptonPanel1.Location = new System.Drawing.Point(22, 112);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1317, 518);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // gvDeleteLab
            // 
            this.gvDeleteLab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDeleteLab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvDeleteLab.ColumnHeadersHeight = 36;
            this.gvDeleteLab.Location = new System.Drawing.Point(34, 25);
            this.gvDeleteLab.Name = "gvDeleteLab";
            this.gvDeleteLab.RowHeadersWidth = 51;
            this.gvDeleteLab.RowTemplate.Height = 29;
            this.gvDeleteLab.Size = new System.Drawing.Size(1249, 470);
            this.gvDeleteLab.TabIndex = 0;
            this.gvDeleteLab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDeleteLab_CellContentClick);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(605, 24);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(149, 24);
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Eliminar Laboratorio";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(514, 71);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(134, 24);
            this.kryptonLabel2.TabIndex = 2;
            this.kryptonLabel2.Values.Text = "Filtre por nombre:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(700, 71);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(125, 27);
            this.txtSearchName.TabIndex = 3;
            // 
            // frmDeleteLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 658);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeleteLaboratorio";
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
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Farmacia";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDeleteLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView gvDeleteLab;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtSearchName;
    }
}