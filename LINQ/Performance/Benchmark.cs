using BenchmarkDotNet.Running;

namespace Practice.LINQ {
    public class Benchmark {

        public Benchmark() {
            //var summary1 = BenchmarkRunner.Run<SelectTest>();
            //var summary2 = BenchmarkRunner.Run<WhereTest>();
            var summary3 = BenchmarkRunner.Run<ForLoopTest>();
        }

    }
}
