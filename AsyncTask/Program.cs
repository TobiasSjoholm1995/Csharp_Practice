using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTask {
    /// <summary>
    /// The best benefit with async is that it does not freeze the GUI, i think i have a better test for this.
    /// In this project i only wanted to show that the methods appears to be executing at the same time
    /// </summary>
    class Program {
        private static CancellationTokenSource tokenSource;
        private static List<int> list;

        static void Main(string[] args) {
            tokenSource = new CancellationTokenSource();
            createList();

            var task = Task.Factory.StartNew(() => TaskMethod(list , tokenSource.Token), tokenSource.Token);

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("a");
                Thread.Sleep(100);
            }

            task.Wait();
            Console.WriteLine(Environment.NewLine + "Task is done");
            Console.ReadKey();
        }

        private static async Task TaskMethod(List<int> list, CancellationToken token) {
            using (StreamWriter writer = new StreamWriter("TestFile.txt")) {
                foreach (var item in list) {
                    if (token.IsCancellationRequested)
                        return;
                    await writer.WriteAsync(item.ToString());   //execution will go back to the caller method while this is beeing handled
                    Console.WriteLine("Wrote to file async");
                    Thread.Sleep(100);
                }
            }
        }

        private static void createList() {
            list = new List<int>();

            for (int i = 0; i < 10; i++)
                list.Add(i);
        }


    }
}
