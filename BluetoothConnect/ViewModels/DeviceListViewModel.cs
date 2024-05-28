using System.Collections.ObjectModel;
using System.Windows.Input;
using BluetoothConnect.Commands;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class DeviceListViewModel: ViewModelBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;

    public IEnumerable<BluetoothDeviceViewModel> BluetoothDevices => _bluetoothDevices;
    public SetAirPodsCommand SetAirPodsCommand { get; }

    public DeviceListViewModel()
    {
        _bluetoothDevices = new ObservableCollection<BluetoothDeviceViewModel>();
        SetAirPodsCommand = new SetAirPodsCommand();
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