using armena.BL.Model;

namespace armena.BL.Repository
{
    public class ProductRepository
    {
      public Product Retrieve(int id){
          
          Product product= new Product(1);

          if (product.ProductId==1)
          {
              product.CurrentPrice=250.99m;
              product.Description="Music airpods";
              product.Name="Air pods";
          }

          return product;
      }

      public bool Save(){
          return true;
      }

    }
}