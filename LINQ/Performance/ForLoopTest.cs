using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    public class ForLoopTest {

        public const int ITERATIONS = 20_000_000;
        List<long> list = new List<long>();

        public ForLoopTest() {
            for (int i = 0; i < ITERATIONS; i++)
                list.Add(i);
        }


        [Benchmark]
        public void Linq() => linq();


        [Benchmark]
        public long ForLoop() => forLoop();


        [Benchmark]
        public long ForeachLoop() => foreachLoop();



        private long linq() {
            return list.Sum();
        }

        private long forLoop() {
            int count = ITERATIONS;

            long sum = 0;
            for (int i = 0; i < count; i++)
                sum += list[i];

            return sum;
        }

        private long foreachLoop() {
            long sum = 0;

            foreach (var item in list) 
                sum += item;

            return sum;
        }

    }
}
