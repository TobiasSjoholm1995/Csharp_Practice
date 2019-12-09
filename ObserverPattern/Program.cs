using System;

namespace ObserverPattern {

    class Observable {
        public event EventHandler SomethingHappened;

        public void DoSomething() => SomethingHappened?.Invoke(this, EventArgs.Empty);
    }

    class Observer {
        public void HandleEvent(object sender, EventArgs args) {
            Console.WriteLine("Something happened to " + sender);
        }
    }

    class program {
        static void Main() {
            Observable observable = new Observable();
            Observer observer = new Observer();
            observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();

            Console.ReadKey();
        }
    }
}
