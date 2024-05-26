using System.Windows;
using System.Windows.Controls;
using BluetoothConnect.Models;

namespace BluetoothConnect.Views;

public partial class BluetoothHomePage : UserControl
{
    public BluetoothHomePage()
    {
        InitializeComponent();
    }

    private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        await LoadDevices();
    }

    private async Task LoadDevices()
    {
        var md = new BluetoothManager();
        var list = await md.GetAvailibleDevices();
        foreach (var device in list)
        {
            Console.WriteLine(device.Name);
        }
    }

}