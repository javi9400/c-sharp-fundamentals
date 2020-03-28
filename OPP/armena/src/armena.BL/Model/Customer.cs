using System;
using System.Collections.Generic;

namespace armena.BL.Model
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            
            get
            {
                string fullName=FirstName;
                if(!string.IsNullOrWhiteSpace(LastName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName+=", ";
                    }
                    fullName+=LastName;
                }
               
               return fullName;
            }
        }
        public string EmailAddress { get; set; }


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

        public bool Validate(){

            var isValid=true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid=false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid=false;

            return isValid;

        }


        public List<Customer> ListAll(){
            
            return new List<Customer>();
        }
    }
}
