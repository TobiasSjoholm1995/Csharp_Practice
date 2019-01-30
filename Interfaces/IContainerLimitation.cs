using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    //limit the use of the generic type to the object MyObject, or any class that dervies from it
    interface IContainerLimitation<T> where T : MyObject {

        T Value { get; set; }

        void Add(T value);

        T Get();

    }
}
