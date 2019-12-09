using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    /// <summary>
    /// Using Query Syntax
    /// </summary>
    public class Joins_QuerySyntax {
        private int[] IDTable = { 1, 3, 5, 7 };
        private List<MyObject> ProductTable;

        public Joins_QuerySyntax() {
            createList();

            Console.WriteLine("IDTable = Left, Products = Right" + Environment.NewLine);

            LeftJoin();
            RightJoin();
            InnerJoin();
            FullJoin();

            ExludingJoin();
            LeftExludingJoin();
            RightExcludingJoin();
        }


        private void LeftJoin() {
            Console.WriteLine("Left Join");
            var result = from i in IDTable
                         join p in ProductTable on i equals p.ID into ps
                         from pr in ps.DefaultIfEmpty()
                         select new { ID = i, Name = (pr != null) ? pr.Name : "No product" };

            foreach (var item in result) 
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void RightJoin() {
            Console.WriteLine("Right Join");
            var result = from p in ProductTable
                         join i in IDTable on p.ID equals i into ps
                         from id in ps.DefaultIfEmpty()
                         orderby id ascending
                         select new { ID = id,  p.Name};

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void InnerJoin() {
            Console.WriteLine("Inner Join");
                
            var result = from p in ProductTable
                         join i in IDTable on p.ID equals i 
                         select new { p.ID, p.Name };

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void FullJoin() {
            Console.WriteLine("Full Join");

            var leftJoin = from i in IDTable
                           join p in ProductTable on i equals p.ID into ps
                           from pr in ps.DefaultIfEmpty()
                           select new { ID = i, Name = (pr != null) ? pr.Name : "No product" };

            var rightJoin = from p in ProductTable
                            join i in IDTable on p.ID equals i into ps
                            from id in ps.DefaultIfEmpty()
                            orderby id ascending
                            select new { ID = id, p.Name };

            var result = rightJoin.Union(leftJoin);   //Union is concat followed by distinct

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void ExludingJoin() {
            Console.WriteLine("Exluding Join");

            var left = from i in IDTable
                         join p in ProductTable on i equals p.ID into ps
                         from temp in ps.DefaultIfEmpty()
                         where temp == null
                         select new { ID = i, Name = "No product" };

            var right = from p in ProductTable
                         join i in IDTable on p.ID equals i into ps
                         from temp in ps.DefaultIfEmpty()
                         where temp == 0
                         select new { ID = 0, p.Name, };


            var result = right.Union(left);

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void LeftExludingJoin() {
            Console.WriteLine("Left Exluding Join");

            var result = from i in IDTable
                         join p in ProductTable on i equals p.ID into ps
                         from p in ps.DefaultIfEmpty()
                         where p == null
                         select new { ID = i};

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID);
            Console.WriteLine();
        }

        private void RightExcludingJoin() {
            Console.WriteLine("Left Excluding Join");

            var result = from p in ProductTable
                         join i in IDTable on p.ID equals i into ps
                         from temp in ps.DefaultIfEmpty()
                         where temp == 0
                         select new { p.Name };

            foreach (var item in result)
                Console.WriteLine("\t" + item.Name);
            Console.WriteLine();
        }

        private void createList() {
            ProductTable = new List<MyObject>();
            ProductTable.Add(new MyObject() { ID = 1, Name = "Object 1" });
            ProductTable.Add(new MyObject() { ID = 2, Name = "Object 2" });
            ProductTable.Add(new MyObject() { ID = 3, Name = "Object 3" });
            ProductTable.Add(new MyObject() { ID = 4, Name = "Object 4" });
            ProductTable.Add(new MyObject() { ID = 5, Name = "Object 5" });
        }

    }
}
