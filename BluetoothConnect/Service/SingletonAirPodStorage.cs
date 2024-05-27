using System.IO;
using System.Text.Json;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Service;

public class SingletonAirPodStorage(BluetoothDeviceViewModel deviceViewModel)
{
    private const string FilePath = "known_device.json";

    public void AddAirPod()
    {
        // Serialize the device information to JSON
        var json = JsonSerializer.Serialize(deviceViewModel);


        // Write the JSON data to a file
        File.WriteAllText(FilePath, json);

        Console.WriteLine("Bluetooth device information saved to file.");
        Console.WriteLine(File.ReadAllText(FilePath));
        Console.WriteLine(Path.GetFullPath(FilePath));
    }


}