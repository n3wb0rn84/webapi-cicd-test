using webapi_cicd.Services;

namespace webapi_cicd.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 1, 0)]
        [InlineData(-2, -3, -5)]
        [InlineData(10, 5, 15)]
        [InlineData(100, 200, 300)]
        [InlineData(-10, 5, -5)]
        [InlineData(7, 8, 15)]
        public void Add_ShouldReturnExpectedResult(int a, int b, int expected)
        {
            // Arrange
            AdditionService additionService = new AdditionService();

            // Act
            var result = additionService.addition(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
