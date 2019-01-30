using System;
using System.ComponentModel;
using System.Linq.Expressions;

//if you copy this class, remember to change the namespace

namespace Practice.BindingTest {
    public class NotificationObject : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
