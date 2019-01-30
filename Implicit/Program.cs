using System;
using Practice.Explicit;  //project dependency
//add project as reference
//fix build order, automatic in most cases

namespace Practice.Implicit {
    class Program {
        static void Main(string[] args) {
            var m = new Meter() { Distance = 1 };
            Yard y = m;  //implicit         

            Console.WriteLine("Meter = " + m.Distance);          
            Console.WriteLine("Yard = " + y.Distance);      

            Console.ReadKey();
        }
    }
}
