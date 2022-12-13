using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using DispatcherPriority = System.Windows.Threading.DispatcherPriority;

namespace DependencyPropertyTimer
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {
        public delegate void SetTimeDelegate(DateTime dateTime);

        public static DependencyProperty TimeProperty;
        private Timer _timer;

        public TimerWindow()
        {
            InitializeComponent();
            _timer = new Timer(new TimerCallback(RefreshTime), new AutoResetEvent(false), 
                0, 10000);
        }

        public DateTime Time
        {
            set
            {
                SetValue(TimeProperty, value);
            }

            get
            {
                return (DateTime)GetValue(TimeProperty);
            }
        }

        static void OnTimerPropertyChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            Console.WriteLine(dependencyObject.ToString());
        }

        static bool ValidateTimeValue(object obj)
        {
            DateTime dateTime = (DateTime)obj;
            if (dateTime.Year > 1990 && dateTime.Year < 2200)
            {
                return true;
            }
            return false;
        }

        private void RefreshTime(Object stateInfo)
        {
            SetTimeDelegate setTimeDelegate = SetTimerProperty;
            this.Dispatcher.BeginInvoke(DispatcherPriority.Send, setTimeDelegate, DateTime.Now);
        }

        private void SetTimerProperty(DateTime dateTime)
        {
            this.Time = dateTime;
        }

        static TimerWindow()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.Inherits = true;
            metadata.DefaultValue = DateTime.Now;
            metadata.AffectsMeasure = true;
            metadata.PropertyChangedCallback = OnTimerPropertyChanged;
            TimeProperty = DependencyProperty.Register("Timer", typeof(DateTime), typeof(TimerWindow),
                metadata, ValidateTimeValue);


        }
    }
}
