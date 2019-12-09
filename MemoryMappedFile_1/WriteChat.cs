using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryMappedFile_1 {
    public class WriteChat {

        private long SizeOfMFF = 10000;
        private MemoryMappedFile mmf;
        public WriteChat() {
            startChat();
        }

        private void lissenToConsole() {
            string message = String.Empty;
            while (!message.Equals("end")) {
                Console.Write("Write a message: ");
                message = Console.ReadLine();
                sendMessage(message);
            }
        }

        private void startChat() {
            try {
                using (mmf = MemoryMappedFile.CreateOrOpen("testmap", SizeOfMFF)) {
                    Mutex mutex = new Mutex(true, "testmapmutex", out bool createdNew);
                    sendMessage("Chat started");
                    mutex.ReleaseMutex();
                    isReadyMessage();
                    lissenToConsole();
                    mutex.ReleaseMutex();
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine("Send message to MMF failed: " + ex.Message);
            }
        }

        private void sendMessage(string message) {
            using (MemoryMappedViewStream stream = mmf.CreateViewStream(0, message.Length + 1)) {
                BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(message);
            }

        }

        private void isReadyMessage() {
            Console.WriteLine("Start Process B , and hit Enter!");
            Console.ReadLine();
        }
    }
}
