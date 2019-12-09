using System;

namespace ChainOfResponsibility.Handlers {
    public class DogHandler : BaseHandler {

        public override string Handle(string request) {
            if (request.Equals("MeatBall")) 
                return "Dog";
            else 
                return base.Handle(request);
        }

    }
}
