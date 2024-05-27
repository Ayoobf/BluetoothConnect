
using BluetoothConnect.Models;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Commands;

public class ConnectCommand(BluetoothManager btManager) : CommandBase
{
    public override void Execute(object? parameter)
    {
        if (parameter is BluetoothDeviceViewModel device)
        {
            BluetoothDevice btDevice = new BluetoothDevice(
                device.Type,
                device.Name,
                device.Address,
                device.ConnectionStatus);
            _ = btManager.ConnectToDevice(btDevice);
        }
    }

}