using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.MathOperations
{
    [Binding]
    public class AddingCoinsSteps
    {
        private const decimal Value2 = 10;
        private const decimal Value1 = 5;
        private const Currency Currency = NET.Currency.Euro;

        private Coin _coin1;
        private Coin _coin2;
        private Coin _operationResult;

        [Given]
        public void GivenIHaveTheCoinObjectCoin1WithCurrencyC()
        {
            _coin1 = new Coin(Value1, Currency);
        }

        [Given]
        public void GivenIHaveTheCoinObjectCoin2WithCurrencyC()
        {
            _coin2 = new Coin(Value2, Currency);
        }

        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionOperator()
        {
            _operationResult = _coin1 + _coin2;
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentOperator()
        {
            _coin1 += _coin2;
        }

        [When]
        public void WhenIAddCoin1AndCoin2UsingAdditionMethod()
        {
            _operationResult = Coin.Add(_coin1, _coin2);
        }

        [When]
        public void WhenIAddCoin1ToCoin2UsingAdditionAssignmentMethod()
        {
            _coin1.Add(_coin2);
        }

        [Then]
        public void ThenTheResultIsANewlyCreatedCoinObject()
        {
            _operationResult.Should().BeOfType<Coin>();
        }

        [Then]
        public void ThenItsCurrencyIsSetToC()
        {
            _operationResult.Currency.Should().Be(Currency);
        }

        [Then]
        public void ThenItsValueIsASumOfCoin1ValueAndCoin2Value()
        {
            _operationResult.Value.Should().Be(Value1 + Value2);
        }

        [Then]
        public void ThenTheValueOfCoin1IsASumOfCoin1OldValueAndCoin2Value()
        {
            _coin1.Value.Should().Be(Value1 + Value2);
        }
    }
}