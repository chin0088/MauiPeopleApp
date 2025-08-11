using MauiPeopleApp.Models;

namespace MauiPeopleApp.ViewModels;

public class PersonDetailViewModel : BaseViewModel
{
    private Person? _person;

    public Person? Person
    {
        get => _person;
        set => SetProperty(ref _person, value);
    }

    public PersonDetailViewModel() { }
    public PersonDetailViewModel(Person person)
    {
        Person = person;
    }
}