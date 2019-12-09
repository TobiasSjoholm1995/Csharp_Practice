using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern {

    // Concrete implementation of Cooking
    class MicrowaveCooking {

        public void Cook(string food) {
            Console.WriteLine("\nCooking " + food + " in microwave.");
        }

    }
}
