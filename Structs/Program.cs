using System;

namespace Structs {

    /// <summary>
    /// A struct is like a class but its a value type
    /// all primitiv types, example int, long, double, etc. They are all structs
    /// </summary>
    class Program {

        static void Main(string[] args) {
            MyStruct s = new MyStruct(2);

            System.Console.WriteLine(s.Value);
            method(s);
            System.Console.WriteLine(s.Value);    //value is still 2, cuz struct is a value type

            Console.ReadKey();

        }

        // Both object and structs are passed by value
        // With an object you pass a copy of the reference which reference the same object, 
        /// so you can change the object itself but not the original ref
        /// With a struct you pass a copy of the values to the method, nothing can be changed.
        private static void method(MyStruct s) {
            s.Value = 5;
        }

    }

}
