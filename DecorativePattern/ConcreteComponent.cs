using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorativePattern {
    public class ConcreteComponent : IComponent {

        public void Operation() {
            Console.WriteLine("ConcreteComponent.Operation()");
        }

    }
}
