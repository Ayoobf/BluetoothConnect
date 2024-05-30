
using System.Windows;
using System.Windows.Controls;
using BluetoothConnect.Views;
using Hardcodet.Wpf.TaskbarNotification;
// ReSharper disable AssignNullToNotNullAttribute

namespace BluetoothConnect;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private readonly TaskbarIcon? _tbIcon;
    private ConnectAirPodsView? _mainWindow;

    public App()
    {
        _tbIcon = (TaskbarIcon) FindResource("MyNotifyIcon");
    }

    private void App_OnStartup(object sender, StartupEventArgs e)
    {
        _mainWindow = new ConnectAirPodsView();
        _mainWindow.Show();

        if (_tbIcon != null)
        {
            _tbIcon.TrayLeftMouseDown += TrayLeftMouseDown;

            if (_tbIcon.ContextMenu != null)
                if (_tbIcon.ContextMenu.Items[0] is MenuItem openMenuItem)
                    openMenuItem.Click += OpenMenueItem_Click;

            if (_tbIcon.ContextMenu?.Items[1] is MenuItem exitMenuItem) exitMenuItem.Click += ExitMenueItem_Click;
        }
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