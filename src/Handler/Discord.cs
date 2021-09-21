using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using System.Windows.Forms;
using static ScriptByteLoader.Handler.Data;

namespace ScriptByteLoader.Handler
{
    public static class Discord
    {

        public static DiscordRpcClient client;

        public static void Start()
        {
            client = new DiscordRpcClient("");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = $"{Application.ProductName} | Main Menu",
                State = $"User: {Auth.User.Username} Expires: {Auth.User.Expiry}",
                Assets = new Assets()
                {
                    LargeImageKey = "hex",
                    LargeImageText = $"{Application.ProductName}",
                }
            });
        }

        public static void UpdateToLoader()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"{Application.ProductName} | Idle",
                State = $"User: {Auth.User.Username} Expires: {Auth.User.Expiry}",
                Assets = new Assets()
                {
                    LargeImageKey = "hex",
                    LargeImageText = $"{Application.ProductName}",
                }
            });
        }

        public static void Update()
        {
            if (Injecting)
            {
                client.SetPresence(new RichPresence()
                {
                    Details = $"{Application.ProductName} | Injecting",
                    State = $"User: {Auth.User.Username} Expires: {Auth.User.Expiry}",
                    Assets = new Assets()
                    {
                        LargeImageKey = "hex",
                        LargeImageText = $"{Application.ProductName}",
                    }
                });
            }
        }

        public static void Destroy()
        {
            client.Dispose();
        }
    }
}
