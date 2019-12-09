using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading {
    class ConvertTest {
        public ConvertTest() {
            long x = 100000;
            method(x);
        }

        private void method(int x) {
            Console.WriteLine("int");
        }


        private void method(object x) {
            Console.WriteLine("object");
        }
    }


}
