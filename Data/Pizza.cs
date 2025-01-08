namespace BlazingPizza.Data;

public class Pizza
{
    public int PizzaId { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }
}

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
        var pizzas = new[]
        {
            new Pizza { PizzaId = 1, Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", Price = 11.99M, Vegetarian = false, Vegan = false },
            new Pizza { PizzaId = 2, Name = "Buffalo chicken", Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Price = 12.75M, Vegetarian = false, Vegan = false },
            new Pizza { PizzaId = 3, Name = "Veggie Delight", Description = "It's like salad, but on a pizza", Price = 11.5M, Vegetarian = true, Vegan = false },
            new Pizza { PizzaId = 4, Name = "Margherita", Description = "Traditional Italian pizza with tomatoes and basil", Price = 9.99M, Vegetarian = true, Vegan = false },
            new Pizza { PizzaId = 5, Name = "Basic Cheese Pizza", Description = "It's cheesy and delicious. Why wouldn't you want one?", Price = 11.99M, Vegetarian = true, Vegan = false },
            new Pizza { PizzaId = 6, Name = "Classic pepperoni", Description = "It's the pizza you grew up with, but Blazing hot!", Price = 10.5M, Vegetarian = false, Vegan = false }
        };

        return Task.FromResult(pizzas);
    }
}