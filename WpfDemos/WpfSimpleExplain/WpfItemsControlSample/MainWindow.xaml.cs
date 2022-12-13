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

namespace WpfItemsControlSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonVictor_OnClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DependencyObject dependencyObject1 = VisualTreeHelper.GetParent(btn);
            DependencyObject dependencyObject2 = VisualTreeHelper.GetParent(dependencyObject1);
            DependencyObject dependencyObject3 = VisualTreeHelper.GetParent(dependencyObject2);


            MessageBox.Show(dependencyObject1.GetType().ToString());
            MessageBox.Show(dependencyObject2.GetType().ToString());
            MessageBox.Show(dependencyObject3.GetType().ToString());
        }
    }
}
