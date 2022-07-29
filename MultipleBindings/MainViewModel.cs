using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MultipleBindings
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            // Changes from the VM will reflect on the view though.
            //Items = new ObservableCollection<object>();
            //Items.Add("Item from VM");
        }

        private ObservableCollection<object> items;
        public ObservableCollection<object> Items
        {
            get => items;
            set
            {
                items = value;
                onPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
