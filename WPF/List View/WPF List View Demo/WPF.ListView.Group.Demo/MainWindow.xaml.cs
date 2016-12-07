using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using WPF.ListView.Group.Demo.Models;

namespace WPF.ListView.Group.Demo
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
                    new Employee { ID = 1, Name = "Employee One", Role = "Technical Team Lead" },
                    new Employee { ID = 2, Name = "Employee Two", Role = "Senior Software Developer" },
                    new Employee { ID = 3, Name = "Employee Three", Role = "Software Developer" },
                    new Employee { ID = 4, Name = "Employee Four", Role = "Software Developer" },
                    new Employee { ID = 5, Name = "Employee Five", Role = "Quality Assurance" },
                };

                var view = (CollectionView)CollectionViewSource.GetDefaultView(Employees);
                view.GroupDescriptions.Add(new PropertyGroupDescription("Role"));
            };
        }
    }
}
