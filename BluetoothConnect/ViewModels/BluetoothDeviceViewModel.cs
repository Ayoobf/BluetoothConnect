using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class BluetoothDeviceViewModel: ViewModelBase
{
    private readonly BluetoothDevice _device;

    public string Type => _device.Type;
    public string Name => _device.Name;
    public string Address => _device.Address;
    public bool ConnectionStatus => _device.ConnectionStatus;

    public BluetoothDeviceViewModel(BluetoothDevice device)
    {
        _device = device;
    }
}