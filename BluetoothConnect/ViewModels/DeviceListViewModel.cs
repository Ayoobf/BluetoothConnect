using System.Collections.ObjectModel;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;
using InTheHand.Net;

namespace BluetoothConnect.ViewModels;

public class DeviceListViewModel: ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;
    public SetAirPodsCommand SetAirPodsCommand { get; } = new();

    public DeviceListViewModel()
    {
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();
        InitializeAsync();
    }

    private async void InitializeAsync()
    {
        var bluetoothManager = new BluetoothManager();
        var newDevices = await bluetoothManager.GetAvailableDevices();
        foreach (var device in newDevices)
        {
            _bluetoothDevices.Add(new BluetoothDeviceViewModel(device));

        }
    }
}