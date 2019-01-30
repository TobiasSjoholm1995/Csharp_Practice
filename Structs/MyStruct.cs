using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs {

    public struct MyStruct {

        public int Value { get; set; }

        public MyStruct(int x) {
            Value = x;
        }

        public void Reset() {
            Value = 0;
        }

    }
}