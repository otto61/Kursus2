using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDyr
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Hund h = new Hund();
            h.Navn = "Fido";
            Kat k  = new Kat();
            k.Navn = "Sorte";

            Console.WriteLine(h);
            h.SigNoget();

            Console.WriteLine(k);
            k.SigNoget();


            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }

        }
    }
    class Dyr
    {
        public string Navn { get; set; }
         public void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder " + Navn);
        }
    }
    class Hund : Dyr
    {
        public void SigNoget()
        {

            Console.WriteLine("Jeg er en hund og hedder " + Navn);
        }
    }

    class Kat : Dyr
    {

        public void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + Navn);
        }
    }



}
