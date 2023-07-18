namespace DeskFarmacia.UI.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLaboratorios = new Krypton.Toolkit.KryptonButton();
            this.btnPedido = new Krypton.Toolkit.KryptonButton();
            this.btnStok = new Krypton.Toolkit.KryptonButton();
            this.lblMenu = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.btnLaboratorios);
            this.kryptonPanel1.Controls.Add(this.btnPedido);
            this.kryptonPanel1.Controls.Add(this.btnStok);
            this.kryptonPanel1.Controls.Add(this.lblMenu);
            this.kryptonPanel1.Location = new System.Drawing.Point(31, 28);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(856, 501);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 247);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(414, 232);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = resources.GetString("kryptonLabel2.Values.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DeskFarmacia.UI.Properties.Resources.menuP;
            this.pictureBox1.Location = new System.Drawing.Point(517, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLaboratorios
            // 
            this.btnLaboratorios.CornerRoundingRadius = -1F;
            this.btnLaboratorios.Location = new System.Drawing.Point(686, 172);
            this.btnLaboratorios.Name = "btnLaboratorios";
            this.btnLaboratorios.Size = new System.Drawing.Size(109, 31);
            this.btnLaboratorios.TabIndex = 3;
            this.btnLaboratorios.Values.Text = "Laboratorios";
            this.btnLaboratorios.Click += new System.EventHandler(this.btnLaboratorios_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.CornerRoundingRadius = -1F;
            this.btnPedido.Location = new System.Drawing.Point(346, 172);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(112, 31);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Values.Text = "Pedido";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnStok
            // 
            this.btnStok.CornerRoundingRadius = -1F;
            this.btnStok.Location = new System.Drawing.Point(60, 172);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(112, 31);
            this.btnStok.TabIndex = 1;
            this.btnStok.Values.Text = "Stock";
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.Location = new System.Drawing.Point(311, 48);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(126, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Values.Text = "Menu - Farmacia";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(918, 560);
            this.Controls.Add(this.kryptonPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
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
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Text = "Farmacia";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnLaboratorios;
        private Krypton.Toolkit.KryptonButton btnPedido;
        private Krypton.Toolkit.KryptonButton btnStok;
        private Krypton.Toolkit.KryptonLabel lblMenu;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}