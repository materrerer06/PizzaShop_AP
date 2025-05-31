using PizzaShop.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Infrastructure.Seeders
{
    public class PizzaSeeder
    {
        private readonly PizzaShopDbContext _context;
        public PizzaSeeder(PizzaShopDbContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            if (await _context.Database.CanConnectAsync())
            {
                if (!_context.Pizzas.Any())
                {
                    var pizzas = new List<Domain.entities.Pizza>
                    {
                        new Domain.entities.Pizza
                        {
                            Id = 1, // Dodano wymagane ustawienie Id
                            Title = "Pizza",
                            Description = "Margarita",
                            Price = 10.99m,
                            Details = new Domain.entities.PizzaDetails
                            {
                                Skladniki = new List<string> { "Tomato", "Cheese", "Basil" },
                                opis = "Medium"
                            }
                        }
                    };

                    pizzas.ElementAt(0).EncodeTitle();
                    _context.Pizzas.AddRange(pizzas);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
}
