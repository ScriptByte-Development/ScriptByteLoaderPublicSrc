using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    public static class Injector
    {
        public static void Load()
        {
            try
            {
                fstream.CheckFolder();
                fstream.CheckCheat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void LoadThread()
        {
            Thread thread = new Thread(Load);
            thread.Start();
        }
    }
}