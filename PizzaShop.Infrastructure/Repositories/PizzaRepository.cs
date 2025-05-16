using PizzaShop.Domain.Interfaces;
using PizzaShop.Infrastructure.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Infrastructure.Repositories
{
    internal class PizzaRepository : IPizzaRepository
    {
        private readonly PizzaShopDbContext _dbcontext;
        public PizzaRepository(PizzaShopDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task Create(Domain.entities.Pizza pizza)
        {
            _dbcontext.Add(pizza);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
