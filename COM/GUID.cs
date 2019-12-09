using System;
using System.Runtime.InteropServices;

namespace COM {
    // GUID - Globally Unique Identifier
    // somtimes called UUIDs Universaly Unique Identifier
    // A GUID is a 128-bit integer that you can use across all computers and networks wherever a unique identifier is required.
    // No need for a central authority to ensure uniqueness (probability really low)
    class GUID {

        public GUID() {
            Console.WriteLine(Environment.NewLine + "GUID: ");
            var guid = Guid.NewGuid();

            Console.WriteLine("\t" + guid);
        }

    }

    [Guid("9ED54F84-A89D-4fcd-A854-44251E925F09")]
    public class GuidSampleClass {}


}
