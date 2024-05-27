using System.Collections.ObjectModel;
using System.Windows.Input;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;

    public ICommand ConnectCommand { get; }

    public HomePageViewModel()
    {
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();
    }

}