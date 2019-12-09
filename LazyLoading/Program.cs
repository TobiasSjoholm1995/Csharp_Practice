using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading {
    class Program {
        static void Main(string[] args) {
            var l = new LazyClass();

            l.Create();

            Console.ReadKey();
        }
    }
}
