using System;

namespace Good {
    
    interface IShape {
        double Area();
    }

    class Rectangle : IShape {
        public double Area() {
            return 0; // implement area
        }
    }

    class Circle :IShape {
        public double Area() {
            return 0, // implement area
        }
    }

    class Program {

        //If a new shape have to be added, this method will remain the same
        public double Area(IShape shape) {
            return shape.Area();
        }
    }
}
