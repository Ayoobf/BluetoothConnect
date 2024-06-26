﻿using InTheHand.Net;

namespace BluetoothConnect.Models;

public class BluetoothDevice
// Represents a Bluetooth device
{
    public string Type { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public bool ConnectionStatus { get; set; }


    public BluetoothDevice(string type, string name, BluetoothAddress address, bool connectionStatus)
    {
        Type = type;
        Name = name;
        Address = address.ToString();
        ConnectionStatus = connectionStatus;
    }



}