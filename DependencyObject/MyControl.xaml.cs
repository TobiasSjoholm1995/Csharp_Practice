using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyObject {
    /// <summary>
    /// Interaction logic for MyControl.xaml
    /// </summary>
    public partial class MyControl : UserControl {
        private const string TEXT =  "Dynamically changing its type to string";

        public MyControl() {
            InitializeComponent();
        }

        public object Secret {
            get { return (object)GetValue(SecretProperty); }
            set { SetValue(SecretProperty, value); }
        }

        public static readonly DependencyProperty SecretProperty = DependencyProperty.Register("Secret", typeof(object), typeof(MyControl), new PropertyMetadata("Default value", propertyChangeCallback));

        private static void propertyChangeCallback(System.Windows.DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var MyControl = d as MyControl;
            //do something call
        }

        private void Spoiler_Click(object sender, RoutedEventArgs e) {
            if(spoilerGrid.Visibility == Visibility.Visible) {
                spoilerGrid.Visibility = Visibility.Collapsed;
                contentGrid.Visibility = Visibility.Visible;
            }
            else if(!Secret.Equals(TEXT)) {
                Secret = "Dynamically changing its type to string";
            }
            else {
                Secret = "Test";
            }
        }
    }
}
