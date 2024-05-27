using BluetoothConnect.Commands;

namespace BluetoothConnect.ViewModels;

public class ConnectAirPodsViewModel: ViewModelBase
{
    public ConnectAirPodsCommand ConnectAirPodsCommand { get; } = new();
}