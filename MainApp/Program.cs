using MainApp.Data;
using MainApp.Models;

using ContosoPizzaContext context = new();

var veggieSpecial = context.Products
    .Where(p => p.Name == "Veggie Special Pizza")
    .FirstOrDefault();

if (veggieSpecial != null)
{
    context.Remove(veggieSpecial);
}

await context.SaveChangesAsync();

// LINQ Query instead of Fluent API syntax
var products = from Product in context.Products
               where Product.Price > 10.00m
               orderby Product.Name
               select Product;

foreach (Product p in products)
{
    Console.WriteLine($"Id: {p.Id}");
    Console.WriteLine($"Name: {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));

}

// Tutorial source: https://www.youtube.com/watch?v=SryQxUeChMc&list=PLdo4fOcmZ0oX7uTkjYwvCJDG2qhcSzwZ6