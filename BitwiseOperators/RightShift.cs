using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators {
    class RightShift {

        // left bits are filled with the sign bit.
        public RightShift() {
            Console.WriteLine(Environment.NewLine + "Right Shift: ");
                                         // a int has 32 bit,but for simplicity
            Console.WriteLine(1 >> 1);   // 0000_0001 --> 0000_0000  = (0 decimal)
            Console.WriteLine(7 >> 2);   // 0000_0111 --> 0000_0001  = (3 decimal)
            Console.WriteLine(-1 >> 1);  // 1111_1111 --> 1111_1111  = (-1 decimal)
            Console.WriteLine(-3 >> 1);  // 1111_1101 --> 1111_1110  = (-2 decimal)
        }

    }
}
