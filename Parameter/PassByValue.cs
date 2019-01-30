using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {
    class PassByValue {

        //C# default is pass by value 
        public PassByValue() {
            Console.WriteLine("Test of Pass by value");

            parameterObject o = new parameterObject(1);
            Console.WriteLine("\tValue = " + o.Value);
            newObject(o);
            Console.WriteLine("\tValue = " + o.Value);
            changeObject(o);
            Console.WriteLine("\tValue = " + o.Value);

        }

        private void newObject(parameterObject o) {
            //this dos NOT impact the original reference
            //this is a copy of the reference
            o = new parameterObject(2);   
        }

        private void changeObject(parameterObject o) {
            //this does impact the original reference
            //this is another reference to the same object, now we change the object and not the reference
            o.Value = 2;
        }
    }
}
