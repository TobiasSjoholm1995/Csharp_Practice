using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks {
    class Program {

        /// <summary>
        /// a task resembles a thread or ThreadPool work item, but at a higher level of abstraction
        /// a task utilizes the resources better, creating threads and stuff takes effort
        /// tasks can be handled better than threads, they can return results, wait
        /// they can  be exeucuted sequential with ContinueWith()

        /// Tasks can be used for 2 things, backend async computation, works pretty much as a new thread
        /// or i can be used to give GUI responsiveness even when doing hard work, see Project "Responsiveness"
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args) {
            new CheckThread();
            Console.WriteLine(Environment.NewLine);
            new AsyncComputation();
            Console.WriteLine(Environment.NewLine);
            new SyncTask();
            Console.WriteLine(Environment.NewLine);


           Console.ReadKey();
        }
    }
}
