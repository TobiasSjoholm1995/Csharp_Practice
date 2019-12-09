using Multi_Inheritance.Behaviours;
using Multi_Inheritance.Interfaces;
using Multi_Inheritance.Models;
using System;

/// Multi inheritance does not exist in C#, how do we solve problems that is normally solved with multi inheritance
namespace Multi_Inheritance {

    /// <summary>
    /// You have the components Student and Teacher
    /// Student have members: Name(string), Age(int), Study(method), Courses(List<string> property)
    /// Teacher have members: Name(string), Age(int), Teach(method), Field(string property)
    /// Implement these classes with code reuse.
    /// The challenge is then to implement a class that is both a student and a teacher, so called SAT
    /// </summary>
    class Program {

        static void Main(string[] args) {
            Student s = new Student(new GoodStudentBehaviour());
            Teacher t = new Teacher(new TeacherBehaviour());
            SAT sat = new SAT(new BadStudentBehaviour(), new TeacherBehaviour());

            //sat can be treated both as a student and as a teacher:
            s.Study();
            sat.Study();

            Console.WriteLine();

            t.Teach();
            sat.Teach();

            //They all can be treated as person
            var x1 = s.Age;
            var x2 = t.Age;
            var x3 = sat.Age;

            Console.WriteLine();

            //extension method
            Console.WriteLine("Student: " + s.StudyIsComplete() + Environment.NewLine);
            Console.WriteLine("SAT: " + sat.StudyIsComplete());

            Console.ReadKey();
        }

    }

}
