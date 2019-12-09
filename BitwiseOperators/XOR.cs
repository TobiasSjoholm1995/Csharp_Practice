using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators {
    class XOR {

        public XOR() {
            Console.WriteLine("Exclusive OR: ");
            Console.WriteLine(true  ^ true );   // output: False
            Console.WriteLine(true  ^ false);   // output: True
            Console.WriteLine(false ^ true );   // output: True
            Console.WriteLine(false ^ false);   // output: False


            Console.WriteLine(1  ^  2);        // 01 XOR 10 = 11 (3 decimal)
        }
    }
}
