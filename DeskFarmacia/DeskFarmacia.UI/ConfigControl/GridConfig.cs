using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krypton.Toolkit;

namespace DeskFarmacia.UI.ConfigControl
{
    public class GridConfig
    {
        public void grid(object control)
        {
            if(!(control is KryptonDataGridView))
            {
                return;
            }

            var _GridView = (KryptonDataGridView)control;

            _GridView.RowHeadersVisible = false;

            _GridView.AllowUserToResizeRows = false;

            _GridView.GridStyles.Style = DataGridViewStyle.Mixed;

            _GridView.RowTemplate.Height = 28;

            _GridView.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular);

            _GridView.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Regular);

            _GridView.StateCommon.HeaderColumn.Content.Color1 = Color.MidnightBlue;
        }
    }
}
