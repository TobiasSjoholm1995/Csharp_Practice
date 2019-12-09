using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic {

    public interface IAnimal { }
    public class Cat : IAnimal { }
    public class Dog : IAnimal { }
    public class BossDog : Dog { }

    class LateBinding {

        public LateBinding() {
            IAnimal[] arr = new Dog[3];  //array of dogs, cast to animals. its still dogs ;)
            arr[0] = new Dog();
            arr[1] = new BossDog();  //Ok, cuz BossDogs is dogs

            Console.WriteLine("Early binding:  (Normal)");
            foreach (var a in arr)
                ttest(a);

            // type is determine at runtime
            // compiler does not help with dynamic
            Console.WriteLine("Late binding:  (dynamic)");
            foreach (dynamic a in arr)
                ttest(a);
        }

        void ttest(IAnimal a) => Console.WriteLine("\tAnimal");
        void ttest(Dog a)     => Console.WriteLine("\tDog");
        void ttest(BossDog a) => Console.WriteLine("\tBossDog");
        void ttest(dynamic a) => Console.WriteLine("\tDynamic");

    }
}


