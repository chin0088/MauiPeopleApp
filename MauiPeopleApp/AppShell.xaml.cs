using MauiPeopleApp.Views;

namespace MauiPeopleApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        Routing.RegisterRoute("PersonListPage", typeof(PersonListPage));
        Routing.RegisterRoute("PersonDetailPage", typeof(PersonDetailPage));
    }
}