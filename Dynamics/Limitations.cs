using Microsoft.CSharp.RuntimeBinder;
using System;

namespace Dynamic {
    //Dynamics can use extension methods in the normal way
    class Limitations {

        public Limitations() {
            Console.WriteLine("Limitations: ");
            string s = "Tobbe";
            s.WriteHello();

            dynamic d = s;
            //d.WriteHello();  //this will thow a runtime bind exception
            Ext.WriteHello(d);  //this is still poss, call it like a normal static method
        }

        void test() {
            try {
                dynamic d = "test";
                d.YouCanCallAnyMethodItWillCompileButThrowAnException();
            }
            catch (RuntimeBinderException) { }
        }
    }

    public static class Ext {
        public static void WriteHello(this string s) => Console.WriteLine("\tHello " + s);
    }
}
