using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzz.UnitTests
{
    public class GameLogicTests
    {
        [Test]
        public void GameLogic_NumbersFromOneToFifteen_ShouldReturnExpectedList()
        {
            // Arrange
            var initialNumber = 1;
            var lastNumber = 15;
            List<string> expectedList = new() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "Fizz Buzz" };

            // Act
            var result = GameLogic.GetGameResult(initialNumber, lastNumber);

            // Assert
            Assert.AreEqual(result, expectedList);
        }
    }
}