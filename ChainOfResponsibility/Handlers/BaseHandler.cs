using System;

namespace ChainOfResponsibility.Handlers {

    public class BaseHandler : IHandler {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler) {
            _nextHandler = handler;
            return handler;  // Returning a handler will let us link handlers, fluent
        }

        //default implementation
        public virtual string Handle(string request) => this._nextHandler?.Handle(request);
    }
}
