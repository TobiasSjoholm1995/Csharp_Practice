using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Explicit {
    class Program {
        static void Main(string[] args) {
            Yard y = new Yard() { Distance = 1 };
            Console.WriteLine("Yard = " + y.Distance);
            Console.WriteLine("Meter = " + ((Meter)y).Distance); //explicit

            Console.ReadKey();
        }
    }
}
