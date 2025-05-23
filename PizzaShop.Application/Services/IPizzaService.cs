
using PizzaShop.Application.Pizza;

namespace PizzaShop.Application.Services
{
    public interface IPizzaService
    {
        Task Create(PizzaDTO pizzaDto);
        Task<IEnumerable<PizzaDTO>> GetAll();
    }
}