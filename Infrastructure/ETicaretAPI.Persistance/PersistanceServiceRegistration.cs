using ETicaretAPI.Application.Abtract;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Application.Repositories.Orders;
using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Persistance.Concrete;
using ETicaretAPI.Persistance.Concrete.Contexts;
using ETicaretAPI.Persistance.Concrete.Repositories.Customers;
using ETicaretAPI.Persistance.Concrete.Repositories.Orders;
using ETicaretAPI.Persistance.Concrete.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance
{
    public static class PersistanceServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<ICustomerReadRepository, CustomerReadRepository>();
            services.AddSingleton<IOrderReadRepository, OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository, ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
