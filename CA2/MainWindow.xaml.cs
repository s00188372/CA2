﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string EmployeeTime = "";
        public static decimal FtSalary;

        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Employee> FilteredEmployees = new ObservableCollection<Employee>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Employee emp1 = new Employee("Jane", "Jones", "Full Time",100000, 5,12.5);
            Employee emp2 = new Employee("Bob", "Reilly", "Full Time", 150000,5,12.5);
            Employee emp3 = new Employee("Joe", "Murphy", "Part Time", 9000,5,12.5);

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

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
            string FirstName = tbxFirstName.Text;
            string LastName = tbxLastName.Text;
            decimal Hours = Convert.ToInt32(tbxHoursWorked.Text);
            double Rate = Convert.ToInt32(tbxHourlyRate.Text);
            FtSalary = Convert.ToInt32(tbxSalary.Text);


            string FullTime = "Full Time";
            if (rbtFT.IsChecked == true)
            {
                EmployeeTime = FullTime;
            }
            else
            {
                EmployeeTime = "Part Time";
            }


            //Create Object
            Employee employee = new Employee(FirstName, LastName, EmployeeTime,FtSalary, Hours,Rate );


            //Add to observable collection
            employees.Add(employee);


        }

        private void lbxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Checking what has been selected
            Employee selectedEmployee = lbxEmployees.SelectedItem as Employee;

            //Check it is not null
            if (selectedEmployee != null)
            {
                tbxFirstName.Text = selectedEmployee.FirstName;
                tbxLastName.Text = selectedEmployee.LastName;

                if(selectedEmployee.EmployeeTime == "Full Time")
                {
                    rbtFT.IsChecked = true;
                    decimal pay = (selectedEmployee.FullTimeSalary / 12);
                    tblkPay.Text = pay.ToString();
                    tbxSalary.Text = selectedEmployee.FullTimeSalary.ToString();
                }
                else
                {
                    tbxSalary.Text = "";
                    rbtPT.IsChecked = true;
                }

            }

        }

        private void rbtFT_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cbxFullTime_Checked(object sender, RoutedEventArgs e)
        {

            if ((cbxPartTime.IsChecked == true) && (cbxFullTime.IsChecked == true)) //Checking if both are checked
            {
                foreach (Employee employee in employees) //looping through emloyees
                {
                    if (employee.EmployeeTime == "Full Time")
                    {
                        FilteredEmployees.Add(employee);
                    }
                    else if (employee.EmployeeTime == "Part Time")
                    {
                        FilteredEmployees.Add(employee);
                    }
                    FilteredEmployees.Clear();
                }
            }
            //If sequence to check for the employee job time
            else if (cbxFullTime.IsChecked == true) // Check if Full time is ticked
            {
                EmployeeTime = "Full Time";
                foreach (Employee employee in employees) //looping through emloyees
                {
                    if (employee.EmployeeTime == "Full Time")
                    {
                        FilteredEmployees.Add(employee);
                    }
                }
            }
            else if (cbxPartTime.IsChecked == true) //check if part time is ticked
            {
                EmployeeTime = "Part Time";
                foreach (Employee employee in employees) //looping through emloyees
                {
                    if (employee.EmployeeTime == "Part Time")
                    {
                        FilteredEmployees.Add(employee);
                    }
                }
            }
            else
            {
                lbxEmployees.ItemsSource = employees;
            }


            lbxEmployees.ItemsSource = FilteredEmployees;

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            rbtFT.IsChecked = false;
            rbtPT.IsChecked = false;
            tbxHourlyRate.Clear();
            tbxHoursWorked.Clear();
            tbxSalary.Clear();
        }

        private void tblkPay_GotFocus(object sender, RoutedEventArgs e)
        {



        }
    }
}
