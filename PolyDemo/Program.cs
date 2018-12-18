using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    class Program
    {
        static void Main(string[] args)
        {



            //A a = new A();

            //a.Test();



            //B b = new B();

            //b.Test();





            //A aa = new B();

            //aa.Test();



            List<A> liste = new List<A>();

            liste.Add(new A());

            liste.Add(new B());

            liste.Add(new B());

            liste.Add(new B());

            liste.Add(new C());

            liste.Add(new C());

            liste.Add(new C());

            liste.Add(new A());

            foreach (var item in liste)

            {

              //  item.Test();

            }
        }
    }
    class A {
        public virtual void test()
        {
            Console.WriteLine("I A");
        }
    }
    class B :A{
        public virtual void test()
        {
            Console.WriteLine("I B");
        }
    }
    class C :A
    {
        public virtual void test()
        {
            Console.WriteLine("I C");
        }
    }

}
