using System;
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
            new Benefits();

            Console.ReadKey();
        }

    }
}
