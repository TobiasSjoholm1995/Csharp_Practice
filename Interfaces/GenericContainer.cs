using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class GenericContainer : IGenericContainer<MyObject> {

        public MyObject Value { get; set; }

        public void Add(MyObject value) {
            Value = value;
        }

        public MyObject Get() {
            return Value;
        }

    }
}
