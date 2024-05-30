
using System.Windows;
using BluetoothConnect.Models;
using Hardcodet.Wpf.TaskbarNotification;

namespace BluetoothConnect;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private readonly BluetoothManager _btManager = new();
    private TaskbarIcon? _tbIcon;
    private ConnectAirPodsView _mainWindow;

    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        ConnectAirPodsView mainView = new ConnectAirPodsView();
        mainView.Show();

        _tbIcon = (TaskbarIcon) FindResource("MyNotifyIcon");
    }




}