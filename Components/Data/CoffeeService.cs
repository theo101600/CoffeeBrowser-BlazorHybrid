using System.Net.Http.Json;

namespace CoffeeBrowser.Maui.Components.Data;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient = new();
    public async Task<IEnumerable<Coffee>?> LoadCoffeeAsync()
    {
        var coffees = await _httpClient.GetFromJsonAsync<IEnumerable<Coffee>>("https://thomasclaudiushuber.com/pluralsight/coffees.json\r\n");
        return coffees;
    }
}
