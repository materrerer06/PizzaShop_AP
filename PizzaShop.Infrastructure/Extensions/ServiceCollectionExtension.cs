using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaShop.Domain.Interfaces;
using PizzaShop.Infrastructure.Persistance;
using PizzaShop.Infrastructure.Repositories;

namespace PizzaShop.Infrastructure.Extensions
{
    public static 
        
        class ServiceCollectionExtension
    {
        public static void AddInfrastucture(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<PizzaShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PizzaShop")));
            services.AddScoped<PizzaSeeder>();
            services.AddScoped<IPizzaRepository, PizzaRepository>();
        }
    }
}
