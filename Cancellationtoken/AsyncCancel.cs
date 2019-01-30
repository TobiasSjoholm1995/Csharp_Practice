using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cancellationtoken {
    class AsyncCancel {
        private CancellationTokenSource tokenSource;

        public AsyncCancel() {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            //input task in the StartNew method, why --> if token is already canceled
            //check inside the task if its cancel
            Task.Factory.StartNew(() => TaskMethod(token), token);  

            Thread.Sleep(50);
            tokenSource.Cancel();
            Console.WriteLine("Token cancel");

            Thread.Sleep(1000);
            tokenSource.Dispose();
        }

        private static void TaskMethod(CancellationToken token) {
            int i = 0;
            while (true) {
                if (token.IsCancellationRequested)
                    return;    
                Console.WriteLine(i++);
                Thread.Sleep(10);
            }
        }
    }
}
