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

namespace WpfListBoxTemplateSample
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Student> _students = new List<Student>()
        {
            new Student() {Id = 0, Name = "Tim", Age = 27},
            new Student() {Id = 1, Name = "Tom", Age = 28},
            new Student() {Id = 2, Name = "Mike", Age = 30},
            new Student() {Id = 3, Name = "Alice", Age = 22},
        };


        public MainWindow()
        {
            InitializeComponent();

            this.StudentList.ItemsSource = _students;

            Binding binding = new Binding("SelectedItem.Id") { Source = this.StudentList };
            this.TextBoxId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
