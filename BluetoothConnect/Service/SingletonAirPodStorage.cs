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

    public string ReadAirPod()
    {
        try
        {
            string json = File.ReadAllText(FilePath);
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                if (root.TryGetProperty("Address", out JsonElement addressElement))
                {
                    return addressElement.GetString()!;
                }

                Console.WriteLine("Address Property not Found");
                return string.Empty;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return string.Empty;
        }
    }


}