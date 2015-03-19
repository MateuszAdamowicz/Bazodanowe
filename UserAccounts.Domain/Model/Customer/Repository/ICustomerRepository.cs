using System.Collections.Generic;

namespace CustomerAccounts.Domain.Model.Customer.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        int Add(Customer customer);
        int Delete(int customerId);
        Customer Find(int customerId);
    }
}