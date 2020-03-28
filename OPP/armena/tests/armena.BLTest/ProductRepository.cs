using armena.BL.Model;
using armena.BL.Repository;
using Xunit;

namespace armena.BLTest
{
    public class TestProductRepository
    {
         [Fact]
        public void TestingRetrieveMethod()
        {
            //Arrange
            ProductRepository repo= new ProductRepository();

            //act
            var actual=repo.Retrieve(1);
            var expectedProduct= new Product(1);
            expectedProduct.Description="Music airpods";
            expectedProduct.Name="Air pods";
            
            //assert
            Assert.Equal(actual.Name,expectedProduct.Name);

        }
    }
}