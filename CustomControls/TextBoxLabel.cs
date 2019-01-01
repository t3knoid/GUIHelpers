using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHelpers
{
    public partial class TextBoxLabel : TextBox
    {
        public TextBoxLabel()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.TabStop = false;
        }
        protected override void WndProc(ref Message m)
        {
            // Workaround required since TextBox calls Focus() on a mouse click
            // Intercept WM_NCHITTEST to make it transparent to mouse clicks
            if (m.Msg == 0x84) m.Result = IntPtr.Zero;
            else base.WndProc(ref m);
        }
    }
}
