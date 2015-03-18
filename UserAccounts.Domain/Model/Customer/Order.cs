using System;
using CommonObjects.ValueObjects;

namespace UserAccounts.Domain.Model.Customer
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }
        public Price Price { get; set; }
    }
}