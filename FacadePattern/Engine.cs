using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern {
    public class Engine {

        private SubEngine subEngine;

        public void SetEngine() {
            Console.WriteLine("SetEngine");
        }

        public Engine(SubEngine subEngine) {
            this.subEngine = subEngine;
        }

    }


}
