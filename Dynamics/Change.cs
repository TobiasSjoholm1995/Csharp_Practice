using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic {
    // Dynamic variables are still statically typed to dynamic. 
    // But its content can change dynamically
    // just reassign the variable
    class Change {

        public Change() {
            dynamic d;

            Console.Write(Environment.NewLine + "Create [i]nt or [d]ouble: ");

            var key = Console.ReadKey(intercept: true);
            if (key.Key == ConsoleKey.D)
                d = 5.5;
            else if (key.Key == ConsoleKey.I)
                d = 1;
            else
                d = "unknown";

            printMe(d);
        }

        void printMe(int i)     => Console.WriteLine(Environment.NewLine + "\tint: "     + i);
        void printMe(double i)  => Console.WriteLine(Environment.NewLine + "\tdouble: "  + i);
        void printMe(dynamic i) => Console.WriteLine(Environment.NewLine + "\tdynamic: " + i);
    }
}
