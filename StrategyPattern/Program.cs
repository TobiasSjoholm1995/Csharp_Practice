using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What food would you like to cook?");
            var food = Console.ReadLine();

            Kitchen kitchen = new Kitchen(food);
            kitchen.SetCookStrategy(new OvenCooking());

            kitchen.Cook();
            Console.ReadKey();
        }
    }
}
