using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception {
    class Normal {

        public Normal() {
            try {
                method();
            }
            catch(MyException ex) { Console.WriteLine(ex.MyMessage); }
        }

        private void method() {
            throw new MyException("Hej Normal");
        }
    }
}
