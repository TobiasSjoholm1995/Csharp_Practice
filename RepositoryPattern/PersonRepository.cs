using System;
using System.Linq;

namespace RepositoryPattern {
    public class PersonRepository : IPersonRepository {

        private PersonDataContext _personDataContext;
        public PersonRepository(PersonDataContext personDataContext) {
            _personDataContext = personDataContext;
        }

        public PersonModel GetPersonByName(string name) {
            return _personDataContext.People.First(p => p.Name.Equals(name));
        }
    }
}
