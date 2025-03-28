using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PizzaShop.Infrastructure.Persistance;

namespace PizzaShop.Infrastructure.Extensions
{
    public static 
        
        class ServiceCollectionExtension
    {
        public static void AddInfrastucture(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<PizzaShopDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("PizzaShop")));
        }
    }
}
