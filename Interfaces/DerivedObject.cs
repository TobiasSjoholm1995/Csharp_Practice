using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    //inherent from a class and from the interfaces
    class DerivedObject : MyObject, IContainerLimitation<DerivedObject> {

        DerivedObject IContainerLimitation<DerivedObject>.Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(DerivedObject value) {
            throw new NotImplementedException();
        }

        public DerivedObject Get() {
            throw new NotImplementedException();
        }
    }
}
