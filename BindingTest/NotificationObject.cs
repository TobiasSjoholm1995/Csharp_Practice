using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

//if you copy this class, remember to change the namespace

namespace Practice.BindingTest {
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            //Only raise if the value has changed
            if (EqualityComparer<T>.Default.Equals(field, value)) 
                return;

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    




        //just an idea, se below

        //overload with an action, just for fun. Used when there is logic related to the change of the propety
        protected void RaisePropertyChanged<T>(ref T field, T value, Action OnChanging, Action OnChanged, [CallerMemberName]string propertyName = null) 
        {
            //Only raise if the value has changed
            if (EqualityComparer<T>.Default.Equals(field, value))
                return;

            OnChanging?.Invoke();

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            OnChanged?.Invoke(); 
        }

    }
}
