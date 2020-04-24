using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CraftServer.Other.Class
{
    public class Settings//Настройки
    {
        [JsonProperty("ipServer")]
        public string IpServer { get; set; }
        [JsonProperty("portServer")]
        public int PortServer { get; set; }
    }

    static public class SettingsManager//Управление Settings
    {
        static public Settings Load()
        {
            if (!File.Exists(Data.PathSave))
            {
                var set = new Settings()
                {
                    IpServer = "127.0.0.1",
                    PortServer = 987
                };

                Save(set);
                return set;
            }
            else
            {
                return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(Data.PathSave));
            }
        }

        static public void Save(Settings setting)
        {
            File.WriteAllText(Data.PathSave, JsonConvert.SerializeObject(setting));
        }
    }
}
