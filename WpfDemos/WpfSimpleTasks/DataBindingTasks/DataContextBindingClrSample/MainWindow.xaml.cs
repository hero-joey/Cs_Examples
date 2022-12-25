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

namespace DataContextBindingClrSample
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Student stu = new Student()
            {
                Id = 00320,
                Name = "hero",
                Sex = "male"
            };

            InitializeComponent();
            this.StackPanelMain.DataContext = stu;
        }
    }
}
