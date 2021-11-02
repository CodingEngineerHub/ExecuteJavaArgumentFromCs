using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
// Hello World! program
namespace c_sp_java
{
    class Class1
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            //process.StandardInput.WriteLine("ipconfig");
            process.StandardInput.WriteLine((char)34 + @"C:\Program Files\Java\jdk-11.0.3\bin\javac" + (char)34 + " Main.java");
            process.StandardInput.WriteLine((char)34 + @"C:\Program Files\Java\jdk-11.0.3\bin\java" + (char)34 + " Main" + " Bekir");
            process.StandardInput.Flush();
            
            process.StandardInput.Close();
            //process.StandardInput.WriteLine(@"C:\Program Files\Java\jdk-11.0.3\bin\java Main hello");
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();


            // string quote = (char)34 + "Alive" + (char)34 + ", she cried!";
            // System.Console.WriteLine((char)35 + "Alive" + (char)34 + ", she cried!");
        }
    }
}
