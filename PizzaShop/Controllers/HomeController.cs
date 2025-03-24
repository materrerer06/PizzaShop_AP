using Microsoft.AspNetCore.Mvc;
using PizzaShop.Domain.entities;
using PizzaShop.Models;
using System.Diagnostics;

namespace PizzaShop.Controllers
{
    public class HomeController : Controller
    {
        private List<Pizza> GetMenu()
        {
            return new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Title = "Margherita",
                    Description = "Klasyczna w³oska pizza z serem i sosem pomidorowym.",
                    Price = 25.99m,
                    Details = new PizzaDetails
                    {
                        Skladniki = new List<string> { "Ser", "Sos pomidorowy", "Bazylia" },
                        Alergeny = new List<string> { "Gluten", "Laktoza" }
                    }
                },
                new Pizza
                {
                    Id = 1,
                    Title = "Margherita 2",
                    Description = "Klasyczna w³oska pizza z serem i sosem pomidorowym.",
                    Price = 25.99m,
                    Details = new PizzaDetails
                    {
                        Skladniki = new List<string> { "Ser", "Sos pomidorowy", "Bazylia" },
                        Alergeny = new List<string> { "Gluten", "Laktoza" }
                    }
                }
            };
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            var model = new About()
            {
            
            };

            return View(model);
        }
        public IActionResult Menu()
        {
            var menu = GetMenu();
            return View(menu);
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
            new Person()
            {
                FirstName = "Jan",
                LastName = "Nowak"

            },
            new Person()
            {
                FirstName = "Adam",
                LastName = "Kowalski"
            }
            };
        return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
