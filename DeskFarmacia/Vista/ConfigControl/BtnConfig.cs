using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.ConfigControl
{
    public class BtnConfig
    {
        public void btn(object control)
        {
            if(!(control is KryptonButton)) {
                return;
            }

            KryptonButton _btn = (KryptonButton)control;

            _btn.OverrideDefault.Back.Color1 = System.Drawing.Color.SlateBlue;
            _btn.OverrideDefault.Back.Color2 = System.Drawing.Color.SlateBlue;
            _btn.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            _btn.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            _btn.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.OverrideDefault.Border.Rounding = 10F;
            _btn.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            _btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            _btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            _btn.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _btn.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            _btn.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            _btn.OverrideFocus.Border.Color1 = System.Drawing.Color.SlateBlue;
            _btn.OverrideFocus.Border.Color2 = System.Drawing.Color.SlateBlue;
            _btn.OverrideFocus.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.OverrideFocus.Border.Rounding = 10F;
            _btn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.SlateBlue;
            _btn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.SlateBlue;
            _btn.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _btn.Size = new System.Drawing.Size(120, 40);
            _btn.StateCommon.Back.Color1 = System.Drawing.Color.SlateBlue;
            _btn.StateCommon.Back.Color2 = System.Drawing.Color.SlateBlue;
            _btn.StateCommon.Border.Color1 = System.Drawing.Color.White;
            _btn.StateCommon.Border.Color2 = System.Drawing.Color.White;
            _btn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _btn.StateCommon.Border.Rounding = 10F;
            _btn.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, 5);
            _btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            _btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            _btn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _btn.Cursor = System.Windows.Forms.Cursors.Hand;
        }
    }
}
