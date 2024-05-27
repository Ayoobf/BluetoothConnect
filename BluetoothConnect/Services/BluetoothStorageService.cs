using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Services;

public class BluetoothStorageService
{
    private readonly string _filePath = "known_devices.json";

    public async Task<ObservableCollection<BluetoothDeviceViewModel>?> LoadKnownDevicesAsync()
    {
        if (File.Exists(_filePath))
        {
            var json = await File.ReadAllTextAsync(_filePath);
            return JsonSerializer.Deserialize<ObservableCollection<BluetoothDeviceViewModel>>(json);
        }
        return new ObservableCollection<BluetoothDeviceViewModel>();
    }

    public async Task SaveKnownDevicesAsync(ObservableCollection<BluetoothDeviceViewModel> devices)
    {
        var json = JsonSerializer.Serialize(devices);
        await File.WriteAllTextAsync(_filePath, json);
    }

}