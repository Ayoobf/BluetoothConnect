
using InTheHand.Net;
using InTheHand.Net.Sockets;

namespace BluetoothConnect.Models;

public class BluetoothManager
// Handles Bluetooth Device discovery and connection using 32Feet Library
{
    private static string DefaultGuid => "00001203-0000-1000-8000-00805F9B34FB";
    private static readonly BluetoothClient Client = new();

    public async Task<List<BluetoothDevice>> GetAvailableDevices()
    {

        return await Task.Run(() =>
        {

            var devices = new List<BluetoothDevice>();
            var deviceInfos = Client.DiscoverDevices();
            foreach (var deviceInfo in deviceInfos)
            {
                devices.Add(new BluetoothDevice(
                    type: deviceInfo.ClassOfDevice.ToString(),
                    name: deviceInfo.DeviceName,
                    address: deviceInfo.DeviceAddress,
                    connectionStatus: deviceInfo.Connected
                    ));
            }
            return devices;
        });
    }

    public async Task ConnectToDevice(string deviceAddress)
    {
        await Task.Run(() =>
        {

            try
            {
                Client.Connect(BluetoothAddress.Parse(deviceAddress), new Guid(DefaultGuid));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        });
    }






}