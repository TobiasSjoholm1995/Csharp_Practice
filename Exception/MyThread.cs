using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exception {
    class MyThread {

        public MyThread() {
            new Thread(() => method()).Start();
        }

        private void method() {
            try {
                throw new MyException("Hej thread");
            }
            catch (MyException ex) { Console.WriteLine(ex.MyMessage); }  //catching must be in this method
        }
    }
}
