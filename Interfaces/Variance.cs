using System;


namespace Interfaces {
    public class Animal { }
    public class Dog : Animal { }
    public class BossDog : Dog { }

    public class ContraVariance<T> : IContainer_in<T> where T : new() {
        public void Add(T value) { Console.WriteLine(value); }
    }

    public class CoVariance<T> : IContainer_out<T> where T: new() {
        public T Get() => new T();
    }


    // Generics is by default invarient
    // Contravariance is used for input parameter, upwards
    // Covariance is used for return type,  downwards
    public class Variance {

        public Variance() {
            Console.WriteLine("ContraVariance:");
            IContainer_in<Dog> f = new ContraVariance<Animal>();
            f.Add(new Dog());


            Console.WriteLine(Environment.NewLine + "CoVariance:");
            IContainer_out<Animal> d = new CoVariance<Dog>();
            Animal x = d.Get();  //this is a dog



            Console.WriteLine(Environment.NewLine + "Invariance:");
            IGenericContainer<Animal> g = new GenericContainer<Animal>();   //must be the same, cuz the type can be both in and out parameters
            g.Add(new Dog());
            //g.Add(new object()); does not work
            object o = g.Get();
            //Dog d = g.Get();  does not work
        }

    }
}
