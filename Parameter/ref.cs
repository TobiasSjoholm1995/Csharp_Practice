using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {
    class @ref {


        public @ref() {
            Console.WriteLine("Test of keyword: ref");

            parameterObject o = new parameterObject(1);
            Console.WriteLine("\tValue = " + o.Value);
            newObject(ref o);
            Console.WriteLine("\tValue = " + o.Value);
        }


        private void newObject(ref parameterObject o) {
            //this dos impact the original reference, cuz this is the origal ref 
            o = new parameterObject(2);
        }
    }
}
