using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Container : IContainer {

        public int Value { get; set; }

        public void Add(int value) {
             Value = value;
        }

        public int Get() {
            return Value;
        }

    }
}
