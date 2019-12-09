using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern {
    /// <summary>
    /// The logic knows nothing about how the data is stored.
    /// </summary>
    public class Logic {
        private IPersonRepository _personRepo;

        public Logic(IPersonRepository personRepo) {
            _personRepo = personRepo;
            Console.WriteLine(GetPersonByName("Tobbe")?.Name);
        }

        public PersonModel GetPersonByName(string name) {
            return _personRepo.GetPersonByName(name);
        }

    }
}
