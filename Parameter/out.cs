using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {
    class @out {

        public @out() {
            Console.WriteLine("Test of keyword: out");

            parameterObject o;  //pointless to assig, only declare
            method(out o);

            Console.WriteLine("\tValue = " + o.Value.ToString());
        }

        private void method(out parameterObject o) {
            o = new parameterObject(2);  //must assign it
        }
    }
}
