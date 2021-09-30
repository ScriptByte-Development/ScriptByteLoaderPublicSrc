using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
                CheckFolder();
                CheckCheat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void Rename(string currentname, string newname)
        {
            try
            {
                System.IO.File.Move($"{currentname}", $"{newname}");
                //MY_DLL_NAME.dll
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void CheckCheat()
        {
            try
            {
                if (!File.Exists(Data.injectorfile))
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("coolwebsite.com/corsair.dll/ScriptByteInjector.exe", Data.injectorfile);
                    }
                }
                //doing if then a bool name c# automatically assumes its true, which in this case we want
                if (Data.otc)
                {
                    if (File.Exists(Data.otcfile))
                    {
                        Rename("OTC.dll", "MY_CHEAT_NAME.dll");
                        Process.Start("ScriptByte Injector.exe");
                        Rename("MY_CHEAT_NAME.dll", "OTC.dll");
                    }
                    else
                    {
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("coolwebsite.com/OTC.dll", Data.otcfile);
                        }
                    }
                }
                if (File.Exists(Data.corsairfile))
                {
                    Rename("corsair.dll", "MY_CHEAT_NAME.dll");
                    Process.Start("ScriptByte Injector.exe");
                    Rename("MY_CHEAT_NAME.dll", "corsair.dll");
                }
                else
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("coolwebsite.com/corsair.dll", Data.otcfile);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        public static void CheckFolder()
        {
            try
            {
                string Path = @"C:\Program Files\ScriptByteLoader";
                bool exists = System.IO.Directory.Exists(Path);
                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Path);
                    MessageBox.Show($"ScriptByteLoader directory not found, making directory for {Application.ProductName}", Application.ProductName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
