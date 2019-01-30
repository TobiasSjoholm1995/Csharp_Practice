using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Explicit {
    public class Yard {
        public double Distance { get; set; }

        //explicit can also be used for implicit casting but not reverse
        public static explicit operator Meter(Yard m) {
            Meter y = new Meter() { Distance = m.Distance * 0.9144 };
            return y;
        }

    }
}
