using System.IO;
using System.Text.Json;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Service;

public class SingletonAirPodStorage
{
    private const string FilePath = "known_device.json";


    public void AddAirPod(BluetoothDeviceViewModel deviceViewModel)
    {
        // Serialize the device information to JSON
        var json = JsonSerializer.Serialize(deviceViewModel);
        // Write the JSON data to a file
        File.WriteAllText(FilePath, json);
    }

    public BluetoothDeviceViewModel? ReadAirPod()
    {
        string json = File.ReadAllText(FilePath);
        BluetoothDeviceViewModel? retrievedDeviceViewModel = JsonSerializer.Deserialize<BluetoothDeviceViewModel>(json);
        return retrievedDeviceViewModel;
    }

    public static void Test()
    {
        SingletonAirPodStorage stp = new SingletonAirPodStorage();
        var ret = stp.ReadAirPod();
        Console.WriteLine($"{ret?.Name} {ret?.ConnectionStatus} {ret?.Address}");
    }


}