using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emums {
    //enums can not have methods or fields

    public enum MyEnum { Value0, Value1, Value2, Value3 }  //default starts with value 0

    public enum MyEnum2 { Value5 = 5, Value6, Value7 }

    public enum MyRange : long { Max = 9223372036854775807, Min = -9223372036854775808 }    //only value types

}
