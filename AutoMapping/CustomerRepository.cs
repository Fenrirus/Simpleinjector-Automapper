using System;
using System.Collections.Generic;

namespace AutoMapping
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            var cust = new List<Customer>()
           {
           new Customer { LastName = "Redford", FirstName = "Robert", Id = 1 },
           new Customer { LastName = "Presley", FirstName = "Elvis", Id = 2 },
           };
            return cust;
        }
    }
}