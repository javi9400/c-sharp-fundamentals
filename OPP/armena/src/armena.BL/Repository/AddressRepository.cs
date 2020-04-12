using System.Collections.Generic;
using armena.BL.Model;

namespace armena.BL.Repository
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address= new Address(addressId);
            
            if(addressId==1)
            {
                address.City="Teguciglpa";
                address.Country="Honduras";
                address.PostalCode=11101D;
                address.FirstStreetLine="Santa lucia BO La laguna";
                address.State="FMA";
            }

            return address;
        }

        public bool Save(Address address)
        {
            return true;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
             var addressList=new List<Address>()
             {
                new Address(1){
                City="Teguciglpa",
                Country="Honduras",
                PostalCode=11101D,
                FirstStreetLine="Santa lucia BO La laguna",
                State="FMA"
                 },
                new Address(2){
                City="Comayagua",
                Country="Honduras",
                PostalCode=11101D,
                FirstStreetLine="Lejamani",
                State="CMO"
                 }
             };

             return addressList;           
        }
    }
}