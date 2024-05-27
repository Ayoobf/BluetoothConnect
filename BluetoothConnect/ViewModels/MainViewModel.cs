using System.Windows.Input;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class MainViewModel: ViewModelBase
{

    public ViewModelBase CurrentViewModel { get; }
    public ICommand HomeCommand { get; } = null!;
    public ICommand AddDeviceCommand { get; } = null!;
    public ICommand SettingsCommand { get; } = null!;

    public MainViewModel(BluetoothManager btManager)
    {
        CurrentViewModel = new HomePageViewModel();
    }

}