using System;

namespace Exception {
    class Program {

        static void Main(string[] args) {
            new Normal();
            new Async();
            new MyThread();
            Console.ReadKey();
        }

    }
}
