namespace D {

    // The Dependency Inversion Principle (DIP), states that 
    // high level modules should not depend on low level modules
    // both should depend on abstractions. 

    // Abstractions should not depend on details.  
    // Details should depend upon abstractions.

    // Abstraction is in this case the interface
    // DIP says that the Car should not depend on the lower level Engine class
    // Neither should the Engine class depend on the Car class
    // Both should depend in the interface, lose coupling --> maintainable software
    // The dependency is no longer downwards in the dependenct graph, its been inverted

    // DIP is often implemented with Dependency Injection (DI)
    // DI can be done through ctor, method or propery

    interface IEngine { }
    class Engine { }

    class Car {
        //DI + interface --> DIP
        public IEngine Engine { get; set; }


        //DI through ctor
        public Car(IEngine engine) {
            Engine = engine;
        }
    }


}
