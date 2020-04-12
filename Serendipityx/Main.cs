using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;
using Serendipityx.Classes;
using System.Drawing;


namespace Serendipityx
{

        public class Main
        {
            public static List<string> Configs = new List<string>();

            public static Size ScreenSize;
            public static Vector2 MidScreen;
            public static RECT ScreenRect;


            public static RootObject O;
            public static Settings S = new Settings();
            public static bool RunStartup()
            {
                var CSGO = Process.GetProcessesByName("csgo"); // get name
                if (CSGO.Length != 0)
                {
                    Memory.Process = CSGO[0];
                    Memory.ProcessHandle = Memory.OpenProcess(0x0008 | 0x0010 | 0x0020, false, Memory.Process.Id);
                    foreach (ProcessModule Module in Memory.Process.Modules)
                    {
                        if ((Module.ModuleName == "client_panorama.dll")) // get client dll
                            Memory.Client = Module.BaseAddress;

                        if ((Module.ModuleName == "engine.dll")) // get engine
                            Memory.Engine = Module.BaseAddress;
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    
}
