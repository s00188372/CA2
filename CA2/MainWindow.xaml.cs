using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<string> names = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //First Name Text Box
        private void tbxFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxFirstName.Clear();
        }

        //Last Name Next Box
        private void tbxLastName_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxLastName.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
