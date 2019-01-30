using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    interface IMultiInheritance<T> : IContainer_in<T>, IContainer_out<T> {

        void reset(T value);
    }
}
