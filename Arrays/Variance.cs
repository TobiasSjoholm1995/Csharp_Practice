using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
    public class Animal { }
    public class Cat : Animal { }
    public class Dog : Animal { }
    public class BossDog : Dog { }

    class Variance {

        public Variance() {
            Console.WriteLine(Environment.NewLine + "Variance:");
            // Array does not use the element itself, it only returns it, therefor it can be covariance
            // An method that implement an interface, uses the element, therefor it cant be covariance. Animal cant act like a dog. 

            Animal[] a = new Dog[10];  //array of dogs, cast to animals. its still dogs ;)
            crashingMethod(a);
            a[0] = new Dog();
            a[1] = new BossDog();  //Ok, cuz BossDogs is dogs
            //a[0] = new Cat();  crash, cuz Cat can act like a Dog. Compiler don't notice this..
            //a[1] = new Animal();

            Animal k = a[0];

            Console.WriteLine(k);

        }

        void crashingMethod(Animal[] a) {
            try {
                if (a != null && a.Length > 0)
                    a[0] = new Animal();    //this can crash the code, if the array is using Covariance
            }
            catch {
                Console.WriteLine("Crash, cuz the parameter was an array of dogs. Animals cant act like dogs..");
            }
        }
    }
}
