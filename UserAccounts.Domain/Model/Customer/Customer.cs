using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using CommonObjects.ValueObjects;

namespace UserAccounts.Domain.Model.Customer
{
    public class Customer
    {
        public int Id { get; set; }
        public Address Address{ get; set; }
        public Name Name { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}