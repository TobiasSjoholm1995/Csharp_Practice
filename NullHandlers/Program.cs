using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullHandlers {
    class Program {
        static void Main(string[] args) {

            MyObject o = null;

            //null-coalescing operator
            MyObject o2 = o ?? new MyObject();  //if o is null, it returns a new instance


            //null conditional member access
            var isNull = o?.MyProperty;   // it does not crash it just evaluate the expression to null


            //ternary conditional operator  (conditional operator)
            int x = (o2.MyProperty == 0) ? 1 : 2;
            Console.WriteLine(x);


            Console.ReadKey();
        }
    }
}
