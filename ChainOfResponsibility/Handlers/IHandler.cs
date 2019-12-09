namespace ChainOfResponsibility.Handlers {
    public interface IHandler {
        IHandler SetNext(IHandler handler);
        string Handle(string request);
    }
}
