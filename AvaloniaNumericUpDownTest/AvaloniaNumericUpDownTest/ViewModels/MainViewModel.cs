using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaNumericUpDownTest.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    public double myValue = 123.5;

    [ObservableProperty]
    public double pickedValue = 9876.5432;
}
