using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Explicit {
    public class Meter {
        public double Distance { get; set; }

        //this method can be anywhere
        public static implicit operator Yard(Meter m) {
            Yard y = new Yard() { Distance = m.Distance * 1.0936133 };
            return y;
        }

    }
}
