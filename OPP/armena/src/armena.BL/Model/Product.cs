namespace armena.BL.Model
{
    public class Product
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
        public bool Validate()
        {
            var isValid=true;

            if(string.IsNullOrWhiteSpace(Name)) return false;
            if(string.IsNullOrWhiteSpace(Description)) return false;
            if(CurrentPrice==null) return false;

            return isValid;
        }


    }
}