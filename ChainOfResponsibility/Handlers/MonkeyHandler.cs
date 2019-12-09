using System;

namespace ChainOfResponsibility.Handlers {
    public class MonkeyHandler : BaseHandler {

        public override string Handle(string request) {
            if (request.Equals("Banana"))
                return "Monkey";
            else 
                return base.Handle(request);
        }
    }
}
