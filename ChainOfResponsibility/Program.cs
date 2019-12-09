using ChainOfResponsibility.Handlers;
using System;

namespace ChainOfResponsibility {

    class Program {
        static void Main(string[] args) {
            var bear = new BearHandler();
            var dog = new DogHandler();
            var monkey = new MonkeyHandler();

            bear.SetNext(dog).SetNext(monkey);
            Client.ClientCode(bear);

            Console.ReadKey();
        }
    }
}

