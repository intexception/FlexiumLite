using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace FlexiumLite
{
    class Program
    {

        [get: System.Runtime.Versioning.UnsupportedOSPlatform("browser")]
        [set: System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static int WindowWidth { get; set; }

        static void CenterLine(string Line)
        {
            int Width = Console.BufferWidth;
            int TextWidth = Line.Length;
            Console.CursorLeft = (Width - TextWidth) / 2;
            Colorful.Console.Write(Line);
        }

        public static void prefx()
        {
            CenterLine("");
            Console.Write("{");
            Console.ForegroundColor = Color.LightPink;
            Console.Write("$");
            Console.ForegroundColor = Color.White;
            Console.Write("} ");
            
           
        }

        
        // centerin = [                                                    ]
        static void DrawText()
        {
            
        }
        static void Main(string[] args)
        {
            Console.Title = "Flexium Lite | Demo version!";
            Console.WriteLine("");
            Colorful.Console.WriteAscii(" -  Flexium LITE  -", Color.DeepPink);
            int A = 187;
            int B = 35;
            int C = 32;
            Console.WriteLine("");


            //▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

            //▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀

            Console.Write("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀", Color.White);
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀", Color.LightPink);
            Console.WriteLine("");
            Console.Write("                                                    {");
            Console.ForegroundColor = Color.DeepPink;
            Console.Write("1");
            Console.ForegroundColor = Color.DarkGray;
            Console.Write("} ");
            Console.WriteLine("FPS Booster");
           
            Console.Write("                                                    {");
            Console.ForegroundColor = Color.DeepPink;
            Console.Write("2");
            Console.ForegroundColor = Color.DarkGray;
            Console.Write("} ");
            Console.WriteLine("Internet booster");
            
           
            Console.Write("                                                    >> ");
            string opt = Console.ReadLine();

            if(opt == "1")
            {
                Regedits();
            }
            if (opt == "2")
            {
                Lol();
            }
            if (opt == "1")
            {

            }
            
        }

        static void Regedits()
        {
            File.WriteAllText(Path.GetTempPath() + "boost.bat", Properties.Resources.boost);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName =  $"{Path.GetTempPath()}\\boost.bat";
            process.StartInfo = startInfo;
            process.Start();
            CenterLine("Applied.");
            Thread.Sleep(-1);
        }
        static void Lol()
        {
            File.WriteAllText(Path.GetTempPath() + "internet.bat", Properties.Resources.internet);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = $"{Path.GetTempPath()}\\internet.bat";
            process.StartInfo = startInfo;
            process.Start();
            CenterLine("Applied.");
            Thread.Sleep(-1);
        }
    }
}
