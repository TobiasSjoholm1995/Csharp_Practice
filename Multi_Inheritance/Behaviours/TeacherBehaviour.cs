using Multi_Inheritance.Interfaces;
using System;

namespace Multi_Inheritance.Behaviours {
    class TeacherBehaviour : ITeacherBehaviour {
        public void Teach() {
            Console.WriteLine("Teaching");
        }
    }
}
