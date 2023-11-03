using ETicaretAPI.Application.Abtract;
using ETicaretAPI.Persistance.Concrete;
using ETicaretAPI.Persistance.Concrete.Contexts;
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
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
