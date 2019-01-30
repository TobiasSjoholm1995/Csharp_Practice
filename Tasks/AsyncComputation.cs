using System;

using System.Threading;
using System.Threading.Tasks;

namespace Tasks {
    class AsyncComputation {

        public AsyncComputation() {
            Console.WriteLine("Test ASYNC computation");

            var task = Task.Run(() => write("async"));   //This will run as a new thread
            //var task = Task.Factory.StartNew(() => method());      //same stuff but older way of doing it

            write("ctor");

            task.Wait();
        }

        private void write(string message) {
            for(int i = 0; i < 3; i++) {
                Console.WriteLine("\t" + message);
                Thread.Sleep(500);
            }
        }


    }
}
