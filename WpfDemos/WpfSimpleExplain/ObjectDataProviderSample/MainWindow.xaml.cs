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

namespace ObjectDataProviderSample
{
    class Calculator
    {
        public string Add(string a, string b)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            if (double.TryParse(a, out x) && double.TryParse(b, out y))
            {
                z = x + y;
                return z.ToString();
            }

            return "Input error";
        }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private void SetBinding()
        {
            ObjectDataProvider objectDataProvider = new ObjectDataProvider();
            objectDataProvider.ObjectInstance = new Calculator();
            objectDataProvider.MethodName = "Add";
            objectDataProvider.MethodParameters.Add("100");
            objectDataProvider.MethodParameters.Add("200");

            Binding binding1 = new Binding("MethodParameters[0]")
            {
                Source = objectDataProvider,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                BindsDirectlyToSource = true
            };

            Binding binding2 = new Binding("MethodParameters[1]")
            {
                Source = objectDataProvider,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                BindsDirectlyToSource = true
            };

            Binding bindingResult = new Binding(".")
            {
                Source = objectDataProvider
            };


            this.TextBoxArg1.SetBinding(TextBox.TextProperty, binding1);
            this.TextBoxArg2.SetBinding(TextBox.TextProperty, binding2);
            this.TextBoxResult.SetBinding(TextBox.TextProperty, bindingResult);
        }

        public MainWindow()
        {
            InitializeComponent();
            SetBinding();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider objectDataProvider = new ObjectDataProvider();
            objectDataProvider.ObjectInstance = new Calculator();
            objectDataProvider.MethodName = "Add";
            objectDataProvider.MethodParameters.Add("100");
            objectDataProvider.MethodParameters.Add("200");
            MessageBox.Show(objectDataProvider.Data.ToString());
        }
    }
}
