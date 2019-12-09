using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ValueConverter {
    public class BoolToVisibilityConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            bool bVal = (bool)value;
            if (bVal)
                return Visibility.Visible;
            else
                return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            Visibility vVal = (Visibility)value;

            if (vVal == Visibility.Visible)
                return true;
            else
                return false;
        }
    }
}
