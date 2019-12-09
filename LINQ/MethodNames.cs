using System;
using System.Linq;

namespace Practice.LINQ {
    public class MethodNames {

        public MethodNames() {

            var objectNames = typeof(object)
                             .GetMethods()
                             .Select(m => m.Name)
                             .OrderBy(n => n)
                             .Distinct();

            var linqNames = typeof(Enumerable)
                        .GetMethods()
                        .Select(m => m.Name)
                        .OrderBy(n => n)
                        .Except(objectNames)
                        .Distinct();

            Console.WriteLine("Object Methods: " + objectNames.Count());
            foreach (var m in objectNames)
                Console.WriteLine("\t" + m);


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Linq Methods: " + (linqNames.Count() - objectNames.Count()));

            foreach (var m in linqNames)
                Console.WriteLine("\t" + m);
        }
    }
}
