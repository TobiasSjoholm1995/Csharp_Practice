using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading {

    // How to implement Lazy loading
    public class ImplementLazy {

        private MyObject lazyObject;
        public MyObject LazyObject {
            get {
                if (lazyObject == null)
                    lazyObject = new MyObject();
                return lazyObject;
            }
         }
      
    }
}
