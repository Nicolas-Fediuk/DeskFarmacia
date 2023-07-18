using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista.MessengerBox
{
    public abstract class RJMessengerBox
    {
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            
            DialogResult result;
            using (var msgForm = new FormMessagerBox(text, caption, buttons,icon))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Error(string msj)
        {

            DialogResult result;
            using (var msgForm = new FormMessagerBox(msj, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Ok(string msj)
        {

            DialogResult result;
            using (var msgForm = new FormMessagerBox(msj, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information))
                result = msgForm.ShowDialog();
            return result;
        }
    }
}
