using Functional.Maybe;
using System;

namespace MaybeOptional {
    class Program {

        static void Main(string[] args) {

            var result1 = test1(0).OrElse("test");
            var result2 = test2(0) ?? "test";

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Maybe<string> m = test1(1);
            m.Do((s) => Console.WriteLine(s));

            Console.ReadKey();
        }

        static Maybe<string> test1(int x) {
            if (x == 0)
                return "Hej".ToMaybe();

            return Maybe<string>.Nothing;
        }

        static string test2(int x) {
            if (x == 0)
                return "Hej";

            return null;
        }

    }
}
