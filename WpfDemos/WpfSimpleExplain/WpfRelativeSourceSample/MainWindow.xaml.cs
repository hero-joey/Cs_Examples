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

namespace WpfRelativeSourceSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RelativeSource relativeSource = new RelativeSource(RelativeSourceMode.FindAncestor);
            relativeSource.AncestorLevel = 2;
            relativeSource.AncestorType = typeof(Grid);


            Binding binding = new Binding("Name")
            {
                RelativeSource = relativeSource
            };

            this.TextBox1.SetBinding(TextBox.TextProperty, binding);


            RelativeSource relativeSource2 = new RelativeSource(RelativeSourceMode.Self);
            Binding binding2 = new Binding("Name")
            {
                RelativeSource = relativeSource2
            };

            this.TextBox2.SetBinding(TextBox.TextProperty, binding2);
        }
    }
}
