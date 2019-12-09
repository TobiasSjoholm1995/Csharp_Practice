using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Program {

        /// <summary>
        /// Interfaces is a contract where the class that implements it, promise to have these method
        /// Interfaces creates low coupling between modules, high abtraction
        /// Standarlize the use of objects, for exaple if you have 2 diff collections that use the same interface
        /// its 
        /// </summary>
        static void Main(string[] args) {
            Console.WriteLine("Test of interfaces");
            //new Benefits();
            new Variance();
            //testExplicit();

            Console.ReadKey();
        }

        static void testExplicit() {
            Console.WriteLine();

            var myExplicit = new ExplicitImplementationTest();
            ((IDoItSlow)myExplicit).Go();

            ConcurrentDictionary<int, int> c = new ConcurrentDictionary<int, int>();
            //this is being explicit implemented in ConurrentDisctioanry, to prevent usage   
            //(forced to implement it cuz of IDictionary interface)  
            ((IDictionary<int, int>)c).Add(1, 1);
            c.TryAdd(2, 2);  //recommended way
            Console.WriteLine(c.Count());  
        }

    }
}
