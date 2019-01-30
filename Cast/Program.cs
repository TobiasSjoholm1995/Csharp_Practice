using System;

namespace Practice.Casting {
    class Program {

        static void Main(string[] args) {
            integerTest();
            nullTest();
            Console.ReadKey();
        }

        private static void integerTest() {
            Console.WriteLine("Casting object to int");
            int x = 5;
            explicitCast(x);
            asCast(x);
        }

        private static void nullTest() {
            Console.WriteLine(Environment.NewLine + "Casting object to Null-pointer:");
            object x = null;

            explicitCast(x);
            asCast(x);
        }

        private static void explicitCast(Object o) {
            try {
                string s = (string)o;   //this will crash it if not a string
                if (s == null)
                    Console.WriteLine("\tExplicit cast --> null");
                else
                    Console.WriteLine("\t" + s);
            }
            catch { Console.WriteLine("\tExplicit cast  --> Crash"); }
        }

        private static void asCast(Object o) {
            string s = o as string;   // this will return null of its not a string
            if (s == null)
                Console.WriteLine("\tas cast --> null");
            else
                Console.WriteLine("\t" + s);
        }

    }
}
