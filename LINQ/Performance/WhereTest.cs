using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    public class WhereTest {

        public const int ITERATIONS = 1_000_000;
        List<MyObject> list = new List<MyObject>();

        public WhereTest() {
            for (int i = 0; i < ITERATIONS; i++)
                list.Add(new MyObject() { ID = i });
        }


        [Benchmark]
        public void Where() => where();

        [Benchmark]
        public void MultipleWhere() => multipleWhere();


        private void where() {
            var result = list.Where(x =>
                                     x.ID != 500_000 &&
                                     x.ID != 500_009);

            foreach (var item in result) { }
        }


        private void multipleWhere() {
            var result = list.Where(x => x.ID != 500_000)
                            .Where(x => x.ID != 500_009);

            foreach (var item in result) { }
        }
    }
}
