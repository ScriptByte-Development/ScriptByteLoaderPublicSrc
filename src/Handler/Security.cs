using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    public static class Security
    {
     
    //not posting my backend code for now, but i will post my update function 
       
       public static void CheckForUpdate()
        {
            try
            {
                WebClient client = new WebClient();
                if (client.DownloadString("find my backend html file yourself :)").Contains("1.0"))
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
        
        public static void GrabLogin()
        {
            GrabUserVars(); //not including my function to grab user variables.. basically if you aren't logged in Data.Breached gets set to true :3
            if (Data.Breached)
            {
                Environment.Exit(0);
            }
        }
