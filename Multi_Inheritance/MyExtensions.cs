using Multi_Inheritance.Interfaces;
using System;

namespace Multi_Inheritance {
    public static class MyExtensions {

        // this prevent long method chaining like,
        // sat.Study.Equals("Complete");
        // now instead,
        // sat.StudyIsComplete();

        // Notice that SAT implement IStudent, so can me implicit cast to IStudent
        // Parameter could be SAT instead but always take the most specific type
        public static bool StudyIsComplete(this IStudentBehaviour s) {
            return s.Study().Equals("Complete");
        }

    }
}
