using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    class CommonSteps
    {
        public const decimal Value2 = 10;
        public const decimal Value1 = 50;
        public const Currency Currency = NET.Currency.Euro;

        public static Coin Coin1 { get; set; }
        public static Coin Coin2 { get; set; }

        public static Coin OperationResult { get; set; }

        [Given]
        public void GivenIHaveTheCoinObjectCoin1WithCurrencyC()
        {
            Coin1 = new Coin(Value1, Currency);
        }

        [Given]
        public void GivenIHaveTheCoinObjectCoin2WithCurrencyC()
        {
            Coin2 = new Coin(Value2, Currency);
        }

        [Then]
        public void ThenTheResultIsANewlyCreatedCoinObject()
        {
            OperationResult.Should().BeOfType<Coin>();
        }

        [Then]
        public void ThenItsCurrencyIsSetToC()
        {
            OperationResult.Currency.Should().Be(Currency);
        }
    }
}
