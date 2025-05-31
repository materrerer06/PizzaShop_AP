using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "Owner")]
public class PizzaController : Controller
{
    // ...reszta kodu
}