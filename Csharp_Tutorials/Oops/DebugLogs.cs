using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Tutorials.Oops
{
    internal class DebugLogs
    {

        public static void GetDubugLog()
        {
        string directoryPath = @"C:\Logs";
        string filePath = Path.Combine(directoryPath, "log.txt");
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.AppendAllText(filePath, "Welcome to Logger" + "\n");
        }
    }
}
