using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObject
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);
            foreach (var person in people)
                Console.WriteLine(person.Name);


            Console.WriteLine("---------------------");


            var res3 = people.Where(i => i.Height > 180).OrderBy(i => i.Name).ThenBy(i => i.Height);
            foreach (var item in res3)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("---------------------");

            var res4 = people.Take(10).Where(i => i.Height > 150).OrderBy(i => i.Name).ThenBy(i => i.Height);
            foreach (var item in res4)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("---------------------");

            var res5 = people.Where(i => i.Height < 170).OrderBy(i => i.Name).ThenBy(i => i.Height);
            foreach (var item in res5)
            {
                Console.WriteLine(item.Name);
            }
            
            Console.WriteLine("---------------------");
            var res6 = people.Where(i => i.Height < 170 && i.IsHealthy == true).OrderBy(i => i.Name).ThenBy(i => i.Height);
            foreach (var item in res6)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("---------7------------");
            var res7 = people.GroupBy(i => i.Gender);
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key );
                foreach (var person in group)
                {
                    Console.WriteLine(" =>" + person.Name + " " + person.Gender);

                }



            }
            Console.WriteLine("-----------8----------");
            int[] range = { 160, 170, 180, 190, 200, 210, 220 };
            var res8 = people.OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x> i.Height));
            foreach (var group in res8)
            {
                Console.WriteLine(group.Key);

                foreach (var person in group)
                {
                    Console.WriteLine(" =>" + person.Name + " " + person.Height);
                }
            }





            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }
        }
    }
}
