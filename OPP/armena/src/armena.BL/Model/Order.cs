using System;
using System.Collections.Generic;
using armena.BL.Model;

namespace armena.BL.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        
        public Order(int orderId)
        {
            OrderId=orderId;
            this.OrderItems=new List<OrderItem>();
        }
        public Order():this(0)
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