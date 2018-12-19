using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> n =
               new List<string>() { "as", "cd", "bse", "a44" };

            var res1 = from a in n
                       where a.Contains("a")
                       orderby a
                       select a;


            // bruges som nutidet kode
            var res2 = n.Where(i => i.Contains("a")).OrderBy(i => 1).ToList();

            /*

                        var liste = new personNuGetPackage.PersonRepositoryRandom()

                            var res3 = liste.Where(if =>if.Height > 150 && i.IsHealthy)


                            var res3 = liste.Where(i => i.Height > 150).OrderBy(i => i.Name).ThenBy(i => i.Height);

                        foreach (var item in res3)
                        {
                            Console.WriteLine(item.Name);
                        }

                        var res4 = liste.GroupBy(i => i.Gender);
                        foreach (var g in res4)
                        {
                            Console.WriteLine(g.Key);
                            foreach (var person in g)
                            {
                                Console.WriteLine("  " + person.Name);
                            }
                        }

                        var res5 = liste.Where(i => i.Height > 150).Select(i => new { i.Name, i.PersonId }).ToList();
                        */
        }
    }
}
