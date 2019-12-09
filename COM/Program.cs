using System;
using System.Runtime.InteropServices;   //COM interop and platform invoke services

namespace COM {
    // COM - Component Object Model
    // It is a binary-interface standard that defines how objects are created, destroyed and interacts.

    // It always implement the IUnknown interface which has 3 member: 
    //     QueryInterface - Retrieves pointers to the supported interfaces on an object.
    //     AddRef         - Increments the reference count for an interface on an object
    //     Release        - Decrements the reference count for an interface on an object.

    // IID - Interface Identifier
    // You must use an IID when calling the QueryInterface method. 

    // HResult -  value to indicate the success or failure of a method 
    // WinError.h define constants
    // All contants that start with 'E_' is error codes
    // All contants that start with 'S_' is success codes
    // recommended to use Macro to test for succes/failure and not hardcode test
    // Example: 
    //     Constant    = S_OK 
    //     Value       = 0
    //     Description = success

    class Program {

        static void Main(string[] args) {
            new IntegerPointer();
            new GUID();
            new Dll();

            Console.ReadKey();
        }

    }
}
