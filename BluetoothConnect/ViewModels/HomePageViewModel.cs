using System.Collections.ObjectModel;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;
using BluetoothConnect.Services;
using InTheHand.Net;

namespace BluetoothConnect.ViewModels;

public class HomePageViewModel : ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;
    private readonly BluetoothStorageService _storageService;

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;

    public ConnectCommand ConnectCommand { get; }

    public HomePageViewModel()
    {
        _storageService = new BluetoothStorageService();
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();
       ConnectCommand = new ConnectCommand(new BluetoothManager());
       InitializeAsync();
    }

    private async void InitializeAsync()
    {
        var knownDevices = await _storageService.LoadKnownDevicesAsync();

            foreach (var device in knownDevices!)
            {
                Console.WriteLine(device.Name);
            }


        var bluetoothManager = new BluetoothManager();
        var newDevices = await bluetoothManager.GetAvailibleDevices();
        foreach (var device in newDevices)
        {
            _bluetoothDevices.Add(new BluetoothDeviceViewModel(device));
        }

        await _storageService.SaveKnownDevicesAsync(_bluetoothDevices);
    }
}