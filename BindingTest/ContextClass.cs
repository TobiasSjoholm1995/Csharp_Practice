using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingTest;

namespace Practice.BindingTest {
    public class ContextClass : NotificationObject
    {
        private string name;
        public string Name
        {
            get => name; 
            set => RaisePropertyChanged(ref name, value); 
        }

        public ContextClass()
        {
            Name = "Test Binding";
        }
    }
}
