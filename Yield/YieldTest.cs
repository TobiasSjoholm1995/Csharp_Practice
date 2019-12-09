using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Yield {
    class YieldTest {

        public YieldTest() {
            foreach(var item in method()) {
                Console.WriteLine(item.Value);
            }
        }

        private IEnumerable<MyObject> method() {
            for (int i = 0; i < 10; i++) {
                Thread.Sleep(1000);
                yield return new MyObject(i);
            }
        }

    }
}
