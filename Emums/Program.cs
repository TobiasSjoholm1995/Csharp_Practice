using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emums {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Value 0, name = " + MyEnum.Value0);
            Console.WriteLine("Value 0, value = " + (int)MyEnum.Value0);
            Console.WriteLine("Value 5, value = " + (int)MyEnum2.Value5);
            Console.WriteLine("Value 6, value = " + (int)MyEnum2.Value6);
            Console.WriteLine("Range, Max value = " +  (long)MyRange.Max + ", Min value = " + (long)MyRange.Min);

            Console.ReadKey();
        }

    }
}
