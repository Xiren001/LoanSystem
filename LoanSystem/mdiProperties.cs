using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LoanSystem
{
    public static class mdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertive, int X, int Y, int cx, int cy, uint uFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0X200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWO_NOACTIVE = 0x0010;
        private const uint SWP_FRAMECHANGE = 0x0020;
        private const uint SWP_NOOWNERZORDER = 0x0200;

        public static bool SetBevel(this Form form, bool show)
        {
            foreach (Control c in form.Controls)
            {
                if (c is MdiClient client)
                {
                    int windowLong = GetWindowLong(c.Handle, GWL_EXSTYLE);

                    if (show)
                    {
                        // Add the WS_EX_CLIENTEDGE style
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        // Remove the WS_EX_CLIENTEDGE style using bitwise negation
                        windowLong &= ~WS_EX_CLIENTEDGE;
                    }

                    SetWindowLong(c.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(client.Handle, IntPtr.Zero, 0, 0, 0, 0,
                        SWO_NOACTIVE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                        SWP_NOOWNERZORDER | SWP_FRAMECHANGE
                    );

                    return true; // Return true if MdiClient found and modified
                }
            }
            return false; // Return false if no MdiClient was found
        }


    }

}
