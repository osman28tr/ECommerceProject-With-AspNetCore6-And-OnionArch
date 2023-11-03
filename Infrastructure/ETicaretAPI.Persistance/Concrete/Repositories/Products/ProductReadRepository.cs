using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concrete.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretAPIContext context) : base(context)
        {
        }
    }
}
