using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillViz64Bit
{
    class Program
    {
        static string[] killViz = new string[] { "viz", "VizGui" };

        static void Main(string[] args)
        {
            foreach (var viz in killViz)
            {
                Process[] processNames = Process.GetProcessesByName(viz).ToArray();

                // kill viz
                foreach (Process process in processNames)
                {
                    //uncomment for testing
                    //Console.WriteLine(process);
                    process.Kill();
                }
            }
            //uncomment for testing
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }
    }
}
