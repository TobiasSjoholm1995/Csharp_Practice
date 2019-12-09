using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Destructor {
    class MyClass {

        public MyClass() {
            Console.WriteLine("MyClass in created");
        }

        //Destructor, called when object is being removed 
        //this is NOT called directly after the object is out of scope
        //this is NOT being called when window is closing, dont rely on it
        ~MyClass() {
            Console.WriteLine("MyClass is destroyed");
            Console.WriteLine();
            Thread.Sleep(2000);
        }

        //GC will just call the Finalize method implicit to clean an object up, use the destructor instead of this
        /*
        public override void Finalize() {

        }
        */
    }
}
