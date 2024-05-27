using InTheHand.Net;

namespace BluetoothConnect.Models;

public class BluetoothDevice
// Represents a Bluetooth device
{
    public string Type { get; set; } = null!;
    public string Name { get; set; } = null!;
    public BluetoothAddress Address { get; set; } = null!;
    public bool ConnectionStatus { get; set; }


    public BluetoothDevice(string type, string name, BluetoothAddress address, bool connectionStatus)
    {
        Type = type;
        Name = name;
        Address = address;
        ConnectionStatus = connectionStatus;
    }



}