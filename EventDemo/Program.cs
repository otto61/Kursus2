using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // System.Timers.Timer t = new System.Timers.Timer();
            // t.Enabled = true;
            // t.Interval = 2000;            
            // t.Elapsed += (s, e) => Console.WriteLine("Tick");
            // t.Elapsed += (s, e) => Console.WriteLine("Tick Tick");

            //System.IO.FileSystemWatcher fs = 
            //    new System.IO.FileSystemWatcher(@"c:\temp");
            //fs.EnableRaisingEvents = true;
            //fs.Created += (s, e) => {
            //    Console.WriteLine("oprettet " +e.Name);
            //};

            //fs.Deleted += (s, e) => {
            //    Console.WriteLine("delete " + e.Name);
            //};



            //do
            //{

            //} while (true);

            Hund h = new Hund();
            h.BenMistet += (s, e) =>
            {
                Console.WriteLine("UPS ");
            };
            h.BenMistet += (s, e) =>
            {
                Console.WriteLine("RINGER");
            };
            Console.WriteLine(h.AntalBen);
            h.TabBen();
            Console.WriteLine(h.AntalBen);


        }


    }

    class Hund
    {

        public event EventHandler BenMistet;

        public string Navn { get; set; }
        public int AntalBen { get; set; } = 4;

        public void TabBen()
        {
            AntalBen--;
            //if(BenMistet!=null)
            //    BenMistet.Invoke();
            BenMistet?.Invoke(this, new EventArgs());
        }


    }


}
