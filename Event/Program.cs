using System;
using System.Threading.Tasks;

namespace Practice.Event {
    class Program {
        static void Main(string[] args) {
            MyObject o = new MyObject() { };
            o.Callback += method;
            o.Run();

            //o.Callback = null;    //not possible, thanks to the 'event' keyword
            Console.ReadKey();
        }

        private static void method(object sender, GenericEventArgs<String> e) {
            Console.WriteLine("The Callback " + e?.Value);    
        }
    }
}
