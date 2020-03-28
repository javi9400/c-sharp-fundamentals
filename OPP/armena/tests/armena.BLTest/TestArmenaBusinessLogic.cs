using System;
using Xunit;
using armena.BL.Model;

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
 

        [Fact]
        public void FullNameFirstEmpty()
        {
            //Arrange

            Customer customer= new Customer();
            customer.LastName="Skywalker";
            customer.EmailAddress="darkside@neworder.io";

            //ACT

            var expected="Skywalker";

            var actual=customer.FullName;

            //ASSERT
            Assert.Equal(expected,actual);


        }


        [Fact]
        public void TestingLastNameEmpty()
        {
            //Arrange

            Customer customer= new Customer();
            customer.FirstName="Anakin";
            customer.EmailAddress="darkside@neworder.io";

            //ACT

            var expected="Anakin";

            var actual=customer.FullName;

            //ASSERT
            Assert.Equal(expected,actual);


        }

          [Fact]
        public void TestingValidateMethod()
        {
            //Arrange

            Customer customer= new Customer();
            customer.FirstName="Anakin";
            customer.EmailAddress="darkside@neworder.io";
            customer.LastName="Skywalker";
            //ACT

            var expected=true;

            var actual=customer.Validate();

            //ASSERT
            Assert.Equal(expected,actual);


        }
    }
}
