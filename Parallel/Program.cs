using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

namespace Parallelism {
    class Program {
        private static List<ParallelObject> list;
        private static Dictionary<int, ParallelObject> dictionary = new Dictionary<int, ParallelObject>();
        private static ConcurrentBag<ParallelObject> bag = new ConcurrentBag<ParallelObject>();

        static void Main(string[] args) {
            createList();

            TPL();
            PLINQ();
            SyncParallelism();

            Console.ReadKey();
        }

        private static void TPL() {
            Console.WriteLine("Task Parallel Library:");
            Parallel.ForEach(list, ele => ele.Value = 3);
            Parallel.ForEach(list, ele => Console.WriteLine("Id = " + ele.ID + ", Value = " + ele.Value));
        }

        private static void PLINQ() {
            Console.WriteLine("\nParallel LINQ");
            list.AsParallel().AsOrdered().ForAll(ele => ele.Value = 5);
            list.AsParallel().AsOrdered().ForAll(ele => Console.WriteLine("Id = " + ele.ID + ", Value = " + ele.Value));
        }

        private static void SyncParallelism() {
            Console.WriteLine("\nResult of parallel computation  in SortedList");
            list.AsParallel().AsOrdered().ForAll(o => { dictionary.Add(o.ID, o); });
            foreach(ParallelObject o in dictionary.Values) 
                Console.WriteLine("Id = " + o.ID + ", Value = " + o.Value);
        }

        private static void createList() {
            list = new List<ParallelObject>();

            for (int i = 0; i < 20; i++)
                list.Add(new ParallelObject(i));
        }
    }
}
