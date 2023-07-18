using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.UI.ConfigControl
{
    public class TxtConfig
    {
        public void TxtLogin(object control)
        {
            if(!(control is KryptonTextBox))
            {
                return;
            }

            KryptonTextBox _txt = (KryptonTextBox)control;
            _txt.Size = new System.Drawing.Size(163, 33);
            _txt.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            _txt.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            _txt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            _txt.StateCommon.Border.Rounding = 10F;
        }
    }
}
