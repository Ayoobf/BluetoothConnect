namespace BluetoothConnect.Commands;

public class SelectAirPodsCommand: CommandBase
{
    public override void Execute(object? parameter)
    {
        var deviceListWindow = new DeviceListView();
        deviceListWindow.Show();
    }

}