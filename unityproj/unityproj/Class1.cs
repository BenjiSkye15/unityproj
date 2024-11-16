using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Win32;

namespace unityproj_Open
{
    internal class Class1
    {
        public static string dir = Environment.CurrentDirectory;
        public static string verisonDir;
        public static string[] versionContents;
        public static string versionLine;
        public static string version;
        public static string installOfUnity;
        public static string bit;

        public static void Main()
        {
            if (Environment.Is64BitOperatingSystem) { bit = "x64"; } else { bit = "32"; }
            verisonDir = dir + "\\ProjectSettings\\ProjectVersion.txt";
            versionContents = System.IO.File.ReadAllLines(verisonDir);
            versionLine = versionContents[0];
            version = versionLine.Remove(0, 17);
            // never use HKCU or the other ones use HKEY_CURRENT_USER or the other ones
            installOfUnity = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Unity Technologies\\Installer\\Unity " + version, "Location " + bit, null);

            System.Diagnostics.Process.Start(installOfUnity + "\\Editor\\Unity.exe", "openProject \"" + dir + "\"");
        }
    }
}
