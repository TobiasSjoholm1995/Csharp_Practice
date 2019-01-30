using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cancellationtoken {
    class Program {
        static void Main(string[] args) {
            new AsyncCancel();
            Console.WriteLine(Environment.NewLine);
            new ParallelCancel();

            Console.ReadKey();
        }

  
    }
}
