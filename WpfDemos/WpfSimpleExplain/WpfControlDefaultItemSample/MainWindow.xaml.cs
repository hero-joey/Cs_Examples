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

namespace WpfControlDefaultItemSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> StringList = new List<string>()
        {
            "Tim",
            "Tom",
            "Blog"
        };

        public MainWindow()
        {
            InitializeComponent();

            this.TextBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = StringList });
            this.TextBox2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = StringList, Mode = BindingMode.OneWay });
            this.TextBox3.SetBinding(TextBox.TextProperty, new Binding("/[2]") { Source = StringList, Mode = BindingMode.OneWay });
        }
    }
}
