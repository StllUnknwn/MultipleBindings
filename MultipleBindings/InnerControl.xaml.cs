using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MultipleBindings
{
    /// <summary>
    /// Interaction logic for InnerControl.xaml
    /// </summary>
    public partial class InnerControl : UserControl
    {
        public InnerControl()
        {
            InitializeComponent();

            ItemsSource = new ObservableCollection<object>() { "Item 1" };
            ItemsSource.Add("Item 2");
        }

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register(nameof(ItemsSource), typeof(ObservableCollection<object>), typeof(InnerControl));
        public ObservableCollection<object> ItemsSource
        {
            get => (ObservableCollection<object>)GetValue(ItemsSourceProperty);
            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}
