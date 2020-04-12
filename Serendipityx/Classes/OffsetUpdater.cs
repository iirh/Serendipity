using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Serendipityx.Classes
{
    public class OffsetUpdater
    {
        public static void GetOffsetsFromFile()
        {
            string json = File.ReadAllText($@"{Application.StartupPath}\csgo.json");
            Main.O = JsonConvert.DeserializeObject<RootObject>(json);
        }
        public static void UpdateOffsets()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json"); //download json (update) from Github
            string webData = Encoding.UTF8.GetString(raw);
            File.WriteAllText($@"{Application.StartupPath}\csgo.json", webData);
            GetOffsetsFromFile();
        }
    }
}
