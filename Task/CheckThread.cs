using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks {
    class CheckThread {

        public CheckThread() {
            Console.WriteLine("Application thread ID: " + Thread.CurrentThread.ManagedThreadId.ToString());

            Task.Run(() => { Console.WriteLine("Task thread ID: {0}", Thread.CurrentThread.ManagedThreadId); }).Wait();
        }
    }
}
