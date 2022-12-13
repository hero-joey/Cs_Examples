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

namespace WpfControlDefaultMultiItemSample
{
    class City
    {
        public String Name { get; set; }
    }

    class  Province
    {
        public String Name { get; set; }
        public List<City> Cities { get; set; }
    }

    class Country
    {
        public String Name { get; set; }
        public List<Province> Provinces { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Country> _countries = new List<Country>()
        {
            new Country()
            {
                Name = "China",
                Provinces = new List<Province>()
                {
                    new Province()
                    {
                        Name = "SiChuan",
                        Cities = new List<City>()
                        {
                            new City()
                            {
                                Name = "Chengdu"
                            },

                            new City()
                            {
                                Name = "MianYang"
                            }
                        }
                    },
                    new Province()
                    {
                        Name = "NingXia",
                        Cities = new List<City>()
                        {
                            new City()
                            {
                                Name = "YinChuan"
                            },
                            new City()
                            {
                                Name = "LongDe"
                            }
                        }
                    }
                }
            }
        };

        public MainWindow()
        {
            InitializeComponent();

            this.TextBox1.SetBinding(TextBox.TextProperty, new Binding("/Name") {Source = _countries });
            this.TextBox2.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Name") { Source = _countries });
            this.TextBox3.SetBinding(TextBox.TextProperty, new Binding("/Provinces/Cities/Name") { Source = _countries });

        }
    }
}
