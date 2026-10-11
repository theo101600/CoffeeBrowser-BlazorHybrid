namespace CoffeeBrowser.Maui.Components.Data;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>> LoadCoffeeAsync();
}
