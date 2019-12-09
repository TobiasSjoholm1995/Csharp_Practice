using System;

namespace Partial {
    partial class MyClass {

        // Comment out this method and the program will still compile, method body treated as empty
        partial void myPartialMethod(String s) {
            Console.WriteLine(s);
        }
    }
}
