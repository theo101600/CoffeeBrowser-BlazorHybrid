namespace CoffeeBrowser.Maui.Components.Data;

public class CoffeeService : ICoffeeService
{
    public async Task<IEnumerable<Coffee>> LoadCoffeeAsync()
    {
        var coffees = new[]
        {
            new Coffee("Espresso", "A strong and concentrated coffee brewed by forcing hot water through finely-ground coffee beans."),
            new Coffee("Americano", "A diluted espresso made by adding hot water to a shot of espresso."),
            new Coffee("Cappuccino", "A coffee drink made with equal parts espresso, steamed milk, and milk foam."),
            new Coffee("Latte", "A coffee drink made with espresso and steamed milk, topped with a small amount of milk foam."),
            new Coffee("Mocha", "A chocolate-flavored coffee drink made with espresso, steamed milk, and chocolate syrup."),
            new Coffee("Macchiato", "An espresso with a small amount of steamed milk or milk foam added on top."),
            new Coffee("Flat White", "A coffee drink made with espresso and steamed milk, similar to a latte but with less foam."),
            new Coffee("Irish Coffee", "A cocktail made with hot coffee, Irish whiskey, sugar, and topped with cream."),
        };
        // Simulate an asynchronous operation
        await Task.Delay(1000);
        return coffees;
    }
}
