using System;

namespace CommandPattern {

    /// <summary>
    /// Example: Bank Transaction manager, where commmands are like: Add, Withdraw..
    /// </summary>
    public class Invoker {
        private ICommand _command;

        public void SetCommand(ICommand command) {
            this._command = command;
        }

        public void ExecuteCommand() {
            _command.Execute();
        }

    }
}
