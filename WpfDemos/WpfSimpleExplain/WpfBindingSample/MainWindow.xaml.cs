using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
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

namespace WpfBindingSample
{
    class Student : INotifyPropertyChanged
    {
        private string _name;
        public string Name {
            get { return _name; }

            set
            {
                _name = value; 
                if(PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student _student;

        public MainWindow()
        {
            InitializeComponent();
            _student = new Student();
            _student.Name = "hero";

            Binding binding = new Binding("Name");
            binding.Source = _student;

            BindingOperations.SetBinding(this.TextBoxName, TextBox.TextProperty, binding);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this._student.Name += "Name";
        }
    }
}
