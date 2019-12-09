using System;
using System.Collections.Generic;
using System.Linq;   //Extension methods to IEnumerable<T>

namespace Practice.LINQ {
    // LINQ has 2 syntaxes, method or query syntax

    // MoreLinq is an open source lib with more extension methods
    // PLinq is a built in lib for parallel computation

    // Linq is declarative, almost like functional programming
    // Linq has a fluent interface that makes it poss to use method chaining

    // To prevent deferred execution in Linq use, ToList()
    // Linq has 2 modes, streaming or saving in memory
    // IEnumerable will stream
    // avoid functions like max, min, Reverse, they need all of the connection in memory to operate
    class Program {
        static void Main(string[] args) {
            //new Fundamentals();

            //new Joins();
            //new Joins_MethodSyntex();
            //new ExcludingJoin();
            //new Group();
            //new DeferredExecution();
            new MethodNames();
            //new PLinq();
            //new Benchmark();

            Console.ReadKey();
        }



    }
}
