using FluentAssertions;
using TechTalk.SpecFlow;

namespace Coin.NET.Tests.ChangingValue
{
    [Binding]
    public class ChangingValueSteps
    {
        private const decimal NewValue = 100.0M;

        private Coin _coin;

        [Given]
        public void GivenIHaveCreatedACoinObject()
        {
            _coin = new Coin();
        }

        [When]
        public void WhenIAssignANewValueToTheValueProperty()
        {
            _coin.Value = NewValue;
        }

        [Then]
        public void ThenItSValueIsChangedToProvidedOne()
        {
            _coin.Value.Should().Be(NewValue);
        }
    }
}