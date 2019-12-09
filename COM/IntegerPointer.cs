using System;
using System.Runtime.InteropServices;   //COM interop and platform invoke services

namespace COM {
    // Integer Pointer, you can use IntPtr to store a pointer value in a non-pointer type
    // A platform-specific type that is used to represent a pointer or a handle.
    // IntPtr does not know what it points to, it just point at some memory location
    class IntegerPointer {

        public IntegerPointer() {
            Console.WriteLine("IntPtr:");
            int test = 55;

            // Allocating memory for int
            IntPtr intPtr = Marshal.AllocHGlobal(sizeof(int));  //returns pointer to the memory cells that we allocated

            // sending intPointer to unmanaged code
            Marshal.WriteInt32(intPtr, test);

            //p.ToPointer();  //pointers should only be in unsafe code blocks

            int test2 = Marshal.ReadInt32(intPtr);  // test2 should be equal 55

            Console.WriteLine("\t" + (test == test2));

            // Free HGlobal memory
            Marshal.FreeHGlobal(intPtr);
        }

    }
}
