
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Commands;

public class AddDeviceCommand : CommandBase
{
    private readonly string _filepath = "known_devices.json";
    private readonly ObservableCollection<BluetoothDeviceViewModel> _devices;

    public AddDeviceCommand(ObservableCollection<BluetoothDeviceViewModel> devices)
    {
        this._devices = devices;
    }

    public override void Execute(object? parameter)
    {
        if (parameter is BluetoothDeviceViewModel device)
        {
            Console.WriteLine($"Hello {device.Name}");
            _devices.Add(device);
            SaveDevicesAsync(_devices).Wait();
        }
    }

    private async Task SaveDevicesAsync(ObservableCollection<BluetoothDeviceViewModel> devices)
    {
        var json = JsonSerializer.Serialize(devices);
        await File.WriteAllTextAsync(_filepath, json);
    }


}