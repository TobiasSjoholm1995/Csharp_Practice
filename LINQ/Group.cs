using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    public class Group {
        private string Name = "Tobias Sjoholm";
        private List<MyObject> ProductTable;

        public Group() {
            createList();
            group1();
            group2();
        }

        private void group1() {
            Console.WriteLine("Group 1");

            var result = from p in ProductTable
                         group p by p.ID into g
                         select new { g.Key, Products = g };

            foreach (var item in result) {
                Console.WriteLine("\tKey - " + item.Key);
                foreach (var value in item.Products)
                    Console.WriteLine("\t\t" + value.Name);
            }
            Console.WriteLine();
        }

        private void group2() {
            Console.WriteLine("Group 2");

            var result = ProductTable.GroupBy(
                              i => i.ID,
                              p => p.Name,
                              (key, p) => new { Key = key, Products = p }
                          );

            foreach (var item in result) {
                Console.WriteLine("\tKey - " + item.Key);
                foreach (var value in item.Products) 
                    Console.WriteLine("\t\t" + value);
            }
            Console.WriteLine();
        }


        private void createList() {
            ProductTable = new List<MyObject>();
            ProductTable.Add(new MyObject() { ID = 1, Name = "Mobile" });
            ProductTable.Add(new MyObject() { ID = 1, Name = "Smartphone" });
            ProductTable.Add(new MyObject() { ID = 2, Name = "Keyboard" });
            ProductTable.Add(new MyObject() { ID = 3, Name = "Computer" });
            ProductTable.Add(new MyObject() { ID = 3, Name = "Laptop" });
        }


    }
}
