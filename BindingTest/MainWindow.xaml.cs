using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using BindingTest;

namespace Practice.BindingTest {

    public partial class MainWindow : Window
    {
        private ContextClass myContextClass;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myContextClass.Name = "You clicked the button";
        }

        public MainWindow()
        {
            InitializeComponent();

            myContextClass = new ContextClass();
            this.DataContext = myContextClass;
        }

        
    }
}
