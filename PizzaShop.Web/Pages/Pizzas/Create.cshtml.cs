using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "Owner")]
public class CreateModel : PageModel
{
    // ...reszta kodu
}