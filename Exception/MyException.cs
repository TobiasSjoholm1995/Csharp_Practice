using System;

namespace Exception {
    class MyException : System.Exception {

        public String MyMessage { get; set; }

        public MyException(string message) {
            MyMessage = message;
        }

    }
}
