using System.Net.Http.Json;
using MauiPeopleApp.Models;

namespace MauiPeopleApp.Services;

public class PersonService
{
    private readonly HttpClient _httpClient;

    public PersonService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Person>> GetPeopleAsync()
    {
        try
        {
            // get your api key from https://reqres.in/signup
            var response = await _httpClient.GetFromJsonAsync<ApiResponse>("https://reqres.in/api/users?api_key=reqres-free-v1");
            return response?.Data ?? new List<Person>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }

    private class ApiResponse
    {
        public List<Person> Data { get; set; } = new List<Person>();
    }
}