using Microsoft.AspNetCore.Mvc;
using PizzaShop.Application.Pizza;
using PizzaShop.Application.Services;

namespace PizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(PizzaDTO pizza)
        {
            await _pizzaService.Create(pizza);
            return RedirectToAction(nameof(Create));
        }
    }
}
