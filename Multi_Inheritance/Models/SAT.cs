using Multi_Inheritance.Interfaces;
using System.Collections.Generic;

namespace Multi_Inheritance.Models {
    // Instead of multi inheritance,
    // use private variables of the the classes you want to inherite from and implement their interface
    // composition!! drawback is all the linking, but the interfaces make it loose coupling
    class SAT : Person, IStudentBehaviour, ITeacherBehaviour {

        private readonly IStudentBehaviour _studentBehaviour;
        private readonly ITeacherBehaviour _teacherBehaviour;

        public List<string> Courses { get; set; }   //Copy paste the properties, data can often be copy pasted (only that data that is unique to Student)
        public string Field { get; set; }

        public string Study() => _studentBehaviour.Study();
        public void Teach()   => _teacherBehaviour.Teach();

        public SAT(IStudentBehaviour studentBehaviour, ITeacherBehaviour teacherBehaviour) {
           _studentBehaviour = studentBehaviour;
           _teacherBehaviour = teacherBehaviour;
        }
    }
}
