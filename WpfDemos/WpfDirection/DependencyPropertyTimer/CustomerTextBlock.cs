using System;
using System.Windows;
using System.Windows.Controls;

namespace DependencyPropertyTimer
{
    public class CustomerTextBlock : TextBlock
    {
        public static DependencyProperty TimeProperty;

        static CustomerTextBlock()
        {
            FrameworkPropertyMetadata frameworkPropertyMetadata = new FrameworkPropertyMetadata();
            frameworkPropertyMetadata.Inherits = true;

            TimeProperty = TimerWindow.TimeProperty.AddOwner(typeof(CustomerTextBlock));
            TimeProperty.OverrideMetadata(typeof(CustomerTextBlock), frameworkPropertyMetadata);
        }

        public CustomerTextBlock() : base()
        {

        }

        public DateTime Timer
        {
            get
            {
                return (DateTime)GetValue(TimeProperty);
            }

            set
            {
                SetValue(TimeProperty, value);
            }
        }
        
    }
}