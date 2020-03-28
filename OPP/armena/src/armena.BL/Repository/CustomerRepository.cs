using armena.BL.Model;

namespace armena.BL.Repository
{
    public class CustomerRepository
    {
         public Customer Retrieve(int customerid)
        {
           Customer customer=null;
           
           if(customerid==1)
           {
               customer= new Customer(1,"luke","Skywalker","theDarkForceRules@hotmail.com");
           }

           return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}