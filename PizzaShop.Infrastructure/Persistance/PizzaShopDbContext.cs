using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PizzaShop.Infrastructure.Persistance
{
    public class PizzaShopDbContext:DbContext
    {
        public DbSet<Domain.entities.Pizza> Pizzas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.entities.Pizza>().OwnsOne(c=>c.Details);
        }
    }
}
