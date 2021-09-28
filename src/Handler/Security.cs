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

        //not working, will fix later
        public static void GrabUserVars()
        {
            try
            {
                if (Auth.User.ID != null || Auth.User.ID != null || Auth.User.ID != null)
                { 
                    return;
                }
                if (Auth.User.ID.Length < 1|| Auth.User.HWID.Length < 1 || Auth.User.IP.Length < 1)
                {
                    Data.Breached = true;
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        public static void GrabLogin()
        {
            GrabUserVars();
            if (Data.Breached)
            {
                Environment.Exit(0);
            }
        }
    }
}
