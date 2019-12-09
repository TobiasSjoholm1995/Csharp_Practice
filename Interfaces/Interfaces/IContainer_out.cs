using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    //Covarient interface, T can only be used as return type

    // return type can be in the inheritance hierarchy
    // example, type if interface is Dog, but the method returns Animal, this is OK, cuz Dog can be implicit cast to Animal
    interface IContainer_out<out T> {

        //T Value { get; set; }   not poss

        //void Add(T value);     //not poss

        T Get();
    }
}
