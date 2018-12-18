using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Hund[] hunde = new Hund[4];
                hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
                hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };

                hunde[2] = new Hund() { Alder = 10, Navn = "Bulder2" };
                hunde[3] = new Hund() { Alder = 5, Navn = "Lady2" };




            Array.Sort(hunde);
                foreach (var item in hunde)
                {
                    Console.WriteLine(item.Navn);
                }



            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }


        }
    }

        class Hund:IComparable<Hund>
        {
            public string Navn { get; set; }
            public int Alder { get; set; }

        //public int CompareTo(object obj)
        //{

        //    Hund h = obj as Hund;

        //    if (h.Alder > this.Alder)

        //        return -1;

        //    if (h.Alder < this.Alder)

        //        return 1;

        //    return 0;

        // }



        public int CompareTo(Hund h)
        {
           // Hund h = new Hund();
            if (h.Alder > this.Alder)
                return 1;
            if (h.Alder < this.Alder)
                return -1;
            
            return 0;

        }
        }
    }

