using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddShouldSucceed()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int firstTerm = 5;
            int secondTerm = 8;
            int actualResult = calculator.Add(firstTerm, secondTerm);

            // Assert
            int expectedResult = firstTerm + secondTerm;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractShouldSucceed()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int firstTerm = 5;
            int secondTerm = 8;
            int actualResult = calculator.Subtract(firstTerm, secondTerm);

            // Assert
            int expectedResult = firstTerm - secondTerm;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }   
}
