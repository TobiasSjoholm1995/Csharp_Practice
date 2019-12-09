using System;

namespace Emums {
    //enums can not have methods or fields

    public enum MyEnum { Value0, Value1, Value2, Value3 }  //default starts with value 0

    public enum MyEnum2 { Value5 = 5, Value6, Value7 }

    public enum MyRange : long { Max = 9223372036854775807, Min = -9223372036854775808 }    //only value types

    // this attribute only overrides the ToString method, the bitwise operations are still poss without
    [Flags]
    public enum MyFlagEnum {
        Value0 = 0,    // 0000
        Value1 = 1,    // 0001
        Value2 = 2,    // 0010
        Value3 = 4     // 0100
    }                  

}
