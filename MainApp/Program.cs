using MainApp.Data;
using MainApp.Models;

using ContosoPizzaContext context = new();

// Add Veggie Special Pizza
Product veggieSpecial = new()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);

// Add Deluxe Meat Pizza
Product deluxeMeat = new()
{
    Name = "Deluxe Meat Pizza",
    Price = 12.99M
};
context.Products.Add(deluxeMeat);

await context.SaveChangesAsync();