using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    public class ExcludingJoin {
        private List<MyObject> ProductTable;
        private List<MyObject> ProductTable2;

        public ExcludingJoin() {
            //Same type of tables
            createProducts();
            ExludingJoin();
        }


        private void ExludingJoin() {
            Console.WriteLine("Exluding Join");

            var left = from p2 in ProductTable2
                       join p in ProductTable on p2.ID equals p.ID into ps
                       from temp in ps.DefaultIfEmpty()
                       where temp == null
                       select p2;

            var right = from p in ProductTable
                        join p2 in ProductTable2 on p.ID equals p2.ID into ps
                        from temp in ps.DefaultIfEmpty()
                        where temp == null
                        select p;


            var result = right.Union(left);

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void createProducts() {
            ProductTable = new List<MyObject>();
            ProductTable.Add(new MyObject() { ID = 1, Name = "Object 1" });
            ProductTable.Add(new MyObject() { ID = 2, Name = "Object 2" });
            ProductTable.Add(new MyObject() { ID = 3, Name = "Object 3" });
            ProductTable.Add(new MyObject() { ID = 4, Name = "Object 4" });
            ProductTable.Add(new MyObject() { ID = 5, Name = "Object 5" });

            ProductTable2 = new List<MyObject>();
            ProductTable2.Add(new MyObject() { ID = 1, Name = "Object 1" });
            ProductTable2.Add(new MyObject() { ID = 3, Name = "Object 3" });
            ProductTable2.Add(new MyObject() { ID = 5, Name = "Object 5" });
            ProductTable2.Add(new MyObject() { ID = 7, Name = "Object 7" });
        }
    }
}
