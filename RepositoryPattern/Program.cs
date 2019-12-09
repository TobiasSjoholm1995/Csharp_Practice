using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern {
    class Program {
        static void Main(string[] args) {

            //This stuff does not matter, not really a part of the pattern
            var repo = new PersonRepository(new PersonDataContext());
            new Logic(repo);

            Console.ReadKey();
        }
    }
}
