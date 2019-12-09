using System;

namespace O {

    // Open Closed Principle (OCP), Software entities(classes, modules, functions, etc.) 
    // should be open for extension, but closed for modification.

    // Classes that have clients should never be changed in order to add/change behaviour
    // they should instead be inherite from to add new behaviour

    class Rectangle  {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    class Circle {
        public int Radius { get; set; }
    }

    class Program {

        public double Area(object shape) {
            double area = 0;

            // Big Switch cases or many if-else cases are a code smell
            // If a new type was added, this method needs to be modified (violation)
            if (shape is Circle)
                area = Math.Pow((shape as Circle).Radius, 2) * Math.PI;
            else if (shape is Rectangle)
                area = (shape as Rectangle).Width * (shape as Rectangle).Height;

            return area;
        }
    }
}
