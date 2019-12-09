using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern {
    class Program {
        /// <summary>
        /// https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
        /// Diff ways to implement
        /// 1. No Thread Safe Singleton.
        /// 2. Thread-Safety Singleton.
        /// 3. Thread-Safety Singleton using Double-Check Locking.    (performance reason, lock is expensive)
        /// 4. Thread-Safe Singleton without using locks and no lazy instantiation.
        /// 5. Fully lazy instantiation.
        /// 6. Using.NET 4's Lazy<T> type.
        /// </summary>
        static void Main(string[] args) {
            Console.WriteLine(Singleton.Instance.ToString());
            Console.ReadKey();
        }
    }
}
