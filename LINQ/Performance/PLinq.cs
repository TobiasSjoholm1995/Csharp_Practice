using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LINQ {
    class PLinq {

        public PLinq() {
            test();
        }

        private void test() {

            //The bigger this is, the more benefit the parallism has
            var source = Enumerable.Range(0, 100_000);

            {
                var queryToMeasure = from num in source.AsParallel()
                                     where IsValid(num)
                                     select num;

                Console.WriteLine("Measuring...");

                Stopwatch sw = Stopwatch.StartNew();
                foreach (var n in queryToMeasure) { }
                sw.Stop();

                Console.WriteLine("Parallel query time: {0} ms", sw.ElapsedMilliseconds);
            }
            Console.WriteLine();
            {
                var queryToMeasure = from num in source
                                     where IsValid(num)
                                     select num;

                Console.WriteLine("Measuring...");

                Stopwatch sw = Stopwatch.StartNew();
                foreach (var n in queryToMeasure) { }
                sw.Stop();

                Console.WriteLine("Query time: {0} ms", sw.ElapsedMilliseconds);
            }
        }


        //The bigger this metgod is, the more benefit the parallism has
        bool IsValid(int input) {
            int result = 0;

            for (int i = 0; i < 10_000; i++)
                result = input % 2;


            return result == 0;
        }


    }
}
