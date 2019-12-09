using Multi_Inheritance.Interfaces;

namespace Multi_Inheritance.Models {
    class Teacher : Person, ITeacherBehaviour {

        private readonly ITeacherBehaviour _teacherBehaviour;
        public string Field { get; set; }

        public void Teach() => _teacherBehaviour.Teach();

        public Teacher(ITeacherBehaviour teacherBehaviour) {
            _teacherBehaviour = teacherBehaviour;
        }
    }
}
