using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Concrete.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concrete.Repositories.Customers
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIContext context) : base(context)
        {
        }
    }
}
