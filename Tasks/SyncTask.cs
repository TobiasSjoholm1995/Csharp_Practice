using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks {
    class SyncTask {

        public SyncTask() {
            Console.WriteLine("Test different ways to run a Task SYNC");

            test1();
            Console.WriteLine();
            test2();
        }

        private void test1() {
            Task.Run(() => write("Task Method1")).Wait();
            write("caller Method1");
        }

        private void test2() {
            Task task = new Task(()=> write("Task Method2"));
            task.RunSynchronously();
            write("caller Method2");
        }

        private void write(string value) {
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("\t" +value);
                Thread.Sleep(500);
            }
        }
    }
}
