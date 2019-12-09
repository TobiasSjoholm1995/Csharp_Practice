using System;

namespace CommandPattern {

    /// <summary>
    /// One command class for every single command
    /// </summary>
    public class Command : ICommand {
        private Receiver _receiver;

        public Command(Receiver receiver) {
            _receiver = receiver;
        }

        /// <summary>
        /// Can be extended with a UnExecute method
        /// </summary>
        public void Execute() {
            _receiver.Action();
        }
    }
}
