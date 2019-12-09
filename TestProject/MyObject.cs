using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestProject {
    public class MyObject {
        public int Value { get; set; }

        public MyObject(int defaultValue) {
            Value = defaultValue;
        }

        public bool IsValueSubset(params int[] values) {
            return values.Contains(Value);
        }

        private int myPrivateMethod(int x) {
            return x;
        }

        public virtual bool NotImplemented() {
            throw new NotImplementedException();
        }
    }
}
