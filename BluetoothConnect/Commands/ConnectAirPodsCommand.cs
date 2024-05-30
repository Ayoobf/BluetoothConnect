using BluetoothConnect.Models;
using BluetoothConnect.Service;

namespace BluetoothConnect.Commands;

public class ConnectAirPodsCommand: CommandBase
{
    private readonly SingletonAirPodStorage _stp = new();
    public override void Execute(object? parameter)
    {
        var airPodAddress = _stp.ReadAirPod();
        _  = new BluetoothManager().ConnectToDevice(airPodAddress);

    }
}