using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes {

    /// <summary>
    /// Attributes are metadata!
    /// This can be used in reflection to seperate different methods/classes/assemblies...
    /// Example in a test-framework, use reflection to execute all methods with the attribute [TestMethod]
    /// </summary>
    class Program {
        static void Main(string[] args) {
            test();

            Console.ReadKey();
            
        }

        //CallerMemberName attribute can be used for an optional parameter
        private static void test([CallerMemberName] string memberName = "") {
            Console.WriteLine(memberName);
        }   
    }
}
