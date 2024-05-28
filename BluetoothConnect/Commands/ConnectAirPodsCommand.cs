using BluetoothConnect.Models;
using BluetoothConnect.Service;

namespace BluetoothConnect.Commands;

public class ConnectAirPodsCommand: CommandBase
{
    private readonly SingletonAirPodStorage _stp = new SingletonAirPodStorage();
    public override void Execute(object? parameter)
    {
        var airpodAddress = _stp.ReadAirPod();
        _ = new BluetoothManager().ConnectToDevice(airpodAddress);
    }
}