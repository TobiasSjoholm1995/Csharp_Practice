using System;

namespace Emums {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Value 0, name  = " + MyEnum.Value0);
            Console.WriteLine("Value 0, value = " + (int)MyEnum.Value0);
            Console.WriteLine("Value 5, value = " + (int)MyEnum2.Value5);
            Console.WriteLine("Value 6, value = " + (int)MyEnum2.Value6);
            Console.WriteLine("Range, Max value = " +  (long)MyRange.Max + ", Min value = " + (long)MyRange.Min);

            flagOperations();

            Console.ReadKey();
        }

        static void flagOperations() {
            MyFlagEnum f = (MyFlagEnum.Value1 | MyFlagEnum.Value3);  // 0001 OR 0010 = 0011

            if (f.HasFlag(MyFlagEnum.Value3)) {
                Console.WriteLine(f.ToString());
                Console.WriteLine((int)f);
            }

            MyFlagEnum f2 = (f & MyFlagEnum.Value1);        // 0011 AND 0001 = 0001

            if (f2.HasFlag(MyFlagEnum.Value1)) {
                Console.WriteLine(f2.ToString());
                Console.WriteLine((int)f2);
            }
        }

    }
}
