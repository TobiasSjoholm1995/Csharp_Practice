using System;
using System.Collections.Generic;

namespace RepositoryPattern {
    //Dummy DataContext
    public class PersonDataContext {

        public List<PersonModel> People;

        public PersonDataContext() {
            People = new List<PersonModel>();
            People.Add(new PersonModel() { Name = "Tobbe" });
        }
    }
}
