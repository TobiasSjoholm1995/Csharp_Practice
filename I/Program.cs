using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace I {
   
    // Interface Segregation Principle (ISP), states that no client should 
    // be forced to depend on methods it does not use

    // Create thin and high cohesive interfaces
    // Often leads to multiple interfaces

    // LSP and ISP has the same fundamental idea, 
    // LSP focus on inheritance
    // ISP focus on interfaces
    // Inheritance and Composition with interfaces are the 2 ways OO system are constructed

    interface IAnimal {
        int Age { get; set; }
        void Walk();
    }

    class Fish : IAnimal {
        public int Age { get; set; }

        public void Walk() {
            // No implementation, cuz fish cant walk
            // An empty implementation of an interface method is a code smell
        }
    }
}
