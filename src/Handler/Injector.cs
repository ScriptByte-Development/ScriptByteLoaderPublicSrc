using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    public static class Injector
    {
        public static void Start()
        {
            try
            {
                //download dlls and rename them then open injector :p
                Process.Start("ScriptByte Injector.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void Rename(string currentname, string newname)
        {
            System.IO.File.Move($"{currentname}", $"{newname}");
            //MY_DLL_NAME.dll
        }
    }
}
