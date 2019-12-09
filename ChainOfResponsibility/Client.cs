using ChainOfResponsibility.Handlers;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility {
    class Client {
        private static List<string> food = new List<string> { "Salmon", "Banana", "Cup of coffee" };

        public static void ClientCode(BaseHandler handler) {
            foreach (var f in food) {

                Console.WriteLine($"Who wants a {f}?");

                var result = handler.Handle(f);

                if (result != null) 
                    Console.WriteLine("\t" + result);
                else 
                    Console.WriteLine("\t No1");
            }
        }

    }
}
