using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    public static class Backend
    {
        public static void CheckForUpdate()
        {
          //not rlly finished 
            try
            {
                WebClient client = new WebClient();
                if (client.DownloadString("find my backend :)").Contains("1.0"))
                {

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"There is an update for {Application.ProductName}", Application.ProductName, MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("yes");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("no");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
