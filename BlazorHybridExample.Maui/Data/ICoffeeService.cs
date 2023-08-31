namespace BlazorHybridExample.Maui.Data;

public interface ICoffeeService
{
    Task<IEnumerable<Coffee>> LoadCoffeesAsync();
}