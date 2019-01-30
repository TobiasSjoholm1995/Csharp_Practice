using System;


namespace Practice.Event {
    class MyObject {

        public EventHandler<GenericEventArgs<String>> Callback;

        //Use the ? operator to verify that Callback is not null, thread safe!
        public void Run() {
            Callback?.Invoke(this, new GenericEventArgs<String>("returned successfully"));
        }

    }
}
