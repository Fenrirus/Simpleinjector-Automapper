using System;
using System.Collections.Generic;

namespace AutoMapping
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}