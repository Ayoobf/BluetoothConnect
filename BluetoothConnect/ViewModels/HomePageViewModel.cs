using System.Collections.ObjectModel;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;

    public ConnectCommand ConnectCommand { get; }

    public HomePageViewModel()
    {
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>
        {
            new(new BluetoothDevice("Bt", "Device5", "Address1", true)),
            new(new BluetoothDevice("Apple", "Daaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaevice2", "Address2", false)),
            new(new BluetoothDevice("Type3", "Device3", "Address3", true))
        };
        ConnectCommand = new ConnectCommand();
    }

}