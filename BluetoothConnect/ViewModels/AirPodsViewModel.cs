using BluetoothConnect.Commands;

namespace BluetoothConnect.ViewModels;

public class AirPodsViewModel: ViewModelBase
{
    public ConnectAirPodsCommand ConnectAirPodsCommand { get; } = new();
    public SelectAirPodsCommand SelectAirPodsCommand { get; } = new();
}