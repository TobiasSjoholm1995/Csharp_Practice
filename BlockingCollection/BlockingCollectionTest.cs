using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace BlockingCollection {
    public class BlockingCollectionTest {

        // Warning bad performance compared to doing it sequential in a list 
        public BlockingCollectionTest() {
            BlockingCollection<MyObject> collection = new BlockingCollection<MyObject>();

            Task.Run(new Action(() => addItems(collection)));
            Task.Run(new Action(() => consumeItems(collection)));
        }

        private void addItems(BlockingCollection<MyObject> collection) {
            for (int i = 0; i < 10; i++) {
                collection.Add(new MyObject(i));
                Thread.Sleep(1000);
            }
            collection.CompleteAdding();
        }

        private void consumeItems(BlockingCollection<MyObject> collection) {
            foreach (MyObject item in collection.GetConsumingEnumerable()) {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine("Adding is complete, foreach loop therefore ends");
        }
    }
}
