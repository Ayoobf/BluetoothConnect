

namespace BluetoothConnect.Commands;

public class SelectNewAirPodsCommand: CommandBase
{
    public override void Execute(object? parameter)
    {
        var deviceListWindow = new DeviceListView();
        deviceListWindow.Show();
    }

}