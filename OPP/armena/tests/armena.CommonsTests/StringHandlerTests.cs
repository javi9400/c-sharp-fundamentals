using System;
using armena.Commons;
using Xunit;

namespace armena.CommonsTests
{
    public class StringHandlerTests
    {
        [Fact]
        public void TestInsertSpaces()
        {
            //act
            var source="SonicScrewdriver";
            var expected="Sonic Screwdriver";
            //arrange
            
            var actual=source.InsertSpaces();

            //assert


            Assert.Equal(expected,actual);


        }
    }
}
