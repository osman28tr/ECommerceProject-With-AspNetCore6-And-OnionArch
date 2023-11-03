using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Concrete.Contexts;

namespace ETicaretAPI.Persistance.Concrete.Repositories.Products
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIContext context) : base(context)
        {
        }
    }
}
