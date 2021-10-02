using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptByteLoader.Handler
{
    public static class Win32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        //allocate console
        public static extern bool AllocConsole();

        //startup console message, only needs to be called once even if you load a new form, its basically a parent "form" now.
        public static void Welcome()
        {
            Console.Title = $"{Application.ProductName} Debug Console - {Application.ProductVersion}";
            Console.WriteLine($"Welcome to {Application.ProductName}");
        }

        //change the title when logged in 
        public static void Login()
        {
            Console.Title = $"{Application.ProductName} Debug Console - {Application.ProductVersion} user - {Auth.User.Username} expires - {Auth.User.Expiry}";
        }

        //self explanatory 
        public static void Error()
        {
            Console.WriteLine(Data.error);
        }
    }
}
