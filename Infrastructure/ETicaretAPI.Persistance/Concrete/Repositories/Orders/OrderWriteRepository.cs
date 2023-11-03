using ETicaretAPI.Application.Repositories.Orders;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Concrete.Contexts;

namespace ETicaretAPI.Persistance.Concrete.Repositories.Orders
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretAPIContext context) : base(context)
        {
        }
    }
}
