using System;
using armena.BL.Model;

namespace armena.BL.Repository
{
    public class OrderRepository
    {
     public Order Retrieve(int orderId){
         
          var order= new Order(orderId);
          
          if(orderId==10)
          {
              order.OrderDate=new DateTimeOffset(DateTime.Now.Year,3,28,17,00,00,new TimeSpan(7,0,0));
          }

          return order;
      }

      public bool Save(){
          return true;
      }

    }
}