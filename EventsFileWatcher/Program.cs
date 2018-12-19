using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsFileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w =
            new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;

            w.Changed += W_Changed;

            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };

            w.Renamed += W_Renamed;
            Console.WriteLine("nu kigger vi på filer");


           
            while()

            do
            {



            } while (true);


        }

        private static void W_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            Console.WriteLine("renamed");
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }






}
