
using System.Net.Sockets;
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

    public async Task ConnectToDevice(BluetoothDevice? bluetoothDevice)
    {
        Console.WriteLine($"Connecting to {bluetoothDevice?.Name}");
        await Task.Run(() =>
        {
            /*var bluetoothAddress = BluetoothAddress.Parse(bluetoothDevice?.Address);
            var bluetoothEndPoint = new BluetoothEndPoint(bluetoothAddress, BluetoothService.SerialPort);
            Client.Connect(bluetoothEndPoint);#2#
            */

            try
            {
                Client.Connect(bluetoothDevice?.Address, new Guid(DefaultGuid));
                Console.WriteLine($"Successfully connected to {bluetoothDevice?.Name}");
            }
            catch (SocketException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        });
    }




}