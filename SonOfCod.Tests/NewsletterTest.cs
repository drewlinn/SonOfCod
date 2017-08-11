using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class NewsletterTest
    {
        [Fact]
        public void GetLetterTest()
        {
            //Arrange
            var newsletter = new Newsletter();
            newsletter.letter = "This is our new Newsletter...";

            //Act
            var result = newsletter.letter;

            //Assert
            Assert.Equal("This is our new Newsletter...", result);
        }
    }
}