
using System.Windows;
using BluetoothConnect.Models;

namespace BluetoothConnect;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly BluetoothManager _btManager;

    public App()
    {
        _btManager = new BluetoothManager();
    }
}