namespace MauiPeopleApp.Models;

public class Person
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string First_Name { get; set; } = string.Empty;
    public string Last_Name { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;

    public string FullName => $"{First_Name} {Last_Name}";
}