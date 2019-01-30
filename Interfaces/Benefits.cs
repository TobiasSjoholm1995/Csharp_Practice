using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces {
    class Benefits {
        private List<MyObject> list = new List<MyObject>();
        private HashSet<MyObject> hashSet  = new HashSet<MyObject>();


        // Does not matter what object we store the datastructure in, as long as it inherent the ICollection interface.
        // This create low coupling between this class and the classes that depend on these methods
        public Benefits() {
            create(list);
            create(hashSet);

            write(list);
            Console.WriteLine();
            write(hashSet);

            Clear(list);
            Clear(hashSet);
        }

        private void create(ICollection<MyObject> collection) {
            for (int i = 0; i < 3; i++)
                collection.Add(new MyObject() { Value = i });
        }


        private void write(ICollection<MyObject> collection) {
            foreach(var item in collection)
                Console.WriteLine(item.Value);
        }

        private void Clear(ICollection<MyObject> collection) {
            collection.Clear();
        }
    }
}
