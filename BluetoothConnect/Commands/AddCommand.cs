
using System.Collections.ObjectModel;
using System.Windows.Controls.Primitives;
using BluetoothConnect.Models;
using BluetoothConnect.ViewModels;
using BluetoothConnect.Views;

namespace BluetoothConnect.Commands;

public class AddCommand: CommandBase
{
    private readonly ObservableCollection<BluetoothDeviceViewModel> _bluetoothDevices;

    public AddCommand(ObservableCollection<BluetoothDeviceViewModel> bluetoothDevices)
    {
        _bluetoothDevices = bluetoothDevices;
    }

    public override void Execute(object? parameter)
    {
        var window = new AddDeviceEntry();
        window.Show();
        InitializeAsync();
    }

    private async void InitializeAsync()
    {

        var bluetoothManager = new BluetoothManager();
        var newDevices = await bluetoothManager.GetAvailibleDevices();
        foreach (var device in newDevices)
        {
            _bluetoothDevices.Add(new BluetoothDeviceViewModel(device));
        }
    }
}
