using System;

namespace Practice.Override {
    class Program {
        static void Main(string[] args) {
            BaseClass    b  = new BaseClass();
            DerivedClass d  = new DerivedClass();
            BaseClass db    = new DerivedClass();

            Console.WriteLine("Override:");
            b.Run();
            d.Run();
            db.Run();  //override --> derived method

            Console.WriteLine(Environment.NewLine + "New:");
            b.Run2();
            d.Run2();
            db.Run2();  //new --> bas method   this is still a base, need to cast it to change to derived

            Console.ReadKey();
        }
    }
}
