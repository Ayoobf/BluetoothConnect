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

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        var md = new BluetoohManager();
        var list = md.GetAvailibleDevices();
        Console.WriteLine(list);
    }
}