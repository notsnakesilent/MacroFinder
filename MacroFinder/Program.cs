using System;
using System.IO;
using System.Threading;

namespace MacroFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scan Started... Please Wait");
            Console.WriteLine("");
            Console.WriteLine("");

            if (File.Exists(Environment.SpecialFolder.LocalApplicationData + "/LGHUB/settings.db"))
            {
                Console.WriteLine("Logitech mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.LocalApplicationData + "LGHUB/settings.db"));
                Console.WriteLine("");
            }

            if (Directory.Exists(Environment.SpecialFolder.ApplicationData + "/BYCOMBO-2/mac"))
            {
                Console.WriteLine("Glorious mouse detected , Config folder Modified at: " + Directory.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "/BYCOMBO-2/mac"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE/config.cuecfg"))
            {
                Console.WriteLine("Corsair (CUE) mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "/corsair/CUE/config.cuecfg"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE4/config.cuecfg"))
            {
                Console.WriteLine("Corsair (CUE4) mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "/corsair/CUE4/config.cuecfg"));
                Console.WriteLine("");
            }
            
            if (Directory.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE4/Profiles"))
            {
                Console.WriteLine("Corsair (CUE4) mouse detected , Config folder Modified at: " + Directory.GetLastWriteTime(Directory.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE4/Profiles"));
                Console.WriteLine("");
            }
                                  
            if (Directory.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE/Profiles"))
            {
                Console.WriteLine("Corsair (CUE) mouse detected , Config folder Modified at: " + Directory.GetLastWriteTime(Directory.Exists(Environment.SpecialFolder.ApplicationData + "/corsair/CUE/Profiles"));
                Console.WriteLine("");
            }
            if (File.Exists(Environment.SpecialFolder.ProgramFilesX86 + "/Bloody7/Bloody7/UserLog/Mouse/TLcir_9EFF3FF4/language/Settings/EnvironmentVar.ini"))
            {
                Console.WriteLine("Bloody mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ProgramFilesX86 + "/Bloody7/Bloody7/UserLog/Mouse/TLcir_9EFF3FF4/language/Settings/EnvironmentVar.ini"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ApplicationData + "/steelseries-engine-3-client/Session Storage/000003.log"))
            {
                Console.WriteLine("Steelseries mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "steelseries-engine-3-client/Session Storage/000003.log"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.CommonApplicationData + "/Alienware/AlienWare Command Center/fxmetadata/.json"))
            {
                Console.WriteLine("Alienware mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.CommonApplicationData + "/Alienware/AlienWare Command Center/fxmetadata/.json"));
                Console.WriteLine("");
            }


            if (File.Exists(Environment.SpecialFolder.ProgramFiles + "/Gaming MouseV30/record.ini"))
            {
                Console.WriteLine("Motospeed mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ProgramFiles + "/Gaming MouseV30/record.ini"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ProgramFilesX86 + "/Gaming Mouse/Config.ini"))
            {
                Console.WriteLine("Marsgaming mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ProgramFilesX86 + "/Gaming Mouse/Config.ini"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.LocalApplicationData + "BY-8801-GM917-v108/curid.dtc"))
            {
                Console.WriteLine("Marsgaming mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.LocalApplicationData + "BY-8801-GM917-v108/curid.dtc"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ProgramFiles + "AYAX GamingMouse/config.bin"))
            {
                Console.WriteLine("Ayax mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ProgramFiles + "AYAX GamingMouse/config.bin"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.LocalApplicationData + "BY-COMBO/pro.dtc"))
            {
                Console.WriteLine("T16 mouse detected , Config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.LocalApplicationData + "BY-COMBO/pro.dtc"));
                Console.WriteLine("");
            }

            if (Directory.Exists(Environment.SpecialFolder.ProgramFilesX86 + "Xenon200/Configs"))
            {
                Console.WriteLine("Xenon200 mouse detected , Config folder Modified at: " + Directory.GetLastWriteTime(Environment.SpecialFolder.ProgramFilesX86 + "Xenon200/Configs"));
                Console.WriteLine("");
            }

            if (File.Exists(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/config.ini"))
            {
                Console.WriteLine("Redragon mouse detected , First config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/config.ini"));
            }

            if (File.Exists(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/macro.ini"))
            {
                Console.WriteLine("                          Second config file Modified at: " + File.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/macro.ini"));
            }

            if (Directory.Exists(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/Macro"))
            {
                Console.WriteLine("                          Folder config file Modified at: " + Directory.GetLastWriteTime(Environment.SpecialFolder.ApplicationData + "REDRAGON/GamingMouse/Macro"));
                Console.WriteLine("");
            }

            if (Directory.Exists("C:/Blackweb Gaming AP/config"))
            {
                foreach (FileInfo file in new DirectoryInfo("C:/Blackweb Gaming AP/config").GetFiles("*.MA32AIY"))
                {
                    if ((DateTime.Now - file.LastWriteTime).Hours >= 1)
                    {
                        Console.WriteLine("Blackweb mouse detected, Config file was recently modified");
                        Console.WriteLine("");
                    }


                }
            }

            Console.WriteLine("Scan Finished");
            Thread.Sleep(999999999);
        }
    }
}
