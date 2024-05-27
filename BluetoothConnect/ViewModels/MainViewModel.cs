using System.Windows.Input;

namespace BluetoothConnect.ViewModels;

public class MainViewModel: ViewModelBase
{
    public ICommand HomeCommand { get; }
    public ICommand AddDeviceCommand { get; }
    public ICommand SettingsCommand { get; }

    public MainViewModel()
    {

    }

}