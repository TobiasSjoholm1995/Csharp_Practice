using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Destructor {
    class MyDisposeClass : IDisposable {
        private bool disposed = false;

        public void Dispose() {
            Dispose(true);
            // This object will be cleaned up by the Dispose method.
            // Therefore, you should call GC.SupressFinalize to
            // take this object off the finalization queue
            // and prevent finalization code for this object
            // from executing a second time.
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios.
        // If disposing equals true, the method has been called directly by user. Managed and unmanaged resources can be disposed.
        // If disposing equals false, the method has been called by the runtime from inside the finalizer and you should not reference.
        // other objects. Only unmanaged resources can be disposed.
        protected virtual void Dispose(bool disposing) {
            Console.WriteLine("Disposing");
            if (!this.disposed) {
                if (disposing) {
                    Console.WriteLine("Disposing manage resources");
                }
                Console.WriteLine("Disposing unmanage resources");
                Thread.Sleep(1000);
                disposed = true;
            }
        }

        ~MyDisposeClass() {
            Dispose(false);
        }

    }
}
