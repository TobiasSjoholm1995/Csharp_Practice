using System;
using static Practice.Delegate.DelegateObject;

namespace Practice.Delegate {
    class Program {
        static void Main(string[] args) {
            
            DelegateObject o = new DelegateObject();
            Console.WriteLine(o.AddDelegate.Invoke(2,3));

            //this is what the "event" keyword prevent, subscribers should not impact each other
            o.AddDelegate = null;
            Console.ReadKey();
        }


    }
}
