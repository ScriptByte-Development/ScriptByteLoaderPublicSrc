using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ScriptByteLoader.Handler
{
    public static class Data
    {
        public static string cheat;
        public static string cheatrename = "MY_DLL_NAME.dll";
        public static string ConfigFile = @".\settings.config";
        public static string Discord = "https://discord.gg/DFcy5h9nuH";
        public static string AdInvite;
        public static string adtext;
        public static bool Injecting;
        public static bool Breached;
        public static bool nxt;
        /* These next bools will be how the Injector class decides which cheat to load
         * It will also decide which one to rename as well
        */
        public static bool otc; //one tap crack
        public static bool corsair; //corsair legit cheat
        public static string cheatfolder =  @"C:\Program Files\ScriptByteLoader";
        public static string otcfile = @"C:\Program Files\ScriptByteLoader\OTC.dll";
        public static string corsairfile = @"C:\Program Files\ScriptByteLoader\corsair.dll";
        public static string injectorfile = @"C:\Program Files\ScriptByteLoader\ScriptByteInjector.exe";

        public static bool IsAdministrator
        {
            get
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}
