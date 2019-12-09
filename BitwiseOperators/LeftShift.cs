using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators {
    //shift bits left and fill with zero on the right
    class LeftShift {

        public LeftShift() {
            Console.WriteLine(Environment.NewLine + "Left Shift: ");
                                         // a int has 32 bit,but for simplicity
            Console.WriteLine(1  << 1);  //  0000_0001 --> 0000_0010  = (2  decimal)
            Console.WriteLine(1  << 2);  //  0000_0010 --> 0000_0100  = (4  decimal)
            Console.WriteLine(7  << 3);  //  0000_0111 --> 0011_1000  = (56 decimal)
            Console.WriteLine(-1 << 1);  //  1111_1111 --> 111_1110   = (-2 decimal)
        }
    }
}
