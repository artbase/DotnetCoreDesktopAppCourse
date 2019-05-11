using System;
using Gtk;

namespace ApplicationGTK
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.Init();
            var window = new Window();

            window.Title = "Dotnet Core - Window";
            window.Maximize();
            window.Show();
            
            Application.Run();
            Console.WriteLine("Hello World!");
        }
    }
}
