namespace armena.BL.Model
{
    public class Product:EntityBase
    {

        public int ProductId{get; private set;}
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal? CurrentPrice { get;  set; }        

        public Product(int productId)
        {
            ProductId=productId;
        }
        public Product()
        {
            
        }
        public override bool Validate()
        {
            var isValid=true;

            if(string.IsNullOrWhiteSpace(Name)) return false;
            if(string.IsNullOrWhiteSpace(Description)) return false;
            if(CurrentPrice==null) return false;

            return isValid;
        }

        public bool Save(Product product)
        {
            var sucess=true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
                    {
                            //call insert
                    }
                    else
                    {
                            //call update
                    }
                }
                else{
                    sucess=false;
                }
            }
            return sucess;
        }


    }
}