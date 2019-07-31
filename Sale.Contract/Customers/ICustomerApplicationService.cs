using Sale.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Contract.Customers
{
    public interface ICustomerApplicationService
    {
        object SubmitCustomer(Customer customer);
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        object UpdateCustomer(Customer customer);
        object DeleteCustomer(int id);
    }
}
