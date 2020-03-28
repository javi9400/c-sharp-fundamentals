namespace armena.BL.Model
{
    public class OrderItem
    {

     public int OrderItemId { get; private set; }
     public int ProductId { get; set; }

     public int Quantity { get; set; }

     public decimal? PurchasePrice { get;  set; }

    public OrderItem()
    {
        
    }

    public OrderItem(int orderItemId)
    {
        OrderItemId=orderItemId;
    }
         public bool Validate()
        {
            var isValid=true;

            if(PurchasePrice==null) return false;
            if(Quantity<=0)return false;
            if(ProductId<=0)return false;
            
            return isValid;
        }

      public OrderItem Retrieve(){
          return new OrderItem();
      }

      public bool Save(){
          return true;
      }


    }
}