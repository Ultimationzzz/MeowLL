using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MeowLL
{
    public class Settings
    {
        public string PhoneIp { get; set; } = "127.0.0.1";
        public string MeowListenIp { get; set; } = "127.0.0.1";
        public int MeowListenPort { get; set; } = 49983;

        public string LiveLinkIp { get; set; } = "127.0.0.1";
        public int LiveLinkPort { get; set; } = 11111;

        public bool TrackFacial { get; set; } = true;
        public bool TrackHead { get; set; } = true;
        public static Settings Instance { get; set; } = new ();
        public float EyeSensitivity { get; set; } = 1.0f;
        public float HeadSensitivity { get; set; } = 1.0f;  
        public static void Load()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            if (File.Exists(path))
            {
                try
                {
                    var data = File.ReadAllText(path);
                    Instance = JsonConvert.DeserializeObject<Settings>(data);
                }
                catch (Exception)
                {
                    //ignore
                }
            }
        }
        public static void Save()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            File.WriteAllText(path,JsonConvert.SerializeObject(Instance,Formatting.Indented));
        }
    }
}
