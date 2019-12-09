using Multi_Inheritance.Interfaces;
using System;
using System.Collections.Generic;

namespace Multi_Inheritance.Models {
    class Student : Person, IStudentBehaviour {

        private readonly IStudentBehaviour _studentBehaviour;
        public List<string> Courses { get; set; }

        public string Study() => _studentBehaviour.Study();

        public Student(IStudentBehaviour studentBehaviour) {
            this._studentBehaviour = studentBehaviour;
        }

    }
}
