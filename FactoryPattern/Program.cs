using System;

namespace FactoryPattern {
    class Program {
        static void Main(string[] args) {
            var breakfast = BreakfastFactory.CreateBreakfast();

            Console.WriteLine($"Type of breakfast = {breakfast.GetFood()}, Cook time = {breakfast.CookTime}");
            Console.ReadKey();
        }
    }
}
