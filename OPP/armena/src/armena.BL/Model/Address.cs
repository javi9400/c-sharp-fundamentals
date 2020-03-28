namespace armena.BL.Model
{
    public class Address
    {

        public int AddressId { get; private set; }
        public string FirstStreetLine { get; set; }
        public string SecondStreetLine { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public double? PostalCode { get; set; }

        public string Country { get; set; }

        public int AddressType { get;  set; }


        public Address(int addressId)
        {
            AddressId=addressId;
        }
        public Address()
        {
            
        }
        public bool Validate(){

            var isValid=true;

            // if(string.IsNullOrWhiteSpace(FirstStreetLine)) isValid= false;
            // if(string.IsNullOrWhiteSpace(City)) isValid= false;
            // if(string.IsNullOrWhiteSpace(State)) isValid= false;
            if(PostalCode==null) isValid= false;
            if(string.IsNullOrWhiteSpace(Country)) isValid= false;
        
            return isValid;
        }
    }
}