using System.Windows.Input;

namespace BluetoothConnect.ViewModels;

public class MainViewModel: ViewModelBase
{

    public ViewModelBase CurrentViewModel { get; }
    public ICommand HomeCommand { get; }
    public ICommand AddDeviceCommand { get; }
    public ICommand SettingsCommand { get; }

    public MainViewModel()
    {
        CurrentViewModel = new HomePageViewModel();
    }

}