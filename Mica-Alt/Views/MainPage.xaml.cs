using Mica_Alt.Contracts.Services;
using Mica_Alt.ViewModels;
using Microsoft.UI.Xaml; 
using Microsoft.UI.Xaml.Controls;

namespace Mica_Alt.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        var navigationService = App.GetService<INavigationService>();
        navigationService.NavigateTo(typeof(SettingsViewModel).FullName!);
    }
}
