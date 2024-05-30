
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BluetoothConnect.ViewModels;

public class ViewModelBase : INotifyPropertyChanged
// handles business logic between ui and devices
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}