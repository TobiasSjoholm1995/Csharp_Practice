using System;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

namespace Cancellationtoken {
    class ParallelCancel {
        private List<int> list; 
        private CancellationTokenSource cts;

        public ParallelCancel() {
            createList();
            ParallelOptions pOptions = createToken();

            new Thread(() => CancelMethod()).Start();

            try {
                //ParallelOptions does not need to be excplicity checked, just input it tos ForEach()
                Parallel.ForEach(list, pOptions, (x) => Console.WriteLine(x));
            }
            catch(OperationCanceledException ex) {
                Console.WriteLine("Catch Block");
            }
            finally {
                cts.Dispose();
            }
        }

        private void CancelMethod() {
            Thread.Sleep(50);
            cts.Cancel();
            Console.WriteLine("Cancel call made!");
        }

        private ParallelOptions createToken() {
            cts = new CancellationTokenSource();
            ParallelOptions pOptions = new ParallelOptions();
            pOptions.CancellationToken = cts.Token;
            pOptions.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            return pOptions;
        }

        private void createList() {
            list = new List<int>();

            for (int i = 0; i < 1000; i++)
                list.Add(i);
        }

    }
}
