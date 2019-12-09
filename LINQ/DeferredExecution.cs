using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {

    public class DeferredExecution {

        public DeferredExecution() {
            test3();

            var numbers1 = test1();

            Console.WriteLine(numbers1.Sum());
            Console.WriteLine(numbers1.Sum());
            Console.WriteLine(numbers1.Sum());
            Console.WriteLine(numbers1.Sum());

            Console.WriteLine();
            var numbers2 = test2();

            Console.WriteLine(numbers2.Sum());
            Console.WriteLine(numbers2.Sum());
            Console.WriteLine(numbers2.Sum());
            Console.WriteLine(numbers2.Sum());
        }

        // IEnumerable has deferred execution built in
        private IEnumerable<int> test1() {
            var rand = new Random();
            return Enumerable.Range(0, 10).Select(n => rand.Next(0, 10));
        }
        private IEnumerable<int> test2() {
            var rand = new Random();
            int[] x = { 1, 2, 3, 4, 5, 6, rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10) };
            return x;
        }

        private void test3() {
            List<String> items = new List<string> { "Bob", "Alice", "Trent" };

            var results = from s in items select s;

            Console.WriteLine("Before add:");
            foreach (var result in results) {
                Console.WriteLine(result);
            }

            items.Add("Mallory");

            //  Enumerating the results again will return the new item, even
            //  though we did not re-assign the Linq expression to it!

            Console.WriteLine("\nAfter add:");
            foreach (var result in results) {
                Console.WriteLine(result);
            }
        }
    }
}
