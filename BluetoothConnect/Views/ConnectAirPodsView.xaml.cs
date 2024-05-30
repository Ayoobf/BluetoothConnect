using System.ComponentModel;
using System.Windows;

namespace BluetoothConnect.Views;

public partial class ConnectAirPodsView
{
    public ConnectAirPodsView()
    {

        this.StateChanged += ConnectAirPodsView_StateChanged;
        this.Closing += ConnectAirPodsView_Closing;
        InitializeComponent();

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