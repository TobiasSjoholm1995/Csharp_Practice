using System;

namespace FacadePattern {
    public class CarFacade {
        private Engine engine;
        private SubEngine subEngine;
        private Body body;
        private Tires tires;

        public CarFacade() {
            tires = new Tires();
            subEngine = new SubEngine();
            body = new Body();

            // Handle the injection, in some cases these dependencies and injection are complexed. 
            // So handling everything in the facade makes it easer for client.
            engine = new Engine(subEngine);
 
        }

        public void CreateCompleteCar() {
            Console.WriteLine("********** Creating Car **********\n");
            tires.SetTires();
            engine.SetEngine();
            body.SetBody();

            Console.WriteLine("\n********** Car  complete **********");
        }
    }
}
