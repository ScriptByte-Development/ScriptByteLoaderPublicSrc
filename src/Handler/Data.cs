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
        public static bool Injecting;
        public static bool Breached;

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
