using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    //A class or interface can inherent from multiple interfaces
    //dummy class
    class MultiInheritance : IMultiInheritance<MyObject>, IContainer  {

        public int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(MyObject value) {
            throw new NotImplementedException();
        }

        public void Add(int value) {
            throw new NotImplementedException();
        }

        public MyObject Get() {
            throw new NotImplementedException();
        }

        public void reset(MyObject value) {
            throw new NotImplementedException();
        }

        int IContainer.Get() {
            throw new NotImplementedException();
        }
    }
}
