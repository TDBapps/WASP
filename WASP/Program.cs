using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WASP;

namespace WASP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WASP";
            if(args.Length != -1)
            {
                string Extension = Path.GetExtension(args[0]);
                string fileName = Path.GetFileNameWithoutExtension(args[0]);
                if (fileName == "WASP" & Extension != ".bpk")
                {
                    new WASP1().Show();
                    WASP1.loadWASP("null");
                    Console.ReadLine();
                }
                else if (Extension != ".bpk")
                {
                    Console.Title = ("WASP: " + fileName + Extension);
                    Console.WriteLine("Error! File type not supported: " + Extension + "!");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Title = ("WASP: " + fileName + Extension);
                    Console.WriteLine("File accepted! Press enter to open file with WASP");
                    Console.ReadLine();
                    new WASP1().Show();
                    WASP1.loadWASP(fileName + Extension);
                    Console.ReadLine();
                }
            }
        }
    }
}
