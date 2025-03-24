using Microsoft.AspNetCore.Mvc;
using PizzaShop.Domain.entities;

namespace PizzaShop.Controllers
{
    public class MenuController : Controller
    {
        private List<Pizza> GetMenu()
        {
            return new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Title = "Margherita",
                    Description = "Klasyczna włoska pizza z serem i sosem pomidorowym.",
                    Price = 25.99m,
                    Details = new PizzaDetails
                    {
                        Skladniki = new List<string> { "Ser", "Sos pomidorowy", "Bazylia" },
                        Alergeny = new List<string> { "Gluten", "Laktoza" }
                    }
                },
                new Pizza
                {
                    Id = 2,
                    Title = "Pepperoni",
                    Description = "Pikantna pizza z plasterkami pepperoni.",
                    Price = 29.99m,
                    Details = new PizzaDetails
                    {
                        Skladniki = new List<string> { "Ser", "Sos pomidorowy", "Pepperoni" },
                        Alergeny = new List<string> { "Gluten", "Laktoza" }
                    }
                },
                new Pizza
                {
                    Id = 3,
                    Title = "Capricciosa",
                    Description = "Pizza z szynką i pieczarkami.",
                    Price = 30.99m,
                    Details = new PizzaDetails
                    {
                        Skladniki = new List<string> { "Szynka", "Pieczarki", "Ser", "Sos pomidorowy" },
                        Alergeny = new List<string> { "Gluten", "Laktoza" }
                    }
                }
            };
        }

        public IActionResult Menu()
        {
                var menu = GetMenu();

                // Logowanie przed przekazaniem danych do widoku
                if (menu == null || !menu.Any())
                {
                    // Jeśli menu jest puste, możemy to sprawdzić i wyświetlić odpowiedni komunikat
                    Console.WriteLine("Menu is null or empty");
                }

                return View(menu);
            }

        
    }
}
