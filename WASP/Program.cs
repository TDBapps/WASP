using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WASP;
using System.Windows.Forms;

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
                string filePath = Path.GetFullPath(args[0]);
                if (fileName == "WASP" & Extension != ".bpk")
                {
                    Global.bpk = "null";
                    Global.bpath = "null";
                    new WASP1().Show();
                    Application.Run();
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
                    Global.bpk = (fileName + Extension);
                    Global.bpath = filePath;
                    WASP1.loadWASP(fileName + Extension);
                    new WASP1().Show();
                    Application.Run();
                }
            }
        }
    }
    public static class Global
    {
        private static string _bpk;
        public static string bpk
        {
            get
            {
                return _bpk;
            }
            set
            {
                _bpk = value;
            }
        }
        private static string _bpath;
        public static string bpath
        {
            get
            {
                return _bpath;
            }
            set
            {
                _bpath = value;
            }
        }
    }
}
