using System.Collections.ObjectModel;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;
using BluetoothConnect.Services;

namespace BluetoothConnect.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;
    private readonly BluetoothStorageService _storageService;

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;

    public ConnectCommand ConnectCommand { get; }
    public AddCommand AddCommand { get; }

    public HomePageViewModel()
    {
        _storageService = new BluetoothStorageService();
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();
       ConnectCommand = new ConnectCommand(new BluetoothManager());
       AddCommand = new AddCommand();
       InitializeAsync();
    }

    private async void InitializeAsync()
    {

        var bluetoothManager = new BluetoothManager();
        var newDevices = await bluetoothManager.GetAvailibleDevices();
        foreach (var device in newDevices)
        {
            _bluetoothDevices.Add(new BluetoothDeviceViewModel(device));
        }
    }
}