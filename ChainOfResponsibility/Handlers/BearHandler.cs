using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers {
    public class BearHandler : BaseHandler {

        public override string Handle(string request) {
            if (request.Equals("Salmon"))
                return "Bear";
            else
                return base.Handle(request);
        }

    }
}
