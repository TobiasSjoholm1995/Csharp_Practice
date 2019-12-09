using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    public class SelectTest {

        public const int ITERATIONS = 10_000_000;
        List<int> list = new List<int>();

        public SelectTest() {
            for (int i = 0; i < ITERATIONS; i++)
                list.Add(i);


        }


        [Benchmark]
        public void Select() => select();

        [Benchmark]
        public void MultipleSelect() => multipleSelect();

        private void multipleSelect() {
            var result = list.Select(x => x + 1)
                            .Select(x => x + 1);

            foreach (var item in result) {}
        }

        private void select() {
            var result = list.Select(x => x + 2);

            foreach (var item in result) {}
        }
    }
}
