using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading {
    public class InheritanceTest {

        public InheritanceTest() {
            Animal a = new Dog();
            method(a);
        }

        private void method(Animal a) {
            Console.WriteLine("Animal");
        }

        private void method(Dog d) {
            Console.WriteLine("Dog");
        }

        private void method(Object o) {
            Console.WriteLine("Object");
        }

        //The override only works if in-parameters are different, return value does not matter
        //private int method(Object o) {
        //    Console.WriteLine("Object");
        //    return 0;
        //}


    }
}
