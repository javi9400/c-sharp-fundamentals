using armena.BL.Model;
using System.Linq;
namespace armena.BL.Repository
{
    public class CustomerRepository
    {

        private AddressRepository _addressRepo;

        public CustomerRepository()
        {
            _addressRepo=new AddressRepository();
        }
         public Customer Retrieve(int customerid)
        {
           Customer customer=null;
           
           if(customerid==1)
           {
               customer= new Customer(1,"luke","Skywalker","theDarkForceRules@hotmail.com");
               customer.AddressList=_addressRepo.RetrieveByCustomerId(customer.CustomerId).ToList();
           }

           return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}