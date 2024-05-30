using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class DeviceListViewModel : ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;
    private string? _statusText;

    public DeviceListViewModel()
    {
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();

        // TODO Temp fix for reactiveness for searching for bluetooth devices
        StatusText = "Searching for bluetooth devices...";

        InitializeAsync();
    }

    public string? StatusText
    {
        get => _statusText;
        private set
        {
            _statusText = value;
            OnPropertyChanged();
        }
    }

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;
    public SetAirPodsCommand SetAirPodsCommand { get; } = new();

    private async void InitializeAsync()
    {
        var bluetoothManager = new BluetoothManager();
        var newDevices = await bluetoothManager.GetAvailableDevices();
        foreach (var device in newDevices) _bluetoothDevices.Add(new BluetoothDeviceViewModel(device));

        if (_bluetoothDevices.Count == 0)
        {
            StatusText = "No devices found.";
        }
        else
        {
            StatusText = string.Empty;
        }
    }
}