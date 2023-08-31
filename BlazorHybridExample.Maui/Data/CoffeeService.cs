namespace BlazorHybridExample.Maui.Data;

public class CoffeeService : ICoffeeService
{
    public async Task<IEnumerable<Coffee>> LoadCoffeesAsync()
    {
        var coffees = new[]
        {
            new  Coffee("Cappuccino", "Coffee with milk foam"),
            new  Coffee("Doppio", "Double espresso"),
        };

        await Task.Delay(2000);

        return coffees;
    }
}
