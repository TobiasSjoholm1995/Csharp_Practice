using System;

namespace Partial {

    // partial is Contextual keyword
    // you can still name a variable the same as a partial keyowrd
    // a contextual keyword can mean diff things in diff context
    class Program {
        static void Main(string[] args) {
            MyClass partial = new MyClass();
            partial.MyMethod();

            Console.ReadKey();
        }
    }
}
