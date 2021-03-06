using System;
using DevAdventCalendarCompetition.Providers;
using Xunit;

namespace DevAdventCalendarCompetition.Tests
{
    public class ErrorMessagesProviderTest
    {
        [Fact]
        public void GetMessageBody_ReturnsNotFoundMessageForNotFoundStatusCode()
        {
            // Arrange
            // Act
            var result = ErrorMessagesProvider.GetMessageBody(404);

            // Assert
            Assert.Contains("<p>Niestety, podana strona nie istnieje :(</p>", result.Value, StringComparison.InvariantCulture);
        }

        [Fact]
        public void GetMessageBody_ReturnsDefaultMessageForOtherStatusCode()
        {
            // Arrange
            // Act
            var result = ErrorMessagesProvider.GetMessageBody(0);

            // Assert
            Assert.Contains($"<h1 class=\"mb-30\">Ups... Coś poszło nie tak...</h1>\r\n<p>Nasze elfy już nad tym pracują ;-)</p>", result.Value, StringComparison.InvariantCulture);
        }
    }
}