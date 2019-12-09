using System;

namespace SingletonPattern {
    public class Singleton {

        //Lazy<> make sure that it is first instantiated when used, does not really mather in most cases
        //Lazy is thread safe
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        // Prevent outside instantiation 
        private Singleton() { MyProperty = 5; }

        public static Singleton Instance => lazy.Value;



        public int MyProperty { get; set; }
    }
}
