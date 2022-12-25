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

namespace DataBingTask2
{
    class MyColor : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private SolidColorBrush _colorBrush;

        public SolidColorBrush ColorBrush
        {
            get { return _colorBrush; }
            set
            {
                this._colorBrush = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ColorBrush"));
            }
        }
    }
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyColor _myColor;
        private byte _alpha = 255;
        private byte _red = 255;
        private byte _green = 255;
        private byte _blue = 255;


        public MainWindow()
        {
            _myColor = new MyColor();

            InitializeComponent();

          

            Binding binding = new Binding("ColorBrush")
            {
                Source = this._myColor
            };

            this.RectanglePreview.SetBinding(Shape.FillProperty, binding);
        }

        private void SetColor(byte a, byte r, byte g, byte b)
        {
            this._myColor.ColorBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }


        public void SliderAlphaValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sliderRed = sender as Slider;
            this._alpha = (byte)sliderRed.Value;
            SetColor(_alpha, _red, _green, _blue);
        }

        public void SliderRedValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sliderRed = sender as Slider;
            this._red = (byte)sliderRed.Value;
            SetColor(_alpha, _red, _green, _blue);
        }

        public void SliderGreenValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sliderRed = sender as Slider;
            this._green = (byte)sliderRed.Value;
            SetColor(_alpha, _red, _green, _blue);
        }

        public void SliderBlueValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider sliderRed = sender as Slider;
            this._blue = (byte)sliderRed.Value;
            SetColor(_alpha, _red, _green, _blue);
        }
    }
}
