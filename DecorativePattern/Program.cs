using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorativePattern {
    class Program {

        /// <summary>
        /// Example of use of this pattern, is then the component is Sandiwsh, and all the decorators are diff toppings
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            ConcreteComponent  c  = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.ReadKey();
        }
    }
}
