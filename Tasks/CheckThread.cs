using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks {
    class CheckThread {

        public CheckThread() {
            Console.WriteLine("Test of what thread does the task execute on");
            Console.WriteLine("\tApplication thread ID: " + Thread.CurrentThread.ManagedThreadId.ToString());

            Task.Run(() => { Console.WriteLine("\tTask thread ID: {0}", Thread.CurrentThread.ManagedThreadId); }).Wait();
        }
    }
}
