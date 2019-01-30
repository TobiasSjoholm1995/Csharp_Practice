using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Practice.Responsiveness {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }


        //Multi threading also have responsiveness, but the created thread cannot access frontend elements
        //it was faster as well
        private void ThreadButton_Click(object sender, RoutedEventArgs e) { new Thread(myTask).Start(); }

        private void AsyncButton_Click(object sender, RoutedEventArgs e) { Task<int> task = asyncTask(); }

        private void NormalButton_Click(object sender, RoutedEventArgs e) { myTask(); }



        void myTask() {
            string file = @"../../test.txt"; //big file
            int j, i = 0;

            using (StreamReader reader = new StreamReader(file)) {
                string v = reader.ReadToEnd();

                //dummy code
                for (j = 0; j < 500; j++)
                    for (i = 0; i < v.Length; i++)
                        i += v[i];
            }
        }

        private async Task<int> asyncTask() {
            string file = @"../../test.txt"; //big file
            int j, i = 0;

            using (StreamReader reader = new StreamReader(file)) {
                string v = await reader.ReadToEndAsync();    //this will NOT impact responsiveness

                //dummy code, this will impact responsiveness
                for (j = 0; j < 500; j++)
                    for (i = 0; i < v.Length; i++)
                        i += v[i];
            }
            return i;
        }

    }
}