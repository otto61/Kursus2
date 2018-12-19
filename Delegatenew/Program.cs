using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public delegate void Delegate1();
    public delegate void Delegate2(int a);
    public delegate int Delegate3(int a, int b);
    public delegate void Delegate4(string t);
    public delegate void DelegateVoidString(string t);
    public delegate void DelegateVoidStringString(string t, string t2);


    class Program
    {



        static void Main(string[] args)
        {

            List<string> lst = new List<string>();
            Test1();

            Delegate1 f1 = new Delegate1(Test1);
            f1.Invoke();
            MinMetode(1, 1, f1);
            Console.WriteLine();
            Test2("a");
            Test3("b");

            Console.WriteLine();

            //Delegate4 f2 = new Delegate4(Test2);
            Delegate4 f2 = Test2;
            f2 += Test3;
            f2 += Console.WriteLine;
            //f2.Invoke("c-+-c");
            f2("c-+-c");
            f2 -= Console.WriteLine;
            Console.WriteLine();
            f2.Invoke("c-+-c");

            Console.WriteLine();

            Maskine m = new Maskine();
            m.LogFunktion = new Delegate4(LogTilFil);
            m.LogFunktion += Console.WriteLine;
            m.Start();

            Console.WriteLine("------");

            Delegate4 f1a = new Delegate4(Test2);
            f1a("");

            Delegate4 f2a = Test2;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a("*****");
            //foreach (var item in f2a.GetInvocationList())
            //{
            //    item.DynamicInvoke();
            //}

            //Action    void (..)
            //Func      (..) (..)
            //(Predicate)

            Delegate1 a1_1 = Test1;
            a1_1.Invoke();
            a1_1();

            Action a1_2 = Test1;
            a1_2.Invoke();
            a1_2();


            Action<string> a2 = Console.WriteLine;
            a2("***");

            Action<string, int, bool> a3;

            Func<bool> b1;
            Func<int, bool> b2;
            Func<bool, int, int, double> b3;

            Action<int, bool, List<string>> t;


            //Action<string> ff = Test3;

            // Lambda (anonym)
            Action<string> q = (string x) =>
            {
                Console.WriteLine("*** " + x);
            };

            //Action<int, bool> w = (int a, bool b) => {

            //};

            Action<int, bool> w = (a, b) => {

            };

            Action<string> å = h => {
                Console.WriteLine(h);
            };

            Action<string> ll = h => Console.WriteLine(h);



            Func<int, int, bool> z = (int a, int b) => {
                return a == b;
            };

            Func<int, int, bool> zz = (a, b) => {
                return a == b;
            };

            Func<int, int, bool> zzz = (int a, int b) => { return a == b; };

            int[] rr = { 5, 1, 47, 1, 156, 5 };
            //var res = rr.Where((i) => { return i < 10; });
            // LINQ
            var res = rr.Where(i => i < 10).OrderBy(i => i);



            q("kfjbdfkjhdkfh");

            w(1, true);


            if (System.Diagnostics.Debugger.IsAttached)

            {

                Console.Write("Press any key to continue . . . ");

                Console.ReadKey();

            }


        }

        static bool ErMindre(int i)
        {
            return i < 10;
        }

        static void LogTilFil(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt);
        }

        static void Test2(string txt)
        {
            Console.WriteLine("I test2 " + txt);
        }

        static void Test3(string txt)
        {
            Console.WriteLine("I test3 ***** " + txt);
        }

        static void MinMetode(int a, int b, Delegate1 done)
        {
            // gør noget med a og b
            //done.Invoke();
            if (done != null)
                done.Invoke();

        }

        static void Test1()
        {
            Console.WriteLine("I Test1");
        }
    }

    class Maskine
    {
        public Delegate4 LogFunktion;
        public void Start()
        {
            if (LogFunktion != null)
                LogFunktion.Invoke("Starter maskine");
            // starter...
            if (LogFunktion != null)
                LogFunktion.Invoke("Maskine startet");
        }
    }

    class A
    {
        public void Test() { }
    }
}
