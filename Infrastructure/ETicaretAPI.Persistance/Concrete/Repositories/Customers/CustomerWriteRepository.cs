using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Concrete.Contexts;

namespace ETicaretAPI.Persistance.Concrete.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretAPIContext context) : base(context)
        {
        }
    }
}
