using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Domain.Interfaces
{
    public interface IPizzaRepository
    {
        Task Create(Domain.entities.Pizza pizza);
        Task<IEnumerable<Domain.entities.Pizza>> GetAll();
    }
}
