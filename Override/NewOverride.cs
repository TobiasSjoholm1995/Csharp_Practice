using System;

namespace Practice.Override {
    class test {

        public test() {
            Bar foo = new FooBar();   //creates FooBar then implicit cast it to Bar, it will behave as a Bar unlesss something has been overrriden
            IBar ibar = new FooBar();

            ConsolePrinter.Print(foo);
            ConsolePrinter.Print(ibar);
        }


    }

    public interface IBar { }
    public class Bar : IBar { public string Name { get; set; } = "BarName"; }
    public sealed class FooBar : Bar { public new string Name { get; set; } = "FooBarName"; }  //the new keyword is used to indicate it hides, but it will also without hide, but with a compiler warning

    public static class ConsolePrinter {

        public static void Print(IBar item) => Console.WriteLine("IBar");
        public static void Print(Bar item) => Console.WriteLine("Bar: " + item.Name);
        public static void Print(FooBar item) => Console.WriteLine("FooBar: " + item.Name);

    }
}
