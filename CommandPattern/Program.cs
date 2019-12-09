using System;

namespace CommandPattern {
    class Program {
        static void Main(string[] args) {
            Receiver receiver = new Receiver();
            Command  command  = new Command(receiver);

            Invoker  invoker  = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
