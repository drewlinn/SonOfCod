using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class RecipientTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var recipient = new Recipient();
            recipient.firstName = "Andrew";
            //Act
            var result = recipient.firstName;

            //Assert
            Assert.Equal("Andrew", result);
        }
    }
}