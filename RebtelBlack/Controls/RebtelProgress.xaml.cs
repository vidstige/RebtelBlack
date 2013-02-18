using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace RebtelBlack.Controls
{
    /// <summary>
    /// Interaction logic for RebtelProgress.xaml
    /// </summary>
    public partial class RebtelProgress : UserControl
    {
        public RebtelProgress()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsActiveProperty =
            DependencyProperty.Register("IsActive", typeof(Boolean), typeof(RebtelProgress), new PropertyMetadata(IsActiveChanged));

        private static void IsActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var thiz = (RebtelProgress)d;
            var animation = (Storyboard)thiz.FindResource("_pulse");
            if ((bool)e.NewValue)
                animation.Begin();
            else
                animation.Stop();
        }
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
    }
}
