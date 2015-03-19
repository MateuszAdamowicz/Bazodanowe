using CustomerAccounts.Domain.Model.Customer;

namespace CustomerAccounts.Application
{
    public interface ICustomerService
    {
        void SendVerifyEmailCodeToCustomer(Customer customer);
        void AddNewCustomer(Customer customer);


    }
}