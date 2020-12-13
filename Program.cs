using System.Xml;
using System.Reflection;
using System;
using System.Diagnostics;


namespace AntiFiddler
{
    class Program {

        public static void Main()
        {
            Process collection = Process.GetProcesses();
            foreach (Process process in collection)
            {
                if (process.ProcessName.Contains("fiddler"))
                {
                    System.Environment.Exit(0);
                    break;
                }

            }
        }

    }
}
