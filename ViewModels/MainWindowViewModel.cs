using CommunityToolkit.Mvvm.Input;

namespace AvaloniaBindingTest.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";

    private bool _isChecked;

    public bool IsChecked
    {
        get => _isChecked;
        set
        {
            _isChecked = value;
            OnPropertyChanged();
        }
    }
    public RelayCommand RaisePropertyChangedCommand { get; }
#pragma warning restore CA1822 // Mark members as static

    public MainWindowViewModel()
    {
        RaisePropertyChangedCommand = new RelayCommand(ExecuteRaisePropertyChanged);
    }

    private void ExecuteRaisePropertyChanged()
    {
        OnPropertyChanged(nameof(IsChecked));
    }
}
