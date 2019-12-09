using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class GenericContainer<T> : IGenericContainer<T> {

        public T Value { get; set; }

        public void Add(T value) {
            Value = value;
        }

        public T Get() {
            return Value;
        }

    }
}
