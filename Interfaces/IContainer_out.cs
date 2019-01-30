using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {

    //Covarient interface, T can only be used as return type
    interface IContainer_out<out T> {

        //T Value { get; set; }   not poss

        //void Add(T value);     //not poss

        T Get();
    }
}
