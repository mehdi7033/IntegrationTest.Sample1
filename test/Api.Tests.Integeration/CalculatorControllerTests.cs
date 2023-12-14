using FluentAssertions;

namespace Api.Tests.Integeration
{
    public class CalculatorControllerTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 4, 7)]
        public async Task AddTwoNumbersTest(double number1, double number2, double result)
        {
            //fixture setup
            var application = new Setup();
            var client = application.CreateClient();

            //excercise
            var response = await client.GetAsync($"calculator/add/{number1}/{number2}");
            var responseString = await response.Content.ReadAsStringAsync();

            //verify
            responseString.Contains(result.ToString()).Should().BeTrue();
        }
    }
}
