using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapping
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}