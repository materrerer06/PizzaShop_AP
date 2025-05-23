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
        public async Task<IActionResult> Index()
        {

            var pizza = await _pizzaService.GetAll();
            return View(pizza);
        }



        [HttpPost]
        public async Task<ActionResult> Create(PizzaDTO pizza)
        {
            if (ModelState.IsValid)
            {
                return View(pizza);
            }



            await _pizzaService.Create(pizza);
            return RedirectToAction(nameof(Create));
        }
    }
}
