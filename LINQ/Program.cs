using System;
using System.Collections.Generic;
using System.Linq;   //Extension methods to IEnumerable<T>

namespace Practice.LINQ {
    class Program {
        private static List<LinqObject> myList;
        static void Main(string[] args) {
            createList();

            Console.WriteLine(getLinqObject(1)?.ElementAt(0)?.Name);
            foreach(LinqObject o in getLinqObjects("Test"))
                Console.WriteLine(o.ID);

            Console.ReadKey();
        }

        private static void createList() {
            myList = new List<LinqObject>();
            myList.Add(new LinqObject() { ID = 1, Name = "Object 1" });
            myList.Add(new LinqObject() { ID = 2, Name = "Object 2" });
            myList.Add(new LinqObject() { ID = 3, Name = "Object 3" });
            myList.Add(new LinqObject() { ID = 4, Name = "Test" });
            myList.Add(new LinqObject() { ID = 5, Name = "Test" });
        }

        private static IEnumerable<LinqObject> getLinqObject(int id) {
            var result = from o in myList where o.ID == id orderby o.ID ascending select o;
            return result;
        }

        //Where is an extension method in LINQ to IEnumerable, it will internally use 'yield'
        private static IEnumerable<LinqObject> getLinqObjects(String name) {
            return myList.Where(x => x.Name.Equals(name));     
        }

        //Select is a projection, returns a list of true/false
        private static IEnumerable<bool> selectLinqObjects(String name) {
            return myList.Select(x => x.Name.Equals(name));
        }
    }
}
