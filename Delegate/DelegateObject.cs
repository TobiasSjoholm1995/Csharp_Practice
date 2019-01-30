using System;

namespace Practice.Delegate {
    public class DelegateObject {
        //Delegtate is method pointer
        public delegate int PerformCalculation(int x, int y);   
        public PerformCalculation AddDelegate;   //The actual method pointer to a specific pointer

        public DelegateObject() {
            AddDelegate = new PerformCalculation(add);            
        }

        private int add(int x, int y) {
            return x + y;
        }

    }
}
