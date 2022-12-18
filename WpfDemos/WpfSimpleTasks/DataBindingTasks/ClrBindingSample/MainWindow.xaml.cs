using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ClrBindingSample
{
    class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _name;

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }

        }

        private string _sex;
        public string Sex
        {
            get { return _sex;}

            set
            {
                _sex = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sex"));
            }
        }

        public Student(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student _student;

        public MainWindow()
        {
            _student = new Student("ZhangSan", "Female");

            InitializeComponent();

            BindingOperations.SetBinding(this.TextBoxName, TextBox.TextProperty, 
                new Binding("Name")
                {
                    Source = this._student,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                });

            BindingOperations.SetBinding(this.TextBoxSex, TextBox.TextProperty,
                new Binding("Sex")
                {
                    Source = this._student
                });

            BindingOperations.SetBinding(this.TextBlockNameModify, TextBlock.TextProperty,
                new Binding("Name")
                {
                    Source = this._student,
                    Mode = BindingMode.OneWay
                });
        }

        private void ButtonChange_OnClick(object sender, RoutedEventArgs e)
        {
            this._student.Name = this.TextBoxName.Text.Trim();
            this._student.Sex = this.TextBoxSex.Text.Trim();
        }
    }
}
