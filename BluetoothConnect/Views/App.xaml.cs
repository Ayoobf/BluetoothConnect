using System.Windows;
using System.Windows.Controls;
using BluetoothConnect.Commands;
using Hardcodet.Wpf.TaskbarNotification;

// ReSharper disable AssignNullToNotNullAttribute

namespace BluetoothConnect.Views;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private TaskbarIcon? _tbIcon;
    private ConnectAirPodsView? _mainWindow;

    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        _mainWindow = new ConnectAirPodsView();
        _mainWindow.Show();

        _tbIcon = (TaskbarIcon) FindResource("MyNotifyIcon");

        if (_tbIcon != null)
        {
            _tbIcon.TrayLeftMouseDown += TrayLeftMouseDown;
            if (_tbIcon.ContextMenu?.Items[0] is MenuItem connectDeviceMenuItem) connectDeviceMenuItem.Click += ConnectDeviceMenuItem_Click;

            if (_tbIcon.ContextMenu != null)
                if (_tbIcon.ContextMenu.Items[1] is MenuItem openMenuItem)
                    openMenuItem.Click += OpenMenueItem_Click;

            if (_tbIcon.ContextMenu?.Items[2] is MenuItem exitMenuItem) exitMenuItem.Click += ExitMenueItem_Click;


        }
    }

    private void ConnectDeviceMenuItem_Click(object sender, RoutedEventArgs e)
    {
        new ConnectAirPodsCommand().Execute(this);
    }

    private void OpenMenueItem_Click(object sender, RoutedEventArgs e)
    {
        ShowMainWindow();
    }

    private void ExitMenueItem_Click(object sender, RoutedEventArgs e)
    {
        _mainWindow?.Close();
        Shutdown();
    }

    private void TrayLeftMouseDown(object sender, RoutedEventArgs e)
    {
        ShowMainWindow();
    }

    private void ShowMainWindow()
    {
        _mainWindow?.Show();
        if (_mainWindow != null)
        {
            _mainWindow.WindowState = WindowState.Normal;
        }
    }
}