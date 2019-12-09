using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LINQ {
    /// <summary>
    /// Using Method Syntax
    /// Method syntax is messy with Joins
    /// </summary>
    public class Joins_MethodSyntex {
        private int[] IDTable = { 1, 3, 5, 7 };
        private List<MyObject> ProductTable;

        public Joins_MethodSyntex() {
            createList();

            Console.WriteLine("IDTable = Left, Products = Right" + Environment.NewLine);

            LeftJoin1();
            LeftJoin2();
            RightJoin();
            InnerJoin();
        }


        private void LeftJoin1() {
            Console.WriteLine("Left Join 1");

            var result = IDTable.SelectMany(
                             id => ProductTable.Where(p => p.ID == id).DefaultIfEmpty(),
                             (id, product) => new {
                                 ID = id,
                                 Name = (product != null) ? product.Name : "No Product"
                             }
                         );

            foreach (var item in result)
               Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void LeftJoin2() {
            Console.WriteLine("Left Join 2");

            //works pretty much as a left join, but meant to group it
            var result = IDTable.GroupJoin(
                              ProductTable,
                              id => id,
                              p => p.ID,
                              (id, g) => new { ID = id, Products = g }
                         );

            foreach (var item in result) {
                if(item.Products?.Count() == 0)
                    Console.WriteLine("\t" + item.ID + " - " + "No Product");
                else
                    foreach (var value in item.Products)
                        Console.WriteLine("\t" + value.ID + " - " + value.Name);
            }
        }

        private void RightJoin() {
            Console.WriteLine("Right Join");

            var result = ProductTable.SelectMany(
                             p => IDTable.Where(id => id == p.ID).DefaultIfEmpty(),
                             (product, id) => new {
                                 ID = id,
                                 product.Name
                             }
                         ).OrderBy(p => p.ID);

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
            Console.WriteLine();
        }

        private void InnerJoin() {
            Console.WriteLine("Inner Join");

            var result = ProductTable.SelectMany(
                  p => IDTable.Where(id => id == p.ID),
                  (product, id) => new { product.ID, product.Name }
              );

            //another approach
            var result2 = ProductTable.Join(
                  IDTable,
                  p => p.ID,
                  id => id,
                  (product, id) => new { product.ID, product.Name }
              );

            foreach (var item in result)
                Console.WriteLine("\t" + item.ID + " - " + item.Name);
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
