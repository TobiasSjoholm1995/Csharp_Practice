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

            Task.Run(() => { Console.WriteLine("\tTask1 thread ID: {0}", Thread.CurrentThread.ManagedThreadId); });
            Task.Run(() => { Console.WriteLine("\tTask2 thread ID: {0}", Thread.CurrentThread.ManagedThreadId); }).Wait();

            Console.WriteLine();
            checkThread().Wait();
        }


        private async Task checkThread() {
            Console.WriteLine("\tTaskMethod1 thread ID: {0}", Thread.CurrentThread.ManagedThreadId);  //main app thread
            await Task.Delay(10);
            Console.WriteLine("\tTaskMethod2 thread ID: {0}", Thread.CurrentThread.ManagedThreadId);  //diff thread
        }
    }
}
