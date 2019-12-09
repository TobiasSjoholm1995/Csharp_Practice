using System;

namespace FactoryPattern.Breakfast {
    public interface iBreakfast {

        string GetFood();

        int CookTime { get; }
    }
}
