
using System.ComponentModel;
using System.Windows;

namespace BluetoothConnect;

public partial class ConnectAirPodsView
{
    public ConnectAirPodsView()
    {
        InitializeComponent();
        this.StateChanged += ConnectAirPodsView_StateChanged;
        this.Closing += ConnectAirPodsView_Closing;

    }

    private void ConnectAirPodsView_StateChanged(object? sender, EventArgs e)
    {
        if (WindowState == WindowState.Minimized)
        {
            Hide();
        }
    }

    private void ConnectAirPodsView_Closing(object? sender, CancelEventArgs e)
    {
        e.Cancel = true;
        Hide();
    }
}