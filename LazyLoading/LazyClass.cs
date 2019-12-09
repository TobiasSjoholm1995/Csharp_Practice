using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading {
    public class LazyClass {

        private Lazy<MyObject> lazy = new Lazy<MyObject>();  //this does NOT create MyObject

        public void Create() {
            Console.WriteLine(lazy.IsValueCreated);
            lazy.Value.ToString();     // this create MyObject
            Console.WriteLine(lazy.IsValueCreated);
        }

    }
}
