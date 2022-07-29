using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MultipleBindings
{
    /// <summary>
    /// Interaction logic for OuterControl.xaml
    /// </summary>
    public partial class OuterControl : UserControl
    {
        public OuterControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(ObservableCollection<object>), typeof(OuterControl));
        public int ItemsSource
        {
            get => (int)GetValue(ItemsSourceProperty);
            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}
