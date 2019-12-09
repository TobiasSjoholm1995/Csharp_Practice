using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperators {
    public class Complement {

        public Complement() {
            Console.WriteLine(Environment.NewLine + "Complement: ");
                                     // a int has 32 bit,but for simplicity
            Console.WriteLine(~-1);  // ~1111_1111  = 0000_0000  = (0 decimal)
            Console.WriteLine(~0);   // ~0000_0000  = 1111_1111  = (-1 decimal)
            Console.WriteLine(~1);   // ~0000_0001  = 1111_1110  = (-2 decimal)
            Console.WriteLine(~2);   // ~0000_0010  = 1111_1101  = (-3 decimal)
        }

    }
}
