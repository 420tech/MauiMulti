using CommunityToolkit.Mvvm.Input;

namespace MauiMulti.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    string _title;

    [ObservableProperty]
    bool _isBusy;

    [RelayCommand]
    async void GoToStart()
    {
        await Shell.Current.GoToAsync(nameof(StartPage));
    }

    [RelayCommand]
    async void GoToDetail()
    {
        await Shell.Current.GoToAsync(nameof(DetailPage));
    }

    [RelayCommand]
    async void Exit()
    {
        Application.Current?.CloseWindow(App.Current.MainPage.Window);
    }
}

