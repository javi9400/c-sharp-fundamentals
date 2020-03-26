using System;
using Xunit;
using armena.BL;

namespace armena.BLTest
{
    public class TestArmenaBusinessLogic
    {
        [Fact]
        public void TestingCanCreateObjectFromCustomerClass()
        {
            //Arrange

            Customer customer= new Customer();
            customer.FirstName="Anakin";
            customer.LastName="Skywalker";
            customer.EmailAddress="darkside@neworder.io";

            //ACT

            var expected="Anakin, Skywalker";

            var actual=customer.FullName;

            //ASSERT
            Assert.Equal(expected,actual);


        }
 
    }
}
