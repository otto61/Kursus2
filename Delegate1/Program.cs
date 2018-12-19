using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{

   // public delegate void MinDelegate1(string s);
    class Program
    {
        static void Main(string[] args)
        {


            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);

            Action<string> f1 = (MinSkrivTilConsole);

            f1.Invoke("test");


            // MinDelegate1 f2 = MinSkrivTilConsole;
            Action<string> f2 = MinSkrivTilConsole;

            f2("test2");

            //MinDelegate1 f3 = MinSkrivTilConsole;
            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");


            f3-= Console.WriteLine;
            f3("test4");
            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;

            f2?.Invoke("null");
            


            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }


        }
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
   
}
