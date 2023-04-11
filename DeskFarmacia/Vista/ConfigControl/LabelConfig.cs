using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.ConfigControl
{
    public class LabelConfig 
    {
        public void LblTitle(object control)
        {
            if(!(control is KryptonLabel))
            {
                return;
            }

            KryptonLabel _lbl = (KryptonLabel)control;
            _lbl.Size = new System.Drawing.Size(219, 42);
            _lbl.StateNormal.ShortText.Color1 = System.Drawing.Color.SlateBlue;
            _lbl.StateNormal.ShortText.Color2 = System.Drawing.Color.SlateBlue;
            _lbl.StateNormal.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _lbl.Size = new System.Drawing.Size(125, 24);
        }

        public void LblCommon(object control)
        {
            if(!(control is KryptonLabel))
            {
                return;
            }

            KryptonLabel _lbl = (KryptonLabel)control;
            _lbl.Size = new System.Drawing.Size(76, 27);
            _lbl.StateCommon.ShortText.Color1 = System.Drawing.Color.SlateBlue;
            _lbl.StateCommon.ShortText.Color2 = System.Drawing.Color.SlateBlue;
            _lbl.StateCommon.ShortText.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        }
    }
}
