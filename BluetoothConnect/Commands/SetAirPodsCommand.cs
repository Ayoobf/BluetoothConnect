using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Commands;

public class SetAirPodsCommand: CommandBase
{
    public override void Execute(object? parameter)
    {
        if (parameter is BluetoothDeviceViewModel device)
        {
            Console.WriteLine($"Selected {device.Name}");
        }
    }
}