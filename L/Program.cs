namespace L {

    // Liskov Substitution Principle (LSP), says that a derived class needs to fulfill its contract with the base class.
    // In that sense that all properties and behaviour of the base class should fit with the dervied class.
    // The code smell for LSP is overriding with an empty implementation

    // LSP tell us that inheritance is not always the right solution

    // Further insight which is not directly a part of LSP 
    // Inheritance has tight coupling which can create problems as
    // a class dont fit into the Inheritance hierarchy.
    // "Favour Compoistion over inheritance"
    // Composition has lose coupling with interfaces, more flexibility

    abstract class Animal {
        public int Age { get; set; }
        public abstract void Walk();
    }

    class Fish : Animal {

        public override void Walk() {
            // No implementation, cuz fish cant walk
            // overrriding with an empty implementation is a code smell
        }

        public Fish(int age) {
            Age = age;
        }
    }


}
