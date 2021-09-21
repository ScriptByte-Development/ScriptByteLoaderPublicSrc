using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    class Alerts
    {
        public static Point LastPt = new Point(0, 0);

        public static void Push(string message, string title = "ScriptByte Loader Notification")
        {
            var bottomCorner = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            var position = new Point(bottomCorner.X - 355, bottomCorner.Y - 175);
            new GUI.ToastWnd(position, message, title).Show();
        }
    }
}
