using System.Windows.Input;
using BluetoothConnect.Models;

namespace BluetoothConnect.ViewModels;

public class MainViewModel: ViewModelBase
{
    public ViewModelBase CurrentViewModel { get; }

    public MainViewModel(BluetoothManager btManager)
    {
        CurrentViewModel = new HomePageViewModel();
    }

}