using Multi_Inheritance.Interfaces;
using System;

namespace Multi_Inheritance.Behaviours {
    public class BadStudentBehaviour : IStudentBehaviour {

        public string Study() {
            System.Console.WriteLine("Bad study workout..");
            return "Not Complete";
        }

    }
}
