using System;

namespace Practice.Event {
    class GenericEventArgs<T> : EventArgs {
        public T Value { get; private set; }

        public GenericEventArgs(T value) {
            this.Value = value;
        }
    }
}
