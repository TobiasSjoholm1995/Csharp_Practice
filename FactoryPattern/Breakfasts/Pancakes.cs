using System;

namespace FactoryPattern.Breakfast {
    public class Pancakes : iBreakfast {
        public int CookTime { get; }

        public Pancakes() {
            CookTime = 10;
        }

        public string GetFood() => "Pancakes";
    }
}
