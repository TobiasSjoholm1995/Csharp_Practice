using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelism {
    public class ParallelObject {
        public int Value { get; set; }

        public int ID { get; set; }

        public ParallelObject(int id) {
            ID = id;
        }
    }
}
