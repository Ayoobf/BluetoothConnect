namespace BluetoothConnect.Models;

public class BluetoothDevice
// Represents a Bluetooth device
{
    public BluetoothDevice(string name, string address, bool connectionStatus)
    {
        Name = name;
        Address = address;
        ConnectionStatus = connectionStatus;
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public bool ConnectionStatus { get; set; }
}