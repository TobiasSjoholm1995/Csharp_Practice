using System;

namespace FactoryPattern.Breakfast {
    public class Oatmeal : iBreakfast {

        public int CookTime { get; }

        public Oatmeal() {
            CookTime = 5;
        }

        public string GetFood() => "Oatmeal";
    }
}
