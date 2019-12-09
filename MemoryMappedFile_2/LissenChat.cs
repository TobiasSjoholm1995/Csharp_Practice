using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryMappedFile_2 {
    class LissenChat {

        public LissenChat() {
            receiveMessage();
        }

        private void receiveMessage() {
            try {
                Console.WriteLine("Starting to lissen to MFF");
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("testmap")) {

                    while (true) {
                        Mutex mutex = Mutex.OpenExisting("testmapmutex");
                        mutex.WaitOne();

                        using (MemoryMappedViewStream stream = mmf.CreateViewStream()) {
                            Console.WriteLine("Process A says: " + new BinaryReader(stream).ReadString());
                        }
                        mutex.ReleaseMutex();
                    }
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine("Receive message from MMF Failed: " + ex.Message);
            }
        }

    }
}
