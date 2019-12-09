    using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LINQ {
    public class Fundamentals {
        private static List<MyObject> myList;

        public Fundamentals() {
            createList();

            Console.WriteLine(getObject(1)?.ElementAt(0)?.Name);

            foreach (MyObject o in getObjects("Test"))
                Console.WriteLine(o.ID);
        }

        private static void createList() {
            myList = new List<MyObject>();
            myList.Add(new MyObject() { ID = 1, Name = "Object 1" });
            myList.Add(new MyObject() { ID = 2, Name = "Object 2" });
            myList.Add(new MyObject() { ID = 3, Name = "Object 3" });
            myList.Add(new MyObject() { ID = 4, Name = "Test" });
            myList.Add(new MyObject() { ID = 5, Name = "Test" });
        }

        private static IEnumerable<MyObject> getObject(int id) {
            var result = from o in myList
                         where o.ID == id
                         orderby o.ID ascending
                         select o;
            return result;
        }

        //Where is an extension method in LINQ to IEnumerable, it will internally use 'yield'
        private static IEnumerable<MyObject> getObjects(String name) {
            return myList.Where(x => x.Name.Equals(name));
        }

        //Select is a projection, returns a list of true/false
        private static IEnumerable<bool> selectObjects(String name) {
            return myList.Select(x => x.Equals(name));

        }
    }
}
