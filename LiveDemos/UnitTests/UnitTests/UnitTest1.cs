using Calculator;

namespace UnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 2, 6)]
        [InlineData(-1, 2, 1)]
        public void TestAdd(int a, int b, int expected)
        {
            // Arrange
            //int expected = 3;
            //int a = 1;
            //int b = 2;
            Rekenmachine mc = new Rekenmachine();

            // Act
            int actual = mc.Add(a,b);

            // Assert
            Assert.Equal(expected, actual);
            //Console.WriteLine(actual == expected ? "OK" : "NOK");
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 2, 2)]
        [InlineData(-1, 2, -3)]
        public void TestSubtract(int a, int b, int expected)
        {
            // Arrange
            //int expected = 3;
            //int a = 1;
            //int b = 2;
            Rekenmachine mc = new Rekenmachine();

            // Act
            int actual = mc.Subtract(a, b);

            // Assert
            Assert.Equal(expected, actual);
            //Console.WriteLine(actual == expected ? "OK" : "NOK");
        }
    }
}