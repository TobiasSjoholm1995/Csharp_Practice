using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands {
    public class MainViewModel {

        public RelayCommand ClickCommand { get; internal set; }

        public MainViewModel() {
            ClickCommand = new RelayCommand(ClickCommandExecute, ClickCommandCanExcute);
        }

        private bool ClickCommandCanExcute(object obj) {
            return true;
        }

        private void ClickCommandExecute(object obj) {
            System.Windows.Forms.MessageBox.Show("You directly entered the backend code with a command");
        }
    }
}