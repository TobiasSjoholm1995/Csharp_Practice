using System;

namespace Partial {
    // Only one of the classes can have a constructor
    // partial method must return void 
    // partial method must be private
    public partial class MyClass {

        public MyClass() {
            Console.WriteLine("ctor1");
        }

        partial void myPartialMethod(string s);

        public void MyMethod() {
            myPartialMethod("test");
        }

    }
}
