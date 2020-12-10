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

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Employee emp1 = new Employee("Jane", "Jones");
            Employee emp2 = new Employee("Joe", "Murphy");

            employees.Add(emp1);
            employees.Add(emp2);

            lbxEmployees.ItemsSource = employees;

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

        //Add Button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            //Reading From inputs
            string firstName = tbxFirstName.Text;
            string LastName = tbxLastName.Text;

            //Create Object
            Employee employee = new Employee(firstName, LastName);


            //Add to observable collection
            employees.Add(employee);

        }
    }
}
