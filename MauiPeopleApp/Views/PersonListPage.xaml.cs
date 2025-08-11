using MauiPeopleApp.Models;
using MauiPeopleApp.ViewModels;

namespace MauiPeopleApp.Views;

public partial class PersonListPage : ContentPage
{
    private PersonListViewModel ViewModel => BindingContext as PersonListViewModel;

    public PersonListPage()
    {
        InitializeComponent();
        BindingContext = new PersonListViewModel();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (ViewModel != null && ViewModel.People.Count == 0)
        {
            await ViewModel.LoadPeopleAsync();
        }
    }
    
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection?.FirstOrDefault() is Person selectedPerson)
        {
            await Shell.Current.GoToAsync($"PersonDetailPage", new Dictionary<string, object>
            {
                ["Person"] = selectedPerson
            });
            
            ((CollectionView)sender).SelectedItem = null;
        }
    }


}