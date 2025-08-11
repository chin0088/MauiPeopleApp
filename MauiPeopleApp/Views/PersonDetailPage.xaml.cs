using MauiPeopleApp.ViewModels;

namespace MauiPeopleApp.Views;

[QueryProperty(nameof(Person), "Person")]
public partial class PersonDetailPage : ContentPage
{
    public PersonDetailPage(PersonDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    public Models.Person Person
    {
        set
        {
            if (BindingContext is PersonDetailViewModel viewModel)
            {
                viewModel.Person = value;
            }
        }
    }
}