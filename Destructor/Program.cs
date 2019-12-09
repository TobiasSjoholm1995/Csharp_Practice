using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Destructor {
    class Program {

        //iDispoable interface is often used instead of the destructor, it gives better control when being called
        static void Main(string[] args) {
            testDispose();
        }

        static void testDispose() {
            var x = new MyDisposeClass();
            x.Dispose();
        }

        static void testDestructor() {
            new MyClass();
            Console.WriteLine("Something");
        }
    }
}
