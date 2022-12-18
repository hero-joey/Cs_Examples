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

namespace TextBindingSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.TextBlockLen.SetBinding(TextBlock.TextProperty,
                new Binding("Text.Length")
                {
                    Source = this.TextBoxInput
                });

            this.TextBlockChar.SetBinding(TextBlock.TextProperty,
                new Binding("Text[3]")
                {
                    Source = this.TextBoxInput
                });

            this.TextBlockFont.SetBinding(TextBlock.TextProperty,
                new Binding("Text")
                {
                    Source = this.TextBoxInput
                });
        }


    }
}
