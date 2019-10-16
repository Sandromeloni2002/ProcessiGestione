using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessiGestione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione");

            Process.Start("notepad.exe");
            Process.Start("notepad.exe", @"file\helloworld.txt");

            Process.Start("Chrome.exe", @"https://www.google.it/");

            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Desktop\ProcessiGestione\helloworld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            app.WaitForExit();

            var processes = Process.GetProcesses();
            foreach (var p in processes)
            {
                if (p.ProcessName=="notepad")
                {
                    p.Kill();
                }
            }
            Console.WriteLine("Programma terminato!");
            Console.ReadLine();
        }
    }
}
