using System;

namespace Practice.Operator {
    class Program {

        static void Main(string[] args) {
            MyObject o1 = new MyObject() { Value = 1 };
            MyObject o2 = new MyObject() { Value = 3 };

            MyObject addedObject = o1 + o2;

            Console.WriteLine(addedObject.Value);
            Console.ReadKey();
        }
    }
}
