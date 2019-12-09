using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockingCollection {
    class Program {

        //By default, BlockingCollection use ConcurrentQueue as its collection class
        //But it has built in wait for add
        //Warning bad performance compared to doing it sequential in a list
        static void Main(string[] args) {
            new BlockingCollectionTest();
            Console.ReadKey();
        }
    }
}
