using System;

namespace armena.BL
{
    public class Customer
    {
        public Customer(int customerId, string lastName, string firstName, string emailAddress)
        {
            this.CustomerId = customerId;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.EmailAddress = emailAddress;

        }
        public Customer()
        {
            
        }
        public int CustomerId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + ", " + LastName;
            }
        }
        public string EmailAddress { get; set; }



    }
}
