using System.Collections.Generic;
using System.Collections.Specialized;
using CommonObjects.ValueObjects;

namespace WorkerAccounts.Domain.Model.Worker
{
    public class Worker
    {
        public int Id { get; set; }
        public Name Name { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }


        public Validations Validations { get; set; }

        public IEnumerable<Role> Roles { get; set; }
    }
}