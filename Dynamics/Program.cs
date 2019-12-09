using System;

namespace Dynamic {
    // Dynamic is used with COM interop (inter-connections with dynamic langages)
    // Dynamic creates late binding (one sort of polymorphism)
    // Dynamic is used with reflection
    class Program {

        static void Main(string[] args) {
            new LateBinding();
            new MethodCalling();
            new Limitations();
            new Change();

            Console.ReadKey();
        }

    }
}
