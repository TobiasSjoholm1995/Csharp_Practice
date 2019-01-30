using System;

namespace Practice.Override {
    class DerivedClass : BaseClass {

        //overrriding the orignal method with a new implementation
        public override void Run() { Console.WriteLine("Derived"); }

        //new is hiding the original method, its a completely new method with the same name 
        public new void Run2() { Console.WriteLine("Derived"); }

    }
}
