using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace RebtelBlack
{
    /// <summary>
    /// Interaction logic for HistoryControl.xaml
    /// </summary>
    public partial class HistoryControl : UserControl
    {
        public static readonly DependencyProperty HistoryItemsSourceProperty = DependencyProperty.RegisterAttached("HistoryItemsSource", 
          typeof(IEnumerable), typeof(HistoryControl), 
          new FrameworkPropertyMetadata { PropertyChangedCallback = HistoryItemsSourceChanged});

        private static void HistoryItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var me = (HistoryControl) d;
            me._history.ItemsSource = (IEnumerable) e.NewValue;
        }

        public IEnumerable HistoryItemsSource
        {
            get { return (string)GetValue(HistoryItemsSourceProperty); }
            set { SetValue(HistoryItemsSourceProperty, value); }
        }

        public HistoryControl()
        {
            InitializeComponent();
        }
    }
}
