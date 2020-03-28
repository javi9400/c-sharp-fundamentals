using armena.BL.Model;
using armena.BL.Repository;
using Xunit;

namespace armena.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void TestingRetrieveMethod()
        {
            //Arrange
            CustomerRepository repo= new CustomerRepository();

            //act
            var actual=repo.Retrieve(1);
            var expectedCustomer= new Customer(1,"luke","Skywalker","theDarkForceRules@hotmail.com");

            //assert
            Assert.Equal(actual.FirstName,expectedCustomer.FirstName);

        }
    }
}