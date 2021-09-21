using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static ScriptByteLoader.Handler.Data;

namespace ScriptByteLoader.Handler
{
    public static class SettingController
    {
        public static string SettingsBaseRaw()
        {
            JObject o = JObject.FromObject(new
            {
                DiscordPresence = true,
            });
            return o.ToString();
        }


        public static void EditSettings(string SettingValue, string JsonValue)
        {
            //JObject parse = JObject.Parse(File.ReadAllText($"{applicati}\\Settings.config"));
            JObject parse = JObject.Parse(File.ReadAllText(ConfigFile));
            parse[SettingValue] = JsonValue;
            File.WriteAllText($"{ConfigFile}", parse.ToString());
        }
    }
}
