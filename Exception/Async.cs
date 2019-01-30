using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception {
    class Async {

        public Async() {
            Task.Factory.StartNew(() => method());
        }

        private void method() {
            try {
                throw new MyException("Hej async");
            }
            catch (MyException ex) { Console.WriteLine(ex.MyMessage); }  //catch must be in this method
        }
    }
}
