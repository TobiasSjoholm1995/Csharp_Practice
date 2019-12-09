using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    // contravariant  interface, T can only used as a argument not as a return type
    interface IContainer_in<in T>{

        //T Value { get; set; }    //not allowed

        void Add(T value);

        //T Get();      //not allowed

    }
}
