using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {
    class Program {
        static void Main(string[] args) {
            new Params();
            Console.WriteLine(Environment.NewLine);
            new @in();
            Console.WriteLine(Environment.NewLine);
            new PassByValue();
            Console.WriteLine(Environment.NewLine);
            new @out();
            Console.WriteLine(Environment.NewLine);
            new @ref();
            Console.WriteLine(Environment.NewLine);

            Console.ReadKey();
        }
    }
}
