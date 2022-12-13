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

namespace WpfListBoxSample
{
    class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public Employee(string id, string name, string age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return "Id: " + Id + ",Name: " + Name;
        }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Employee> _employees;

        public MainWindow()
        {
            InitializeComponent();

            _employees = new List<Employee>()
            {
                new Employee("J00318", "hero", "32"),
                new Employee("J00319", "dream", "42"),
                new Employee("J00320", "red", "30"),
            };

         
            this.ListBoxEmployee.DisplayMemberPath = "Name";
            this.ListBoxEmployee.SelectedValuePath = "Id";
            this.ListBoxEmployee.ItemsSource = _employees;
        }

        private void ListBoxEmployee_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Employee employee = listBox.SelectedItem as Employee;
            this.TextBlockEmployee.Text = employee.ToString();

            //MessageBox.Show(listBox.SelectedValue.ToString());
            //MessageBox.Show(listBox.SelectedValuePath.ToString());
        }
    }
}
