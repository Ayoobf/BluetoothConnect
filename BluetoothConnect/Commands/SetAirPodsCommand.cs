using BluetoothConnect.Service;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Commands;

public class SetAirPodsCommand: CommandBase
{
    public override void Execute(object? parameter)
    {
        if (parameter is BluetoothDeviceViewModel device)
        {
            SingletonAirPodStorage stb = new SingletonAirPodStorage(device);
            stb.AddAirPod();
        }
    }
}