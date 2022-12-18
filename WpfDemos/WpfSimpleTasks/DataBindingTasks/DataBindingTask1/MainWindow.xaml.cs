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

namespace DataBindingTask1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Binding textBind = new Binding("Value")
            {
                Source = this.Slider1,
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            this.TextBox1.SetBinding(TextBox.TextProperty, textBind);

            this.RectangleRed.SetBinding(Rectangle.WidthProperty, textBind);
            this.RectangleRed.SetBinding(Rectangle.HeightProperty, textBind);

        }
    }
}
