using Multi_Inheritance.Interfaces;
using System;


namespace Multi_Inheritance.Behaviours {
    public class GoodStudentBehaviour : IStudentBehaviour {

        public string Study() {
            System.Console.WriteLine("Good Study workout!");
            return "Complete";
        }
    }
}
