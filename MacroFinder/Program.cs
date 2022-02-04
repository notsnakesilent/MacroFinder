using System;
using System.IO;
using System.Threading;

namespace MacroFinder
{
    internal class Program
    {
        public Program()
        {
        }

        private static void Main(string[] args)
        {
            Environment.SpecialFolder specialFolder;
            DateTime lastWriteTime;
            Console.WriteLine("Scan Started... Please Wait");
            Console.WriteLine("");
            Console.WriteLine("");
            if (File.Exists(string.Concat(Environment.SpecialFolder.LocalApplicationData.ToString(), "/LGHUB/settings.db")))
            {
                specialFolder = Environment.SpecialFolder.LocalApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "LGHUB/settings.db"));
                Console.WriteLine(string.Concat("Logitech mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (Directory.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/BYCOMBO-2/mac")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = Directory.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/BYCOMBO-2/mac"));
                Console.WriteLine(string.Concat("Glorious mouse detected , Config folder Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/corsair/CUE/config.cuecfg")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/corsair/CUE/config.cuecfg"));
                Console.WriteLine(string.Concat("Corsair (CUE) mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/corsair/CUE4/config.cuecfg")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/corsair/CUE4/config.cuecfg"));
                Console.WriteLine(string.Concat("Corsair (CUE4) mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (Directory.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/corsair/CUE4/Profiles")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = Directory.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/corsair/CUE4/Profiles"));
                Console.WriteLine(string.Concat("Corsair (CUE4) mouse detected , Config folder Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (Directory.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/corsair/CUE/Profiles")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = Directory.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/corsair/CUE/Profiles"));
                Console.WriteLine(string.Concat("Corsair (CUE) mouse detected , Config folder Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ProgramFilesX86.ToString(), "/Bloody7/Bloody7/UserLog/Mouse/TLcir_9EFF3FF4/language/Settings/EnvironmentVar.ini")))
            {
                specialFolder = Environment.SpecialFolder.ProgramFilesX86;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/Bloody7/Bloody7/UserLog/Mouse/TLcir_9EFF3FF4/language/Settings/EnvironmentVar.ini"));
                Console.WriteLine(string.Concat("Bloody mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "/steelseries-engine-3-client/Session Storage/000003.log")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "steelseries-engine-3-client/Session Storage/000003.log"));
                Console.WriteLine(string.Concat("Steelseries mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.CommonApplicationData.ToString(), "/Alienware/AlienWare Command Center/fxmetadata/.json")))
            {
                specialFolder = Environment.SpecialFolder.CommonApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/Alienware/AlienWare Command Center/fxmetadata/.json"));
                Console.WriteLine(string.Concat("Alienware mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ProgramFiles.ToString(), "/Gaming MouseV30/record.ini")))
            {
                specialFolder = Environment.SpecialFolder.ProgramFiles;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/Gaming MouseV30/record.ini"));
                Console.WriteLine(string.Concat("Motospeed mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ProgramFilesX86.ToString(), "/Gaming Mouse/Config.ini")))
            {
                specialFolder = Environment.SpecialFolder.ProgramFilesX86;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "/Gaming Mouse/Config.ini"));
                Console.WriteLine(string.Concat("Marsgaming mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.LocalApplicationData.ToString(), "BY-8801-GM917-v108/curid.dtc")))
            {
                specialFolder = Environment.SpecialFolder.LocalApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "BY-8801-GM917-v108/curid.dtc"));
                Console.WriteLine(string.Concat("Marsgaming mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ProgramFiles.ToString(), "AYAX GamingMouse/config.bin")))
            {
                specialFolder = Environment.SpecialFolder.ProgramFiles;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "AYAX GamingMouse/config.bin"));
                Console.WriteLine(string.Concat("Ayax mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.LocalApplicationData.ToString(), "BY-COMBO/pro.dtc")))
            {
                specialFolder = Environment.SpecialFolder.LocalApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "BY-COMBO/pro.dtc"));
                Console.WriteLine(string.Concat("T16 mouse detected , Config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (Directory.Exists(string.Concat(Environment.SpecialFolder.ProgramFilesX86.ToString(), "Xenon200/Configs")))
            {
                specialFolder = Environment.SpecialFolder.ProgramFilesX86;
                lastWriteTime = Directory.GetLastWriteTime(string.Concat(specialFolder.ToString(), "Xenon200/Configs"));
                Console.WriteLine(string.Concat("Xenon200 mouse detected , Config folder Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "REDRAGON/GamingMouse/config.ini")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "REDRAGON/GamingMouse/config.ini"));
                Console.WriteLine(string.Concat("Redragon mouse detected , First config file Modified at: ", lastWriteTime.ToString()));
            }
            if (File.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "REDRAGON/GamingMouse/macro.ini")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = File.GetLastWriteTime(string.Concat(specialFolder.ToString(), "REDRAGON/GamingMouse/macro.ini"));
                Console.WriteLine(string.Concat("                          Second config file Modified at: ", lastWriteTime.ToString()));
            }
            if (Directory.Exists(string.Concat(Environment.SpecialFolder.ApplicationData.ToString(), "REDRAGON/GamingMouse/Macro")))
            {
                specialFolder = Environment.SpecialFolder.ApplicationData;
                lastWriteTime = Directory.GetLastWriteTime(string.Concat(specialFolder.ToString(), "REDRAGON/GamingMouse/Macro"));
                Console.WriteLine(string.Concat("                          Folder config file Modified at: ", lastWriteTime.ToString()));
                Console.WriteLine("");
            }
            if (Directory.Exists("C:/Blackweb Gaming AP/config"))
            {
                FileInfo[] files = (new DirectoryInfo("C:/Blackweb Gaming AP/config")).GetFiles("*.MA32AIY");
                for (int i = 0; i < (int)files.Length; i++)
                {
                    FileInfo fileInfo = files[i];
                    if ((DateTime.Now - fileInfo.LastWriteTime).Hours >= 1)
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
