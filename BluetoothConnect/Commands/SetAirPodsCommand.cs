using System.Windows;
using BluetoothConnect.Service;
using BluetoothConnect.ViewModels;

namespace BluetoothConnect.Commands;

public class SetAirPodsCommand: CommandBase
{

    public override void Execute(object? parameter)
    {
        if (parameter is BluetoothDeviceViewModel device)
        {
            SingletonAirPodStorage stb = new SingletonAirPodStorage();
            stb.AddAirPod(device);

            // Close on press
            var currentWindow = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            currentWindow?.Close();
        }
    }
}