using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter {

    /// <summary>
    /// The in keyword is used in four contexts:
    /// 1. generic type parameters in generic interfaces and delegates.
    /// 2. As a parameter modifier, which lets you pass an argument to a method by readonly reference rather than by value.
    /// 3. foreach statements.
    /// 4. LINQ query expressions.
    /// </summary>


    //notice the class name, 'in' is a keyword
    class @in {

        /// <summary>
        /// I see no reason why 'in' parameter would ever be used like this
        /// Normal ref is pass by value, so assigning it a new value does not impact original reference
        /// </summary>
        /// 
        public @in() {
            Console.WriteLine("Test of the keyword: in");
            parameterObject o = new parameterObject(1);
            method2(in o);
            Console.WriteLine("\t" + o.Value);
        }

        //pass by readonly Reference
        private void method2(in parameterObject o) {
            //o = new parameterObject(2);    //not possible readonly
            o.Value = 2;    
        }

    }
}
