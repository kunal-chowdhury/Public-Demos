﻿using System.Collections.ObjectModel;
using System.Windows;
using WPF.ListView.Demo.Models;

namespace WPF.ListView.Demo
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty EmployeesProperty = DependencyProperty.Register("Employees", typeof(ObservableCollection<Employee>), typeof(MainWindow), new PropertyMetadata(null));

        public ObservableCollection<Employee> Employees
        {
            get { return (ObservableCollection<Employee>)GetValue(EmployeesProperty); }
            set { SetValue(EmployeesProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();

            Loaded += (_, __) =>
            {
                Employees = new ObservableCollection<Employee>
                {
                    new Employee { ID = 1, Name = "Kunal Chowdhury", Role = "Technical Team Lead" },
                    new Employee { ID = 2, Name = "Ranjit Sahoo", Role = "Senior Software Developer" },
                    new Employee { ID = 3, Name = "Sukomal Biswas", Role = "Software Developer" },
                    new Employee { ID = 4, Name = "Prasenjit Sengupta", Role = "Software Developer" },
                    new Employee { ID = 5, Name = "Ramesh Muthaiya", Role = "Quality Assurance" },
                };
            };
        }
    }
}
