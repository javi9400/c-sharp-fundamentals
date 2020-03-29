using System;
using armena.BL.Model;

namespace armena.BL.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        
        public Order(int orderId)
        {
            OrderId=orderId;
        }
        public Order()
        {
            
        }

         public bool Validate()
        {
            var isValid=true;

            if(OrderDate==null) return false;

            return isValid;
        }

    }
}